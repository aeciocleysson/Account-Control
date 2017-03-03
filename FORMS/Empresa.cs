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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        // ===============================================

            // MÉTODO PARA LIMPAR OS CAMPOS

        private void LimparCampos()
        {
            txtCodigoEmpresa.Clear();
            txtCodigoEmpresa.Enabled = false;
            txtNomeEmpresa.Clear();
            txtNomeEmpresa.Focus();
            mtbTelefone.Clear();
            txtDescEmpresa.Clear();

        }

        // ===============================================

            // BOTÃO SALVAR

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objEmpresa = new ClasseDTO();

                objEmpresa.Nome = txtNomeEmpresa.Text;
                objEmpresa.Telefone = mtbTelefone.Text;
                objEmpresa.DescEmpresa = txtDescEmpresa.Text;

                if (txtNomeEmpresa.Text == string.Empty) { 
                    MessageBox.Show("O Empresa deve ser preenchido!", "Aviso Importante!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeEmpresa.Focus();
                }
                else
                {
                    bll.SalvarEmpresaDal(objEmpresa);

                    MessageBox.Show("Salvo com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ===============================================

            // BOTÃO SAIR

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ===============================================

            // BOTÃO LIMPAR

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // ===============================================

            // BOTÃO ATIVAR CÓDIGO EMPRESA

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            txtCodigoEmpresa.Enabled = true;
            txtCodigoEmpresa.Focus();
        }

        // ===============================================

            // BOTÃO ATUALIZAR EMPRESA

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objEmpresa = new ClasseDTO();

                if (txtCodigoEmpresa.Text == string.Empty || txtNomeEmpresa.Text == string.Empty)
                {
                    MessageBox.Show("Não foi possivel atualizar os dados! \nCampo obrigatório vázio!", "Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                }
                else
                {

                    objEmpresa.IdEmpresa = Convert.ToInt32(txtCodigoEmpresa.Text);
                    objEmpresa.Nome = txtNomeEmpresa.Text;
                    objEmpresa.Telefone = mtbTelefone.Text;
                    objEmpresa.DescEmpresa = txtNomeEmpresa.Text;

                    bll.AtualizarEmpresaDal(objEmpresa);
                    MessageBox.Show("Atualizado om sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
