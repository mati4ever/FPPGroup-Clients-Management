using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace FPPG_ClassLibrary.TextConverter
{
    public static class TextProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName } ";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();

            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Address = cols[3];
                p.PhoneNumber = cols[4];
                p.EmailAddress = cols[5];
                p.PersonalIdNumber = cols[6];
                p.PESEL = cols[7];
                p.Note = cols[8];

                output.Add(p);

            }

            return output;

        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.Id }#{ p.FirstName }#{ p.LastName }#{ p.Address }#{ p.PhoneNumber}#{ p.EmailAddress }#{ p.PersonalIdNumber }#{ p.PESEL }#{ p.Note }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<ConnectionsModel> ConvertToConnections(this List<string> lines, List<PersonModel> people)
        {
            List<ConnectionsModel> output = new List<ConnectionsModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split('#');

                ConnectionsModel c = new ConnectionsModel();
                PersonModel p = new PersonModel();


                c.Id = int.Parse(cols[0]);
                int firstId = int.Parse(cols[1]);
                int secondId = int.Parse(cols[2]);


                foreach (PersonModel person in people)
                {
                    if (person.Id == firstId )
                    {
                        c.FirstConnectedPerson = person;

                    }
                    if (person.Id == secondId)
                    {
                        c.SecondPersonModel = person;
                    }

                }

                output.Add(c);

            }

            return output;
            



        }

        public static void SaveConnection(this List<ConnectionsModel> connections,  string fileName)
        {
            List<string> lines = new List<string>();
            foreach (ConnectionsModel connect in connections)
            {
                lines.Add($"{ connect.Id }#{ connect.FirstConnectedPerson.Id }#{ connect.SecondPersonModel.Id }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TaskModel> ConvertToTaskModels(this List<string> lines, string peopleFileName)
        {
            List<TaskModel> output = new List<TaskModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');
                TaskModel t = new TaskModel();

                t.Id = int.Parse(cols[0]);
                t.TaskCategory = cols[1];
                t.CreationDate = DateTime.Parse(cols[2]);
                t.TaskDate = DateTime.Parse(cols[3]);
                t.TaskNote = cols[4];
                t.Status = bool.Parse(cols[5]);

                int personId = int.Parse(cols[6]);

                foreach (PersonModel p in people)
                {
                    if (p.Id == personId)
                    {
                        t.Person = p;
                    }
                }

                output.Add(t);

            }
            return output;

        }

        public static void SaveToTaskFile(this List<TaskModel> tasks, string fileName)
        {

            List<string> lines = new List<string>();

            foreach (TaskModel t in tasks)
            {
                lines.Add($"{ t.Id }#{ t.TaskCategory }#{ t.CreationDate }#{ t.TaskDate }#{ t.TaskNote }#{ t.Status }#{ t.Person.Id }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TaskModel> GetActiveTasks(this List<string> lines, string peopleFileName)
        {
            List<TaskModel> output = new List<TaskModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split('#');
                TaskModel t = new TaskModel();

                t.Id = int.Parse(cols[0]);
                t.TaskCategory = cols[1];
                t.CreationDate = DateTime.Parse(cols[2]);
                t.TaskDate = DateTime.Parse(cols[3]);
                t.TaskNote = cols[4];
                t.Status = bool.Parse(cols[5]);

                int personId = int.Parse(cols[6]);

                foreach (PersonModel p in people)
                {
                    if (p.Id == personId)
                    {
                        t.Person = p;
                    }
                }

                if (!t.Status)
                {
                    output.Add(t);
                }


            }
            return output;

        }

    }
}
