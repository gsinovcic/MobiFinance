﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;

namespace MobiFinanceBank.Forms
{
    public partial class Form1 : Form
    {
        private ILoginForm lf;
        public Form1(ILoginForm _lf)
        {
            InitializeComponent();
            lf = _lf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lf.Show();
        }
    }
}
