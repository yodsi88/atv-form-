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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            frmCliente abrir = new frmCliente();
            abrir.Show();
            this.Hide();
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            frmProduto abrir = new frmProduto();
            abrir.Show();
            this.Hide();
        }

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor abrir = new frmFornecedor();
            abrir.Show();
            this.Hide();

        }


    }
}
