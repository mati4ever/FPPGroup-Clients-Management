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
    public partial class CustomerProfileForm : Form
    {
        PersonModel Customer = new PersonModel();

        public CustomerProfileForm(PersonModel person)
        {
            Customer = person;
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            firstName_textbox.Text = Customer.FirstName;
            lastName_textbox.Text = Customer.LastName;
            address_textbox.Text = Customer.Address;
            phoneNumbet_textbox.Text = Customer.PhoneNumber;
            email_textbox.Text = Customer.EmailAddress;
            personalIdNumber_textbox.Text = Customer.PersonalIdNumber;
            pesel_textbox.Text = Customer.PESEL;
            additionalInfo_textbox.Text = Customer.Note;


        }


    }
}
