using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
    }
}
