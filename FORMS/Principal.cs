using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Control.FORMS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        // ===============================================

        private void menuPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar frmPesquisar = new Pesquisar();
            frmPesquisar.ShowDialog();
        }

        // ===============================================

        private void cadConta_Click(object sender, EventArgs e)
        {
            CadConta frmConta = new CadConta();
            frmConta.ShowDialog();
        }

        // ===============================================

        private void cadEmpresa_Click(object sender, EventArgs e)
        {
            Empresa frmEmpresa = new Empresa();
            frmEmpresa.ShowDialog();
        }

        // ===============================================

            // FECHAR O SISTEMA

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
