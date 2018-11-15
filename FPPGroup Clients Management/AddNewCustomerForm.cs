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
    public partial class AddNewCustomerForm : Form
    {
        private ICaller callingForm;
     
                
        public AddNewCustomerForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
          
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            callingForm.LoadCustomersListForm();
        }

        private bool ValidateForm()
        {
            if (firstName_textbox.Text.Length == 0 || lastName_textbox.Text.Length == 0)
            {

                return false;
            }
            return true;
        }
            
        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                PersonModel model = new PersonModel();

                model.Id = GlobalConfig.Connection.GetNewCustommerId();

                model.FirstName = firstName_textbox.Text;
                model.LastName = lastName_textbox.Text;
                model.Address = address_textbox.Text;
                model.PhoneNumber = phoneNumbet_textbox.Text;
                model.EmailAddress = email_textbox.Text;
                model.PersonalIdNumber = personalIdNumber_textbox.Text;
                model.PESEL = pesel_textbox.Text;
                model.Note = additionalInfo_textbox.Text;


                GlobalConfig.Connection.CreatePerson(model);

                callingForm.LoadCustomersListForm();

            }
            else
            {
                MessageBox.Show("Wymagane jest Imię i Nazwisko klienta.");
            }


        }
    }
}   



        