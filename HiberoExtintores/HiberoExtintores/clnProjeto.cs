using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
    }
}
