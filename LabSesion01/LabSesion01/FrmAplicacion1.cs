﻿using System;
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
    public partial class FrmAplicacion1 : Form
    {
        public FrmAplicacion1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
