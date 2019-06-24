using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HiberoExtintores
{
    class clnTipo
    {

        private int _codTipo;

        public int CodTipo
        {
            get { return _codTipo; }
            set { _codTipo = value; }
        }

        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DataSet PreencherTipo()
        {
            string strQuery;
            strQuery = "Select * From Tipo";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataSet(strQuery);

        }
    }
}
