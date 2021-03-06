using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Client database model class.
    /// </summary>
    [Table("Client")]
    public partial class Client
    {
        /// <summary>
        /// Initializes new client instance
        /// </summary>
        public Client()
        {
            Loans = new HashSet<Loan>();
            Accounts = new HashSet<Account>();
            SavingAccounts = new HashSet<SavingAccount>();
        }

        /// <summary>
        /// Gets or sets clients id
        /// </summary>
        /// <value>
        /// Clients id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets clients first name
        /// </summary>
        /// <value>
        /// Clients first name
        /// </value>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets clients last name
        /// </summary>
        /// <value>
        /// Clients last name
        /// </value>
        public string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        /// <value>
        /// The company name
        /// </value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets clients personal identification number
        /// </summary>
        /// <value>
        /// Personal identification number
        /// </value>
        public string OIB { get; set; }
        
        /// <summary>
        /// Gets or sets clients email address
        /// </summary>
        /// <value>
        /// Clients email address
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets clients phone number
        /// </summary>
        /// <value>
        /// Clients phone number
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets clients income
        /// </summary>
        /// <value>
        /// Clients income
        /// </value>
        public double Income { get; set; }

        /// <summary>
        /// Gets or sets clients address
        /// </summary>
        /// <value>
        /// Clients address
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this client is employed
        /// </summary>
        /// <value>
        /// <c>true</c>if this client is employed, otherwise <c>false</c>
        /// </value>
        public bool IsEmployed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this client is on a fixed term contract
        /// </summary>
        /// <value>
        /// <c>true</c> if the client is on a fixed term contract, otherwise <c>false</c>
        /// </value>
        public bool IsFixedTermContract { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this client has unusual profession
        /// </summary>
        /// <value>
        /// <c>true</c> if unusual profession, otherwise <c>false</c>
        /// </value>
        public bool IsUnusualProfession { get; set; }

        /// <summary>
        /// Gets or sets clients type id
        /// </summary>
        /// <value>
        /// Client type id
        /// </value>
        public int ClientTypeId { get; set; }
        
        /// <summary>
        /// Gets or sets clients loans 
        /// </summary>
        /// <value>
        /// Clients loans collection
        /// </value>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Gets or sets clients accounts
        /// </summary>
        /// <value>
        /// Clients accounts collection
        /// </value>
        public virtual ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or sets clients saving accounts collection 
        /// </summary>
        /// <value>
        /// Clients saving accounts collection
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }

        /// <summary>
        /// Gets or sets employee's type
        /// </summary>
        /// <value>
        /// Employee's type
        /// </value>
        [ForeignKey("ClientTypeId")]
        public virtual ClientType ClientType { get; set; }
    }
}
