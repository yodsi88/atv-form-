using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTabajara
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txtusuario.Text;
            senha = Convert.ToInt32(txtsenha.Text);


            if (usuario =="admin" & senha == 123)
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario e senha incoretos ");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsenha.Clear();
            txtusuario.Clear();
        }
    }
}
