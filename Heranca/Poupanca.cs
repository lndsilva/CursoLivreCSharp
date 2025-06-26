using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Poupanca : Conta
    {
        private int numeroContaPoupanca;
        private double valorRendimento;
        private double porc;

        public int NumeroContaPoupanca { get => numeroContaPoupanca; set => numeroContaPoupanca = value; }
        public double ValorRendimento { get => valorRendimento; set => valorRendimento = value; }

        public double calculoRendimento(double porc,double valor)
        {
            this.valorRendimento = valor  + (valor * porc / 100);
                
            return this.valorRendimento;
        }
    }
}
