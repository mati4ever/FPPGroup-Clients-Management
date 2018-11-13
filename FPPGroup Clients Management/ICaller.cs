using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPPGroup_Clients_Management
{
    public interface ICaller
    {
        void AddCustomer();
        void AddTask();
        void LoadCustomersListForm();
        void LoadTasksLiastForm();


    }
}
