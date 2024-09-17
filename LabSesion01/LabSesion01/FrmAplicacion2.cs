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
    public partial class FrmAplicacion2 : Form
    {
        public FrmAplicacion2()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Dispose();
        }
    }
}
