using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HiberoExtintores
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }




        private void btnAnotar_Click(object sender, EventArgs e)
        {
            frmExtintor f = new frmExtintor();
            f.ShowDialog();
        }
    }
}
