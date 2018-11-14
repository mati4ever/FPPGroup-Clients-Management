using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
    public interface IDataConnector
    {
        PersonModel CreatePerson(PersonModel person);
        List<PersonModel> GetPerson_All();
        List<ConnectionsModel> GetConnctionsByPerson(PersonModel person);
        ConnectionsModel CreateConnection(ConnectionsModel connection);
        int GetNewCustommerId();
        List<string> GetTaskCategory();
        TaskModel CreateTask(TaskModel task);
        List<TaskModel> GetAllTasks();
        void TaskDelay(TaskModel task);
        

    }
}
