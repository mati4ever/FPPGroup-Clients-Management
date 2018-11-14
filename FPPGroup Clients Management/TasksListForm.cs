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
    public partial class TasksListForm : Form
    {
        private ICaller callingForm;
        

        public TasksListForm(ICaller caller)
        {
            callingForm = caller;
            InitializeComponent();
            InitializeList();
        }

        private void addTask_button_Click(object sender, EventArgs e)
        {
            callingForm.AddTask();
        }

       private void  InitializeList()
       {

            taskList_listbox.DataSource = null;
            taskList_listbox.DataSource = GlobalConfig.Connection.GetAllTasks();
            taskList_listbox.DisplayMember = "Represent";
            
            //TODO szerokość kolumn
        }
    }
}
