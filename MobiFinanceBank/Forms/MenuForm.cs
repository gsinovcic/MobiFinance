﻿using System;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Menu form
    /// </summary>
    /// <seealso cref="TemplateForm"/>
    /// <seealso cref="IMenuForm"/>
    public partial class MenuForm : TemplateForm, IMenuForm
    {
        private Employee employee;
        private readonly IExchangeForm exchangeForm;
        private readonly ICreateClientForm _createClientForm;
        private readonly IClientOverviewForm _clientOverviewForm;
        private readonly IBankServicesOverviewForm _bankServicesOverviewForm;
        private readonly IAdminPanel _adminPanel;
        private readonly ILoanRequestsForm loanRequestsForm;

        /// <summary>
        /// Initializes new instance of menu form
        /// </summary>
        /// <param name="_exchangeForm">Exchange form</param>
        /// <param name="createClientForm">Create client form</param>
        /// <param name="clientOverviewForm">Client overview form</param>
        /// <param name="bankServicesOverviewForm">Bank services overview form</param>
        public MenuForm
            (IExchangeForm _exchangeForm, 
            ICreateClientForm createClientForm, 
            IClientOverviewForm clientOverviewForm,
            IBankServicesOverviewForm bankServicesOverviewForm,
            IAdminPanel adminPanel,
            ILoanRequestsForm _loanRequestsForm,
            Employee _employee)
        {
            InitializeComponent();

            this.exchangeForm = _exchangeForm;
            this._createClientForm = createClientForm;
            this._clientOverviewForm = clientOverviewForm;
            this._bankServicesOverviewForm = bankServicesOverviewForm;
            this._adminPanel = adminPanel;
            this.btnAdminPanel.Visible = false;
     


        }
        public void GetEmployee(Employee _employee)
        {
            
            this.employee = _employee;
            lblImePrezime.Text = employee.FirstName + " " + employee.LastName;
            lblPrava.Text = employee.EmployeeType.Name;
            if (employee.EmployeeTypeId == 2)
            {
                btnAdminPanel.Visible = true;
                btnAdminPanel.Enabled = true;
            }
        }
        
        private void btnMjenjacnica_Click(object sender, EventArgs e)
        {
            exchangeForm.Show();
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            this._createClientForm.Show(null);
        }

        private void btnPregledKlijenata_Click(object sender, EventArgs e)
        {
            this._clientOverviewForm.Show();
        }

        private void btnOtvaranjeUsluga_Click(object sender, EventArgs e)
        {
            
            this._bankServicesOverviewForm.Show(null);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this._adminPanel.Show();
        }

        private void loanRequestsBtn_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r18061/wiki/Korisni%C4%8Dka-dokumentacija#13-po%C4%8Detni-prikaz");
            }
        }
    }
}
