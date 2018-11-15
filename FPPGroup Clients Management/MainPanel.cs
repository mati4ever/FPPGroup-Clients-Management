using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FPPG_ClassLibrary;

namespace FPPGroup_Clients_Management
{
    public partial class MainPanel : Form, ICaller
    {
        private bool disable = false;

        public void AddCustomer()
        {
            disable = true;
            ControlButtons();

            changingPanel.Controls.Clear();
            AddNewCustomerForm addcustomer = new AddNewCustomerForm(this);
            addcustomer.TopLevel = false;
            changingPanel.Controls.Add(addcustomer);
            addcustomer.Show();
    
        }

        public MainPanel()
        {
            InitializeComponent();
            todaysDate();
            LoadHomePanel();


        }

        private void klient_button_Click(object sender, EventArgs e)
        {
            LoadCustomersListForm();
        }

        public void LoadCustomersListForm()
        {
            disable = false;
            ControlButtons();

            changingPanel.Controls.Clear();

            CustomersListForm customers = new CustomersListForm(this);
            customers.TopLevel = false;
            changingPanel.Controls.Add(customers);
            customers.Show();

            movingPanel_panel.Location = new Point(269, 234);
        }

        private void tasks_button_Click(object sender, EventArgs e)
        {
            LoadTasksLiastForm();
        }

        public void LoadTasksLiastForm()
        {
            disable = false;
            ControlButtons();

            changingPanel.Controls.Clear();

            TasksListForm tasks = new TasksListForm(this);
            tasks.TopLevel = false;
            changingPanel.Controls.Add(tasks);
            tasks.Show();

            movingPanel_panel.Location = new Point(269, 339);
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            LoadHomePanel();
        }

        /// <summary>
        ///  Load Home Form to changing panel.
        /// </summary>
        private void LoadHomePanel()
        {
            disable = false;
            ControlButtons();

            changingPanel.Controls.Clear();
            HomeForm home = new HomeForm();
            home.TopLevel = false;
            changingPanel.Controls.Add(home);
            home.Show();

            movingPanel_panel.Location = new Point(269, 129);
        }

        /// <summary>
        /// display today's date.
        /// </summary>
        private void todaysDate()
        {
            date_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void AddTask()
        {
            disable = true;
            ControlButtons();

            changingPanel.Controls.Clear();
            AddTaskForm addTask = new AddTaskForm(this);
            addTask.TopLevel = false;
            changingPanel.Controls.Add(addTask);
            addTask.Show();
        }

        public void LoadEditeCustomer(PersonModel person)
        {
            disable = true;
            ControlButtons();

            changingPanel.Controls.Clear();
            CustomerProfileForm tasks = new CustomerProfileForm(person);
            tasks.TopLevel = false;
            changingPanel.Controls.Add(tasks);
            tasks.Show();
        }

        private void ControlButtons()
        {
            if (disable)
            {
                home_button.Enabled = false;
                klient_button.Enabled = false;
                tasks_button.Enabled = false;
            }
            else
            {
                home_button.Enabled = true;
                klient_button.Enabled = true;
                tasks_button.Enabled = true;
            }

        }



        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


    }
}
