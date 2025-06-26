using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public class Operacoes
    {
        //método construtor da classe
        public Operacoes()
        {

        }
        public double somaValor(double v1, double v2)
        {         
            return (v1 + v2);
        }
        public double subtraiValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicaValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double divideValor(double v1, double v2)
        {
            return (v1 / v2);
        }
    }
}
