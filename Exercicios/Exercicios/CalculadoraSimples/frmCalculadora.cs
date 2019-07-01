using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios.Conta.CalculadoraSimples1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        public double numero1 = 0;
        public double numero2 = 0;

      //  public double numeroVisor1 = 0;
      //  public double numeroVisor2 = 0;
        public string visor = "";
        public double resultado = 0;
        public string operacao = "";

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
        }

        public void LimparVisor()
        {
            txtVisor.Clear();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
                LimparVisor();
                numero1 = Convert.ToDouble("1");
                visor += numero1.ToString();
                numero1 = Convert.ToDouble(visor);
                //txtVisor.Text += numero1;
                //visor = "";
            }

            else
            {
                // LimparVisor();
              //  numero2 = Convert.ToDouble("1");
                visor += numero2.ToString();
                numero2 = Convert.ToDouble(visor);
                txtVisor.Text += numero2;
            }
           txtVisor.Text += "1"; //parei aqui
               
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("2");
                visor += numero1.ToString();
            }

            else
            {
                //LimparVisor();
                numero2 = Convert.ToDouble("2");
                visor += numero2.ToString();
            }
            txtVisor.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("3");
                visor += numero1.ToString();
            }

            else
            {
                //LimparVisor();
                numero2 = Convert.ToDouble("3");
                visor += numero2.ToString();
            }
            txtVisor.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("4");
                visor += numero1.ToString();
            }

            else
            {
                //  LimparVisor();
                numero2 = Convert.ToDouble("4");
                visor += numero2.ToString();
            }
            txtVisor.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("5");
                visor += numero1.ToString();
            }

            else
            {
                //LimparVisor();
                numero2 = Convert.ToDouble("5");
                visor += numero2.ToString();
            }
            txtVisor.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("6");
                visor += numero1.ToString();
            }

            else
            {
                //LimparVisor();
                numero2 = Convert.ToDouble("6");
                visor += numero2.ToString();
            }
            txtVisor.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("7");
                visor += numero1.ToString();
            }

            else
            {
                // LimparVisor();
                numero2 = Convert.ToDouble("7");
                visor += numero2.ToString();
            }
            txtVisor.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("8");
                visor += numero1.ToString();
            }

            else
            {
                //   LimparVisor();
                numero2 = Convert.ToDouble("8");
                visor += numero2.ToString();
            }
            txtVisor.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (numero1 == 0)
            {
                LimparVisor();
                numero1 = Convert.ToDouble("9");
                visor += numero1.ToString();
            }

            else
            {
                // LimparVisor();
                numero2 = Convert.ToDouble("9");
                visor += numero2.ToString();
            }
            txtVisor.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (operacao == "")
            {
              //  LimparVisor();
                numero1 = Convert.ToDouble("0");
                visor += numero1.ToString();
                numero1 = Convert.ToDouble( visor);
            }

            else
            {
                //  LimparVisor();
                numero2 = Convert.ToDouble("0");
                visor += numero2.ToString();
                 numero2 = Convert.ToDouble( visor);
            }
            
            txtVisor.Text += "0";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operacao = "somar";
            txtVisor.Text += " + ";
            visor = "";
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operacao = "subtrair";
            txtVisor.Text += " - ";
            visor.Equals("");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacao = "multiplicar";
            txtVisor.Text += " * ";
            visor.Equals("");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacao = "dividir";
            txtVisor.Text += " / ";
            visor.Equals("");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            LimparVisor();
            if (operacao == "somar")
            {
                resultado = numero1 + numero2;

            }

            else if (operacao == "subtrair")
            {
                resultado = numero1 - numero2;
            }

            else if (operacao == "multiplicar")
            {
                resultado = numero1 * numero2;
            }

            else if (operacao == "dividir")
            {
                resultado = numero1 / numero2;

            }

            txtVisor.Text = resultado.ToString();
            numero1 = resultado;
        }
    }
}
