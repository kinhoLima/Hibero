using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class clnConta
    {

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private double _deposito;

        public double Deposito
        {
            get { return _deposito; }
            set { _deposito = value; }
        }

        private double _saque;

        public double Saque
        {
            get { return _saque; }
            set { _saque = value; }
        }
        
    }
}
