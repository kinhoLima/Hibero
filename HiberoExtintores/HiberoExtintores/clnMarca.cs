using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
    }
}
