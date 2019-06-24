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
    public partial class frmExtintor : Form
    {
        public frmExtintor()
        {
            InitializeComponent();
        }

        private void frmExtintor_Load(object sender, EventArgs e)
        {
            PreencherCombos();
        }

        public void PreencherCombos()
        {
            clnMarca a = new clnMarca();
            cboMarca.DataSource = a.PreencherMarca().Tables[0];
            cboMarca.ValueMember = "codMarca";
            cboMarca.DisplayMember = "descricao";
            cboMarca.SelectedIndex = -1;


            clnNorma b = new clnNorma();
            cboNorma.DataSource = b.PreencherNorma().Tables[0];
            cboNorma.ValueMember = "codNorma";
            cboNorma.DisplayMember = "descricao";
            cboNorma.SelectedIndex = -1;

            clnProjeto c = new clnProjeto();
            cboProjeto.DataSource = c.PreencherProjeto().Tables[0];
            cboProjeto.ValueMember = "codProjeto";
            cboProjeto.DisplayMember = "descricao";
            cboProjeto.SelectedIndex = -1;

            clnTipo d = new clnTipo();
            cboTipo.DataSource = d.PreencherTipo().Tables[0];
            cboTipo.ValueMember = "codTipo";
            cboTipo.DisplayMember = "descricao";
            cboTipo.SelectedIndex = -1;

            clnCargaNominal e = new clnCargaNominal();
            cboCargaNominal.DataSource = e.PreencherCargaNominal().Tables[0];
            cboCargaNominal.ValueMember = "codCargaNominal";
            cboCargaNominal.DisplayMember = "descricao";
            cboCargaNominal.SelectedIndex = -1;


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int pintura = 0;
            if(chkPintura.Checked == true)
            { pintura = 1; }
            else { pintura = 0; }
            clnExtintor ext = new clnExtintor();
            ext.AnoFab = Convert.ToInt32( txtAnoFab.Text);
            ext.NumExt = Convert.ToInt32(txtNumExt.Text);
            ext.NumSelo = Convert.ToInt32(txtNumSelo.Text);
            ext.Pintura = pintura;
            ext.Nivel = Convert.ToInt32( lblNivelManut.Text);
            ext.AnoTeste = Convert.ToInt32( txtAnoTeste.Text);
            //ext.Cod = txt
            ext.CodCargaNominal = Convert.ToInt32( cboCargaNominal.SelectedValue);
            ext.CodMarca = Convert.ToInt32( cboMarca.SelectedValue);
            ext.CodNorma = Convert.ToInt32(cboNorma.SelectedValue);
            ext.CodProjeto = Convert.ToInt32(cboProjeto.SelectedValue);
            ext.CodTipo = Convert.ToInt32(cboTipo.SelectedValue);
            ext.Gravar();
            MessageBox.Show("Dados salvo com sucesso!!!", "Inserção");

        }

        private void txtAnoTeste_Leave(object sender, EventArgs e)
        {
            if (txtAnoTeste.Text == "2019" || txtAnoTeste.Text == "2018" ||
                txtAnoTeste.Text == "2017" || txtAnoTeste.Text == "2016" ||
                txtAnoTeste.Text == "2015")
            {
                lblNivelManut.Text = "2";
            }

            else
            {
                lblNivelManut.Text = "3";
            }
        
        }

    }
}
