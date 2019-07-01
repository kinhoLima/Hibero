using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace HiberoExtintores
{
    class clnExtintor
    {
        private int _cod;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private int _numExt;

        public int NumExt
        {
            get { return _numExt; }
            set { _numExt = value; }
        }
       
        private int _anoFab;

        public int AnoFab
        {
            get { return _anoFab; }
            set { _anoFab = value; }
        }

        private int _anoTeste;

        public int AnoTeste
        {
            get { return _anoTeste; }
            set { _anoTeste = value; }
        }

        private int _codMarca;

        public int CodMarca
        {
            get { return _codMarca; }
            set { _codMarca = value; }
        }

        private int _codNorma;

        public int CodNorma
        {
            get { return _codNorma; }
            set { _codNorma = value; }
        }

        private int _codProjeto;

        public int CodProjeto
        {
            get { return _codProjeto; }
            set { _codProjeto = value; }
        }

        private int _nivel;

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        private int _pintura;

        public int Pintura
        {
            get { return _pintura; }
            set { _pintura = value; }
        }

        private int _codTipo;

        public int CodTipo
        {
            get { return _codTipo; }
            set { _codTipo = value; }
        }

        private int _codCargaNominal;

        public int CodCargaNominal
        {
            get { return _codCargaNominal; }
            set { _codCargaNominal = value; }
        }

        private int _numSelo;

        public int NumSelo
        {
            get { return _numSelo; }
            set { _numSelo = value; }
        }

        public OracleDataReader ListarExtintor(string numExtintor)
        {
            string strQuery;
            strQuery = "Select * From Extintor where numExt='" + numExtintor + "' ";
            cldBancoDeDados objBancoDados = new cldBancoDeDados();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public void SalvarExtintor()
        {

            string strQuery;
            strQuery = ("INSERT INTO Extintor");
            strQuery += (" Values ");
            strQuery += ("(");

            strQuery += ("seqExtintor.nextval ");
            strQuery += (",'" + _numExt + "'");
            strQuery += (",'" + _anoFab + "'");
            strQuery += (",'" + _anoTeste + "'");
            strQuery += (",'" + _codMarca + "'");
            strQuery += (",'" + _codNorma + "'");
            strQuery += (",'" + _codProjeto + "'");
            strQuery += (",'" + _nivel + "'");
            strQuery += (",'" + _pintura + "'");
            strQuery += (",'" + _codTipo + "'");
            strQuery += (",'" + _codCargaNominal + "'");
            strQuery += (",'" + _numSelo + "'");
           
            strQuery += (")");

            

            cldBancoDeDados objcldBancoDados = new cldBancoDeDados();
            objcldBancoDados.ExecutaScalar(strQuery);
            
          //  objcldBancoDados.ExecutaComando(strQuery);
        }
    }
}
