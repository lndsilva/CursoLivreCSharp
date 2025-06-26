using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Poupanca : Conta
    {
        private int numeroContaPoupanca;
        private double valorRendimento;

        public int NumeroContaPoupanca { get => numeroContaPoupanca; set => numeroContaPoupanca = value; }
        public double ValorRendimento { get => valorRendimento; set => valorRendimento = value; }

        public void calculoRendimento()
        {          

           
        }
    }
}
