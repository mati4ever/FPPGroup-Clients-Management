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
    public partial class HomeForm : Form
    {
        
        private DateTime today = DateTime.Now;


        public HomeForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {

            todayTask_listbox.DataSource = null; 
            todayTask_listbox.DataSource = TodayTasksList();
            todayTask_listbox.DisplayMember = "Represent";
           


            closeTasks_listbox.DataSource = null;
            closeTasks_listbox.DataSource = NextSevenDaysList();
            closeTasks_listbox.DisplayMember = "Represent";

            missedTask_listbox.DataSource = null;
            missedTask_listbox.DataSource = MissedTasks();
            missedTask_listbox.DisplayMember = "Represent";

        }

        private List<TaskModel> TodayTasksList()
        {
            List<TaskModel> allTasks = GlobalConfig.Connection.GetAllTasks();

            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTasks)
            {
                if (t.TaskDate.Date.CompareTo(today.Date) == 0)
                {
                    output.Add(t);
                }
            }

            return output;
        }

        private List<TaskModel> NextSevenDaysList()
        {
            List<TaskModel> allTasks = GlobalConfig.Connection.GetAllTasks();

            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTasks)
            {
                if (t.TaskDate.Date.CompareTo(today.Date) < 7 && t.TaskDate.Date.CompareTo(today.Date) > 0)
                {
                    output.Add(t);
                }
               
            }
            return output;

        }

        private List<TaskModel> MissedTasks()
        {
            List<TaskModel> allTasks = GlobalConfig.Connection.GetAllTasks();

            List<TaskModel> output = new List<TaskModel>();

            foreach (TaskModel t in allTasks)
            {
                if (t.TaskDate.Date.CompareTo(today.Date)<0 && !t.Status)
                {
                    output.Add(t);
                }
                
            }
            return output;
        }

        private void taskDelay_button_Click(object sender, EventArgs e)
        {
            TaskModel task = (TaskModel)closeTasks_listbox.SelectedItem;

            GlobalConfig.Connection.TaskDelay(task);

            InitializeLists();
            
        }
    }
}
