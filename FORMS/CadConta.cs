using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account_Control.BLL;
using Account_Control.DTO;

namespace Account_Control.FORMS
{
    public partial class CadConta : Form
    {
        public CadConta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        // ====================================================

            // MÉTODO PARA LIMPAR OS CAMPOS

        private void LimparCampos()
        {
            txtCodigoConta.Clear();
            cbEmpresa.SelectedIndex = 0;
            txtValor.Clear();
            dtVencimento.ResetText();
            txtDescConta.Clear();
            txtValor.Focus();
            txtCodigoConta.Enabled = false;
        }

        // ====================================================

            // BOTÃOSAIR

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ====================================================

            // BOTÃO ATIVAR DO ID CONTA

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            txtCodigoConta.Enabled = true;
            txtCodigoConta.Focus();
        }

        // ====================================================

            // MÉTODO QUE MOSTRA AS EMPRESAS NO COMBO BOX

        private void Combo()
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
            
                
                cbEmpresa.DataSource = bll.ListaEmpresaComboDal();

                cbEmpresa.DisplayMember = "idEmpresa";
                cbEmpresa.ValueMember = "nome";
                
              }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        // ===============================================

            // MÉTODO LOAD DO FORM CADASTRO DE CONTAS

        private void CadConta_Load(object sender, EventArgs e)
        {
            Combo();
        }

        // ===============================================

            // MÉTODO DO LABEL EMBAIXO DO COMBO BOX

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmpresa.Text = cbEmpresa.SelectedValue.ToString();
        }

        // ===============================================

            // BOTÃO SALVAR

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objConta = new ClasseDTO();

                objConta.Empresa = Convert.ToInt32(cbEmpresa.Text);
                objConta.Valor = Convert.ToDouble(txtValor.Text);
                objConta.Vencimento = Convert.ToDateTime(dtVencimento.Text);
                objConta.DescConta = txtDescConta.Text;

               // if (txtValor.Text == string.Empty || mtbVencimento.Text == string.Empty) { 

                bll.SalvarContaDal(objConta);

                MessageBox.Show("Salvo com sucesso!", "Mensagem de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch 
            {
                MessageBox.Show("O VALOR e a DATA DE VENCIMENTO não podem ficar vázios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Question);

                txtValor.Focus();
               
            }
        }

        // ===============================================

            // BOTÃO LIMPAR

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // ===============================================

            // BOTÃO ALTERAR CONTA

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objConta = new ClasseDTO();

                if(txtCodigoConta.Text == string.Empty || txtValor.Text == string.Empty)
                {
                    MessageBox.Show("Não foi possivel atualizar os dados!\n Campos obrigatórios vazios!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoConta.Focus();
                }
                else
                { 

                objConta.IdConta = Convert.ToInt32(txtCodigoConta.Text);
                objConta.Empresa = Convert.ToInt32(cbEmpresa.Text);
                objConta.Valor = Convert.ToDouble(txtValor.Text);
                objConta.Vencimento = Convert.ToDateTime(dtVencimento.Text);
                objConta.DescConta = txtDescConta.Text;

                    bll.AtualizarContaDal(objConta);

                    MessageBox.Show("Atualizado com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (txtValor.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            else if(!char.IsNumber(e.KeyChar)&& !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
