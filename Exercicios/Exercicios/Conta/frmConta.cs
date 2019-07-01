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
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        public double saldo = 0;
        public double saque = 0;
        public double deposito = 0;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {                     
           btnSalvar.BackColor = Color.GreenYellow;
        }

        private void rdoDeposito_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Text = "Depositar";
        }

        private void rdoSaque_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Text = "Sacar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clnConta conta = new clnConta();

            if (btnSalvar.Text == "Sacar")
            {
                //conta.Saldo = conta.Saldo - conta.Saque;
               
                saque = Convert.ToDouble(txtValor.Text.Replace(".",","));
                
                saldo = saldo - saque;
            }

            else if (btnSalvar.Text == "Depositar")
            {
               // conta.Saldo = conta.Saldo + conta.Deposito;
                deposito = Convert.ToDouble(txtValor.Text.Replace(".", ","));
                saldo = saldo + deposito;
                
            }

           // lblMostrarSaldo.Text = Convert.ToString( conta.Saldo);
            lblMostrarSaldo.Text = Convert.ToString(saldo);
            saldo = Convert.ToDouble(lblMostrarSaldo.Text);

            if (saldo <= 0)
            {

                lblMostrarSaldo.ForeColor = Color.Red;
            }

            else
            {
                lblMostrarSaldo.ForeColor = Color.Green;
                lblMostrarSaldo.Font.Equals("Arial");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
        }

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {
            
            btnSalvar.BackColor = Color.ForestGreen;
        }

        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            btnSalvar.BackColor = Color.GreenYellow;
        }
        }

       
    }

