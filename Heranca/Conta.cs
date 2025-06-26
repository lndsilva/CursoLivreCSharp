using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Heranca
{
    public class Conta
    {
        private double saldo;
        private double valor;
        private int numeroConta;

        public double Saldo { get => saldo; set => saldo = value; }
        public double Valor { get => valor; set => valor = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }

        public double depositar(double valor)
        {
             this.saldo = this.saldo + valor;
            
            return this.saldo;
        }
        public void sacar(double valor)
        {
            this.saldo = this.saldo - valor;

        }
        public void transferir()
        {

        }
    }
}
