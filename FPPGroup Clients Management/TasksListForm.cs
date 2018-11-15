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
        List<TaskModel> taskList = GlobalConfig.Connection.GetAllTasks();
        bool active = false;

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
            taskList_listbox.DataSource = taskList;
            taskList_listbox.DisplayMember = "Represent";
            
            //TODO szerokość kolumn
        }

        private void onlyActiveTasks_button_Click(object sender, EventArgs e)
        {
            if (active)
            {
                onlyActiveTasks_button.BackColor = Color.FromArgb(31, 31, 51);
                active = false;
                taskList = GlobalConfig.Connection.GetAllTasks();
                InitializeList();

            }
            else
            {
                onlyActiveTasks_button.BackColor = Color.Green;
                active = true;
                taskList = GlobalConfig.Connection.GetActiveTasks();
                InitializeList();
            }
            
        }
    }
}
