using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
    public class TaskModel
    {

        public int Id { get; set; }

        public PersonModel Person  { get; set; }

        public DateTime TaskDate { get; set; }

        public DateTime CreationDate { get; set; }

        public string TaskCategory { get; set; }

        public string TaskNote { get; set; }

        public bool Status { get; set; } = false;


    }
}
