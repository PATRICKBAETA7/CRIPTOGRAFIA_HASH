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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e) {
            CadastroeLogin agendaObj = new CadastroeLogin();
            agendaObj.ShowDialog();
          
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
