using FPPG_ClassLibrary.TextConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
   public  class TextConnector : IDataConnector
    {
        private const string PeopleFile = "CustomersFile.csv";
        private const string ConnectionsFile = "Connections.csv";
        private const string TaskCategoryFile = "TaskCategory.csv";
        private const string TaskListFile = "TaskList.csv";


        public PersonModel CreatePerson(PersonModel person)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            
            people.Add(person);

            people.SaveToPersonFile(PeopleFile);

            return person;

        }


        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            return people;
        }

        public List<ConnectionsModel> GetConnctionsByPerson( PersonModel person)
        {
            List<PersonModel> models = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            List<ConnectionsModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnections(models);
            List<ConnectionsModel> connectionByPerson = new List<ConnectionsModel>();
            int personId = person.Id;

            foreach (ConnectionsModel conect in connections)
            {
                if (conect.FirstConnectedPerson.Id == personId || conect.SecondPersonModel.Id == personId)
                {
                    connectionByPerson.Add(conect);
                }
            }

            return connectionByPerson;

        }

        public ConnectionsModel CreateConnection(ConnectionsModel connection)
        {
            List<PersonModel> models = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            List<ConnectionsModel> connections = ConnectionsFile.FullFilePath().LoadFile().ConvertToConnections(models);

            int currentId = 1;
            if (connections.Count >0)
            {
                currentId = connections.OrderByDescending(x => x.Id).First().Id + 1;
            }

            connection.Id = currentId;
            connections.Add(connection);

            connections.SaveConnection(ConnectionsFile);

            return connection;
        }

        public int GetNewCustommerId()
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            return currentId;
        }

        public List<string> GetTaskCategory()
        {
            List<string> category = TaskCategoryFile.FullFilePath().LoadFile();
            return category;
        }

        public TaskModel CreateTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            int currentId = 1;

            if (tasks.Count > 0)
            {
                currentId = tasks.OrderByDescending(x => x.Id).First().Id + 1;
            }

            task.Id = currentId;

            tasks.Add(task);

            tasks.SaveToTaskFile(TaskListFile);

            return task;


        }

        public List<TaskModel> GetAllTasks()
        {
            return TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);
        }

        public void TaskDelay(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            foreach (TaskModel t in tasks)
            {
                if (t.Id == task.Id)
                {
                    t.TaskDate = t.TaskDate.AddDays(1);
                }
            }

            tasks.SaveToTaskFile(TaskListFile);

        }

        public void TaskDone(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            foreach (TaskModel t in tasks)
            {
                if(t.Id == task.Id)
                {
                    t.Status = true;
                }

                tasks.SaveToTaskFile(TaskListFile);

            }
        }

        public List<TaskModel> GetActiveTasks()
        {

            return TaskListFile.FullFilePath().LoadFile().GetActiveTasks(PeopleFile);
        }

        public TaskModel RemoveTask(TaskModel task)
        {
            List<TaskModel> tasks = TaskListFile.FullFilePath().LoadFile().ConvertToTaskModels(PeopleFile);

            var taskToRemove = tasks.Single(x => x.Id == task.Id);
            tasks.Remove(taskToRemove);
            tasks.SaveToTaskFile(TaskListFile);
            return task;
        }
    }
}
