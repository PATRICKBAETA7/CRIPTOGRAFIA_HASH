﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ContaLogado : Form
    {
        public ContaLogado()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroeLogin FormCadastroeLogin = new CadastroeLogin();
            FormCadastroeLogin.Show();
            this.Close();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMenuPrincipal_Click(object sender, EventArgs e)
        {
            Principal FormPrincipal = new Principal();
            FormPrincipal.Show();
            this.Hide();
        }
    }
}
