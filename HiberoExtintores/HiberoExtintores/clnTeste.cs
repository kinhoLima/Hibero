using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiberoExtintores
{
    class clnTeste
    {

        private int _cod;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }


        
         public void Gravar()
        {

            string strQuery;
            strQuery = ("INSERT INTO Teste");
            strQuery += (" Values ");
            strQuery += ("(");

            strQuery += ("'" + _cod + "',");
            strQuery += ("'" + _desc + "'");
          
            strQuery += (")");



            cldBancoDeDados objcldBancoDados = new cldBancoDeDados();
            objcldBancoDados.ExecutaComando(strQuery);
        }
        }

    }

