using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuSistema
{
    public partial class FrmMeuSistema : Form
    {
        // Conversão e operadores aritimeticos
        int valor1;
        int valor2;
        int res;


        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtPac1.Text);
            valor2 = int.Parse(txtPac2.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
