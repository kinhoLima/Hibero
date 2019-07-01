using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    public partial class frmExtintor : Form
    {
        public frmExtintor()
        {
            InitializeComponent();
        }

        clnMarca marca = new clnMarca();
        clnNorma norma = new clnNorma();
        clnProjeto projeto = new clnProjeto();
        clnTipo tipo = new clnTipo();
        clnCargaNominal carga = new clnCargaNominal();
        clnServico servico = new clnServico();
        clnExtintor extintor = new clnExtintor();

        public int codNorma; //recebido através da combo
        public int codMarca; //recebido através da combo
        public int codTipo; //recebido através da combo
        public int codCarga; //recebido através da combo
        private void frmExtintor_Load(object sender, EventArgs e)
        {
            PreencherCombos();
        }

        public void PreencherCombos()
        {
            
            cboMarca.DataSource = marca.PreencherMarca().Tables[0];
            cboMarca.ValueMember = "codMarca";
            cboMarca.DisplayMember = "descricao";
            cboMarca.SelectedIndex = -1;



            cboNorma.DataSource = norma.PreencherNorma().Tables[0];
            cboNorma.ValueMember = "codNorma";
            cboNorma.DisplayMember = "descricao";
            cboNorma.SelectedIndex = -1;

            
            cboProjeto.DataSource = projeto.PreencherProjeto().Tables[0];
            cboProjeto.ValueMember = "codProjeto";
            cboProjeto.DisplayMember = "descricao";
            cboProjeto.SelectedIndex = -1;

            
            cboTipo.DataSource = tipo.PreencherTipo().Tables[0];
            cboTipo.ValueMember = "codTipo";
            cboTipo.DisplayMember = "descricao";
            cboTipo.SelectedIndex = -1;

            
            cboCargaNominal.DataSource = carga.PreencherCargaNominal().Tables[0];
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
            
            extintor.AnoFab = Convert.ToInt32( txtAnoFab.Text);
            extintor.NumExt = Convert.ToInt32(txtNumExt.Text);
            extintor.NumSelo = Convert.ToInt32(txtNumSelo.Text);
            extintor.Pintura = pintura;
            extintor.Nivel = Convert.ToInt32( lblNivelManut.Text);
            extintor.AnoTeste = Convert.ToInt32( txtAnoTeste.Text);
            //ext.Cod = txt
            extintor.CodCargaNominal = Convert.ToInt32( cboCargaNominal.SelectedValue);
            extintor.CodMarca = Convert.ToInt32( cboMarca.SelectedValue);
            extintor.CodNorma = Convert.ToInt32(cboNorma.SelectedValue);
            extintor.CodProjeto = Convert.ToInt32(cboProjeto.SelectedValue);
            extintor.CodTipo = Convert.ToInt32(cboTipo.SelectedValue);
            extintor.SalvarExtintor();
            servico.NumCliente = txtNumCliente.Text;
    
           // apontar cod extinto para salvar em Serviço
            //servico.AnotarExtintor();
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

        private void cboMarca_Leave(object sender, EventArgs e)
        {
            //if(txtAnoFab.Text <= cboNorma.) clnMarca marca = new clnMarca();
            OracleDataReader drMarca;
            drMarca = marca.ListarMarcaPorAno(cboMarca.Text,txtAnoFab.Text);
            if (drMarca.Read())
            {
                int codNormaMarca = Convert.ToInt32(drMarca["codnorma"].ToString());
                
                OracleDataReader drNorma = norma.ListarNorma(codNormaMarca);
                if(drNorma.Read())
                {
                    cboNorma.Text = drNorma["descricao"].ToString();
            }
            }
            

        }

        private void txtAnoFab_Leave(object sender, EventArgs e)
        {
            
            int anoAtual = System.DateTime.Now.Year;
            int anoFab = Convert.ToInt32(txtAnoFab.Text);
            int teste = anoAtual - anoFab;

            if (teste == 5)
            {
                txtAnoTeste.Enabled = true;
            }

            else
            {
                txtAnoTeste.Text = "";
                txtAnoTeste.Enabled = false;
                cboMarca.Focus();
                lblNivelManut.Text = "2";
            }
        }

        private void cboNorma_Leave(object sender, EventArgs e)
        {
            int anoFab = Convert.ToInt32(txtAnoFab.Text);
            if (anoFab >= 2004)
            {
               codNorma = Convert.ToInt32( cboNorma.SelectedValue);
                codCarga = Convert.ToInt32(cboCargaNominal.SelectedValue);
               codTipo = Convert.ToInt32( cboTipo.SelectedValue);
               codMarca = Convert.ToInt32( cboMarca.SelectedValue);
              
                OracleDataReader drProjeto;
               drProjeto = projeto.ListarProjeto(codNorma, codMarca, codTipo, codCarga);
               if (drProjeto.Read())
               {
                   cboProjeto.Text = drProjeto["descricao"].ToString();
               }




            }
        }

        private void txtNumExt_Leave(object sender, EventArgs e)
        {
            clnExtintor extintor = new clnExtintor();
           OracleDataReader drExtintor =  extintor.ListarExtintor(txtNumExt.Text);
           if (drExtintor.Read())
           {
               string strCargaNominal = drExtintor["codcargaNominal"].ToString();//pegar o cod para
               //pesquisar a descricao da carga
               string strMarca = drExtintor ["codMarca"].ToString();// pegar o cod para pesquisar
               //a descrição da marca

               txtAnoFab.Text = drExtintor["anoFab"].ToString();
               txtAnoTeste.Text = drExtintor["anoteste"].ToString();
               txtNumSelo.Text = drExtintor["numselo"].ToString();
              // txtNumCliente.Text = drExtintor["numCliente"].ToString();
               OracleDataReader drCarga =  carga.ListarCargaNominal(strCargaNominal);
               if (drCarga.Read())
               {
               cboCargaNominal.Text = drCarga["descricao"].ToString();
               }
               OracleDataReader drMarca = marca.ListarMarca(strMarca);
               if(drMarca.Read())
               {
               cboMarca.Text = drMarca["descricao"].ToString();
               }

               //até aqui funcionou!!!
               
               
               MessageBox.Show("Extintor já Cadastrado!!!");
           }
        }

    }
}
