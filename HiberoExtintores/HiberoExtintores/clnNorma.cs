using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    class clnNorma
    {

        private int _codNorma;

        public int CodNorma
        {
            get { return _codNorma; }
            set { _codNorma = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DataSet PreencherNorma()
        {
            string strQuery;
            strQuery = "Select * From Norma";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarNorma(int cod)
        {
            string strQuery;
            strQuery = "Select * From Norma where codnorma='"+cod+"'";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);
        }


    }
}
