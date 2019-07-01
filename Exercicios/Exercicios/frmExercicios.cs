using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class frmExercicios : Form
    {
        public frmExercicios()
        {
            InitializeComponent();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            frmConta conta = new frmConta();
            conta.ShowDialog();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Exercicios.Conta.CalculadoraSimples1.frmCalculadora calculadora = new Exercicios.Conta.CalculadoraSimples1.frmCalculadora();
            calculadora.ShowDialog();
        }

        private void frmExercicios_Load(object sender, EventArgs e)
        {

        }
    }
}
