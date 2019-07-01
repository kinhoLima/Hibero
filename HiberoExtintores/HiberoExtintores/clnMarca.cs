using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    class clnMarca
    {
        private int _codMarca;

        public int CodMarca
        {
            get { return _codMarca; }
            set { _codMarca = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DataSet PreencherMarca()
        {
            string strQuery;
            strQuery = "Select * From Marca";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataSet(strQuery);

        }

        public OracleDataReader ListarMarcaPorAno(string marca, string ano)
        {
            string strQuery;
            strQuery = "Select * From Marca where descricao ='" + marca + "' and anoinicio <= '" + ano + "' and anofim >= '" + ano + "' ";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);

        }

        public OracleDataReader ListarMarca(string cod)
        {
            string strQuery;
            strQuery = "Select descricao From Marca where codmarca ='" + cod + "'" ;
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);

        }
    }
}
