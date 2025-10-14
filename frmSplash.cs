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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pgbsplash_Click(object sender, EventArgs e)
        {

        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }

        private void tmtsplash_Tick(object sender, EventArgs e)
        {
            if(pgbsplash.Value < 100)
            {
                pgbsplash.Value = pgbsplash.Value + 1;
                lblnumero.Text = pgbsplash.Value.ToString() + " % ";
            }
            else
            {
                tmtsplash.Enabled=false;
                frmLogin abrir = new frmLogin();
                abrir.Show();
                this.Hide();
            }
        }

      
    }
}
