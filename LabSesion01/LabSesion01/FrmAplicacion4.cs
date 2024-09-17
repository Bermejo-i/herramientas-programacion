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
    public partial class FrmAplicacion4 : Form
    {
        public FrmAplicacion4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Dispose();
        }
    }
}
