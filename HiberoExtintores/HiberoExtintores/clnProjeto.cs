using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    class clnProjeto
    {
        private int _codProjeto;

        public int CodProjeto
        {
            get { return _codProjeto; }
            set { _codProjeto = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DataSet PreencherProjeto()
        {
            string strQuery;
            strQuery = "Select * From Projeto";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataSet(strQuery);

        }

        public OracleDataReader ListarProjeto(int norma, int marca, int tipo, int carga)
        {
            string strQuery;
            strQuery = "Select * From Projeto where codnorma='" + norma + "' and ";
           strQuery += " codmarca ='" + marca + "' and";
          strQuery +="  codtipo ='" + tipo + "' and";
            strQuery += "  codcarganominal ='" + carga + "' ";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);

        }
        
    }
}
