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
        }

        private void addTask_button_Click(object sender, EventArgs e)
        {
            callingForm.AddTask();
        }
    }
}
