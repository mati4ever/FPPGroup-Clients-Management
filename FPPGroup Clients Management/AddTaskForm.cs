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
    public partial class AddTaskForm : Form
    {
        List<PersonModel> customers = GlobalConfig.Connection.GetPerson_All();
        List<string> taskCategory = GlobalConfig.Connection.GetTaskCategory();

        private ICaller callingForm;

        public AddTaskForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            customer_combobox.DataSource = null;
            customer_combobox.DataSource = customers;
            customer_combobox.DisplayMember = "RepresentConnection";

            taskCategory_combobox.DataSource = null;
            taskCategory_combobox.DataSource = taskCategory;

            createTaskDate_textbox.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            callingForm.LoadTasksLiastForm();
        }

        private void addCustomer_button_Click(object sender, EventArgs e)
        {
            TaskModel task = new TaskModel();
            DateTime date1;
            DateTime date2;

            if (DateTime.TryParseExact(createTaskDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date1) &&
                 DateTime.TryParseExact(taskDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date2))
            {
                if (ValidateForm())
                {
                    
                    task.CreationDate = date1;
                    task.TaskDate = date2;
                    task.Person = (PersonModel)customer_combobox.SelectedItem;
                    task.TaskCategory = (string)taskCategory_combobox.SelectedItem;
                    task.TaskNote = taskNote_textbox.Text;

                    GlobalConfig.Connection.CreateTask(task);
                    callingForm.LoadTasksLiastForm();
                }
                else
                {
                    MessageBox.Show("Wybierz klienta i kategorię zadania");
                }                   
                              
            }
            else
            {
                MessageBox.Show("Błędny format daty. Poprawny format: DD-MM-RRRR");
            }

        }

        private bool ValidateForm()
        {
            if (customer_combobox.SelectedItem == null || taskCategory_combobox.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        private bool ValidateDate()
        {
            DateTime date;

            if (DateTime.TryParseExact(createTaskDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date) ||
                DateTime.TryParseExact(taskDate_textbox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
            {
                return true;
            }
            return false;
        }
    }
}
