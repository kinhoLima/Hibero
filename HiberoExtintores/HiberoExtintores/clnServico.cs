using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiberoExtintores
{
    class clnServico
    {
        private int _cod;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private int _codExt;

        public int CodExt
        {
            get { return _codExt; }
            set { _codExt = value; }
        }

        private int _numSelo;

        public int NumSelo
        {
            get { return _numSelo; }
            set { _numSelo = value; }
        }

        private string _numCliente;

        public string NumCliente
        {
            get { return _numCliente; }
            set { _numCliente = value; }
        }

        private int _nivel;

        public int Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        private string _pintura;

        public string Pintura
        {
            get { return _pintura; }
            set { _pintura = value; }
        }

        private string _ensPneumIndPressao;

        public string EnsPneumIndPressao
        {
            get { return _ensPneumIndPressao; }
            set { _ensPneumIndPressao = value; }
        }

        private string _ensPneumValv;

        public string EnsPneumValv
        {
            get { return _ensPneumValv; }
            set { _ensPneumValv = value; }
        }

        private string _regulValvAlivio;

        public string RegulValvAlivio
        {
            get { return _regulValvAlivio; }
            set { _regulValvAlivio = value; }
        }

        //private int _pecas;

        //public int Pecas
        //{
        //    get { return _pecas; }
        //    set { _pecas = value; }
        //}

        private string _visualExterno;

        public string VisualExterno
        {
            get { return _visualExterno; }
            set { _visualExterno = value; }
        }

        private string _visualInterno;

        public string VisualInterno
        {
            get { return _visualInterno; }
            set { _visualInterno = value; }
        }

        private string _roscas;

        public string Roscas
        {
            get { return _roscas; }
            set { _roscas = value; }
        }
        
        private string _ensHidroValv;

        public string EnsHidroValv
        {
            get { return _ensHidroValv; }
            set { _ensHidroValv = value; }
        }

        private string _ensHidroMang;

        public string EnsHidroMang
        {
            get { return _ensHidroMang; }
            set { _ensHidroMang = value; }
        }

        private int _tara;

        public int Tara
        {
            get { return _tara; }
            set { _tara = value; }
        }

        private int _pesoVazio;

        public int PesoVazio
        {
            get { return _pesoVazio; }
            set { _pesoVazio = value; }
        }

        private int _perdaMassa;

        public int PerdaMassa
        {
            get { return _perdaMassa; }
            set { _perdaMassa = value; }
        }

        private int _pesoCheio;

        public int PesoCheio
        {
            get { return _pesoCheio; }
            set { _pesoCheio = value; }
        }

        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        private int _capacMaxCarga;

        public int CapacMaxCarga
        {
            get { return _capacMaxCarga; }
            set { _capacMaxCarga = value; }
        }

        private int _pressaoTrabalho;

        public int PressaoTrabalho
        {
            get { return _pressaoTrabalho; }
            set { _pressaoTrabalho = value; }
        }

        private int _pressaoTeste;

        public int PressaoTeste
        {
            get { return _pressaoTeste; }
            set { _pressaoTeste = value; }
        }

        private int _instantaneaET;

        public int InstantaneaET
        {
            get { return _instantaneaET; }
            set { _instantaneaET = value; }
        }

        private int _permanenteEP;

        public int PermanenteEP
        {
            get { return _permanenteEP; }
            set { _permanenteEP = value; }
        }

        private int epEt;

        public int EpEt
        {
            get { return epEt; }
            set { epEt = value; }
        }

        private string _aprovado;

        public string Aprovado
        {
            get { return _aprovado; }
            set { _aprovado = value; }
        }

        private string _condenado;

        public string Condenado
        {
            get { return _condenado; }
            set { _condenado = value; }
        }

        private string _moticoCondenacao;

        public string MotivoCondenacao
        {
            get { return _moticoCondenacao; }
            set { _moticoCondenacao = value; }
        }


        private string _inspFinal;

        public string InspFinal
        {
            get { return _inspFinal; }
            set { _inspFinal = value; }
        }



        public void AnotarExtintor()
        {

            string strQuery;
            strQuery = ("INSERT INTO Servico");
            strQuery += (" Values ");
            strQuery += ("(");

            strQuery += (" seqServico.nextval ");
            strQuery += (",'" + _codExt + "'");
            strQuery += (",'" + _numSelo + "'");
            strQuery += (",'" + _numCliente + "'");
            strQuery += (",'" + _nivel + "'");
            strQuery += (",'" + _pintura + "'");
            strQuery += (")");
            cldBancoDeDados objcldBancoDados = new cldBancoDeDados();
            objcldBancoDados.ExecutaComando(strQuery);
        }

    }
}
