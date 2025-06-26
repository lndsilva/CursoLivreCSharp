using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        //Instanciar a classe Conta global
        Conta conta = new Conta();

        private void btnConta_Click(object sender, EventArgs e)
        {


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            conta.Valor = Convert.ToDouble(txtValor.Text);

            double[] saldo = new double[10];

            for (int i = 0; i < saldo.Length; i++)
            {
                saldo[i] = conta.depositar(conta.Valor);

            }

            for (int i = 0; i < saldo.Length; i++)
            {
                ltbExtrato.Items.Add("R$ " + saldo[i]);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Poupanca poupanca = new Poupanca();
            
        }
    }
}
