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
    public partial class MainPanel : Form, ICaller
    {
        public void AddCustomer()
        {
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
            changingPanel.Controls.Clear();
            AddTaskForm addTask = new AddTaskForm(this);
            addTask.TopLevel = false;
            changingPanel.Controls.Add(addTask);
            addTask.Show();
        }

      
    }
}
