﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService;
using MobiFinanceBank.VmService.Interfaces;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Client overview form
    /// </summary>
    public partial class ClientOverview : TemplateForm, IClientOverview
    {
        private readonly IClientTypeRepository clientTypeRepository;
        private readonly IClientOverviewVmService clientOverviewVmService;

        /// <summary>
        /// Initializes new instance of client overview form
        /// </summary>
        /// <param name="_clientTypeRepository">The client type repository</param>
        /// <param name="_clientOverviewVmService">The client overview view model service</param>
        public ClientOverview(IClientTypeRepository _clientTypeRepository, IClientOverviewVmService _clientOverviewVmService)
        {
            InitializeComponent();
            this.clientTypeRepository = _clientTypeRepository;
            this.clientOverviewVmService = _clientOverviewVmService;
        }

        /// <summary>
        /// On client overview load
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void ClientOverview_Load(object sender, EventArgs e)
        {
            // Sets value, display members and data source
            clientTypeCb.ValueMember = "Id";
            clientTypeCb.DisplayMember = "Name";
            clientTypeCb.DataSource = new BindingSource(this.clientTypeRepository.GetAll(), null);
        }

        /// <summary>
        /// On client type combobox index change
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void clientTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parses client type combobox selected item into client type enum
            var clientType = (ClientType)clientTypeCb.SelectedItem;
            Model.Enums.ClientType.TryParse(clientType.Name, true, out Model.Enums.ClientType selectedClientType);

            // Client overview filter
            var filter = new ClientOverviewFilter()
            {
                ClientType = selectedClientType
            };

            // Sets client overview data grid view data source
            clientOverviewDgv.DataSource = this.clientOverviewVmService.GetClientOverview(filter);
        }
    }
}