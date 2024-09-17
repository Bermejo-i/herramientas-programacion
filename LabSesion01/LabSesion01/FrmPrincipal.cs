using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSesion01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApp01_Click(object sender, EventArgs e)
        {
            FrmAplicacion1 frm = new FrmAplicacion1();
            frm.Show();
            this.Hide();
        }

        private void btnApp02_Click(object sender, EventArgs e)
        {
            FrmAplicacion2 frm = new FrmAplicacion2();
            frm.Show();
            this.Hide();
        }

        private void btnApp03_Click(object sender, EventArgs e)
        {
            FrmAplicacion3 frm = new FrmAplicacion3();
            frm.Show();
            this.Hide();
        }

        private void btnApp04_Click(object sender, EventArgs e)
        {
            FrmAplicacion4 frm = new FrmAplicacion4();
            frm.Show();
            this.Hide();
        }

        private void bntFin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Sesion 01",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            { Application.Exit(); }
        }
    }
}
