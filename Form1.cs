﻿using System;
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
        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "Teste de button";
            this.txtFrase.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "";
            this.txtFrase.ForeColor = Color.White;
        }
    }
}
