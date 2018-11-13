using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
    public class ConnectionsModel
    {
        public int Id { get; set; }

        public PersonModel FirstConnectedPerson { get; set; }

        public PersonModel SecondPersonModel { get; set; }

        public string Representation
        {
            get
            {
                return $@"{FirstConnectedPerson.RepresentConnection} - { SecondPersonModel.RepresentConnection }";
            }
        }
    }
}
