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
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    public partial class MenuForm : TemplateForm, IMenuForm
    {
        private readonly IExchangeForm exchangeForm;
        private readonly ICreateClient createClient;
        private readonly IClientOverview clientOverview;
        public MenuForm(IExchangeForm _exchangeForm, ICreateClient _createClient, IClientOverview _clientOverview)
        {
            InitializeComponent();
            this.exchangeForm = _exchangeForm;
            this.createClient = _createClient;
            this.clientOverview = _clientOverview;
        }

        private void btnMjenjacnica_Click(object sender, EventArgs e)
        {
            exchangeForm.Show();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            this.createClient.Show();
        }

        private void btnPregledKlijenata_Click(object sender, EventArgs e)
        {
            this.clientOverview.Show();
        }
    }
}
