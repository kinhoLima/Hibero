using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    class clnCargaNominal
    {
        private int _codCargaNominal;

        public int CodCargaNominal
        {
            get { return _codCargaNominal; }
            set { _codCargaNominal = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DataSet PreencherCargaNominal()
        {
            string strQuery;
            strQuery = "Select * From cargaNominal";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataSet(strQuery);

        }


        public OracleDataReader ListarCargaNominal(string cod)
        {
            string strQuery;
            strQuery = "Select descricao From cargaNominal where codcarganominal='" +cod+ "'";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);

        }
    }
}
