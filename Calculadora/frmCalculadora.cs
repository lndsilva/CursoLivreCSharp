using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        public frmCalculadora()
        {
            InitializeComponent();
        }

        //essa é uma ação do botão somar
        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declarando as variáveis da soma
            double num1, num2, resp = 0.0;

            //inicializando as variáveis
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            //Instânciando ou executando a classe Operações
            Operacoes op = new Operacoes();


            //realizando o calculo de soma
            resp = op.somaValor(num1, num2);

            lblResposta.Text = resp.ToString();
            bandeira = true;

        }
        //escopo global
        bool bandeira;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            bandeira = false;
            txtNum1.Clear();
            txtNum2.Clear();
            lblResposta.Text = "";
            txtNum1.Focus();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            try
            {
                num1 = Double.Parse(txtNum1.Text);
                num2 = Double.Parse(txtNum2.Text);

                Operacoes op = new Operacoes();


                if (rdbSoma.Checked)
                {
                    resp = op.somaValor(num1, num2);
                }
                if (rdbSubtracao.Checked)
                {
                    resp = op.subtraiValor(num1, num2);
                }
                if (rdbMultiplicacao.Checked)
                {
                    resp = op.multiplicaValor(num1, num2);
                }
                if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível divisão por zero");
                    }
                    else
                    {
                        resp = op.divideValor(num1, num2);
                    }
                }
                lblResposta.Text = resp.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos");
            }
        }
    }
}
