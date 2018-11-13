using FPPG_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPPGroup_Clients_Management
{
    public partial class CustomersListForm : Form
    {

        List<PersonModel> customersList = GlobalConfig.Connection.GetPerson_All();

        private ICaller calligForm;

                
        public CustomersListForm(ICaller caller)
        {
            calligForm = caller;
            InitializeComponent();
            InitializeList();
        }

        public void InitializeList()
        {
            customersList_listbox.DataSource = null;
            customersList_listbox.DataSource = customersList;
            customersList_listbox.DisplayMember = "Represent";

        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            calligForm.AddCustomer();

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            //this.Close();

        }
    }
}
