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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        // ===============================================

        private void AdmSystem()
        {
            Administrador frmAdm = new Administrador();
            frmAdm.ShowDialog();
        }

        // ===============================================

            // MÉTODO PARA LISTAR AS CONTAS NO DATA GRID

        private void ListaContaGrid()
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();

                dataGridDados.DataSource = bll.ListaContaDal();

                dataGridDados.Columns[0].HeaderText = "\nCÓDIGO\n";
                dataGridDados.Columns[1].HeaderText = "\nVALOR\n";
                dataGridDados.Columns[2].HeaderText = "\nDATA DE VENCIMENTO\n";
                dataGridDados.Columns[3].HeaderText = "\nDESCRIÇÃO\n";
                dataGridDados.Columns[4].HeaderText = "\nEMPRESA\n";

                dataGridDados.Columns[1].Width = 108;
                dataGridDados.Columns[2].Width = 180;
                dataGridDados.Columns[3].Width = 300;

            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        // ===============================================

            // MÉTODO PARA LISTAR AS EMPRESA NO DATA GRID

        private void ListaEmpresaGrid()
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();

                dataGridDados.DataSource = bll.ListaEmpresaDal();

                dataGridDados.Columns[0].HeaderText = "\nCÓDIGO\n";
                dataGridDados.Columns[1].HeaderText = "\nNOME\n";
                dataGridDados.Columns[2].HeaderText = "\nTELEFONE\n";
                dataGridDados.Columns[3].HeaderText = "\nDESCRIÇÃO\n";

                dataGridDados.Columns[1].Width = 200;
                dataGridDados.Columns[2].Width = 150;
                dataGridDados.Columns[3].Width = 355;

            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

            //===============================================

            // MÉTODO PARA EXCLUIR AS CONTAS

        private void ExcluirConta()
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objConta = new ClasseDTO();

                objConta.IdConta = Convert.ToInt32(txtExcluirItem.Text);

               if( MessageBox.Show("Deseja excluir? \nTodas as informações referente a esse registro seram perdidas!", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    
                }
                else
                {
                   // AdmSystem();
                    bll.ExcluirContasDal(objConta);

                    MessageBox.Show("Excluido com sucesso!", "Mensagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // ===============================================

            // MÉTODO PARA EXCLUIR EMPRESA

        private void ExcluirEmpresa()
        {
            try
            {
                ClasseBLL bll = new ClasseBLL();
                ClasseDTO objEmpresa = new ClasseDTO();

                objEmpresa.IdEmpresa = Convert.ToInt32(txtExcluirItem.Text);

                if (MessageBox.Show("Deseja excluir? \nTodas as informações referente a esse registro seram perdidas!", "Aviso importante!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {

                }
                else
                {
                    bll.ExcluirEmpresaDal(objEmpresa);
                    MessageBox.Show("Excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
              MessageBox.Show("Existem registros relacionados a essa empresa! \nNão pode ser apagada!", "Aviso Importante!" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // ===============================================

        // BOTÃO PESQUISAR

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbConta.Checked)
                    ListaContaGrid();
                else if (rbEmpresa.Checked)
                    ListaEmpresaGrid();
                else
                    MessageBox.Show("Nenhuma das opções foram selecionadas!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        // ===============================================

            // BOTÃO SAIR

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ===============================================

            // BOTÃO EXCLUIR

        private void btnExcluir_Click(object sender, EventArgs e)
        {
          try
            {
                if (txtExcluirItem.Text == string.Empty)
                    MessageBox.Show("Nenhum registro foi inserido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else if (rbConta.Checked)
                {
                    ExcluirConta();
                    txtExcluirItem.Clear();
                    ListaContaGrid();
                }
                else if (rbEmpresa.Checked)
                {
                    ExcluirEmpresa();
                    txtExcluirItem.Clear();
                    ListaEmpresaGrid();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
