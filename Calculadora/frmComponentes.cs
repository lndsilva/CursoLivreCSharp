using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //executar a classe/objeto Tampa
            Tampa tp = new Tampa();
            tp.tampar();
        

        }

       

       
    }
}
