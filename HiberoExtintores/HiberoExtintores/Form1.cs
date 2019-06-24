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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            clnTeste teste = new clnTeste();
            teste.Cod = Convert.ToInt32( txtCod.Text);
            teste.Desc = txtDesc.Text;
            teste.Gravar();
            MessageBox.Show("Dados salvos com sucesso");
        }
    }
}
