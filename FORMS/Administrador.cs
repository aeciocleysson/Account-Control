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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Logar()
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "12345")
                MessageBox.Show("Autorização bem sucedida!", "Autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (txtLogin.Text == string.Empty || txtSenha.Text == string.Empty)
                MessageBox.Show("Não autorizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (txtLogin.Text != txtLogin.Text || txtSenha.Text != txtSenha.Text)
                MessageBox.Show("Não autorizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Logar();
            Close();
        }
    }
}
