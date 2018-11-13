using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPG_ClassLibrary
{
    public class PersonModel
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string PersonalIdNumber { get; set; }

        public string PESEL { get; set; }


        public string Represent
        {
            get
            {
                return $@"ID -{ Id }-   { FirstName } { LastName }   Tel.    { PhoneNumber }    E-Mail    { EmailAddress } ";
            }
        }

        public string RepresentConnection
        {
            get
            {
                return $@"{ Id }   { FirstName } { LastName }";
            }
        }


        //public List<PersonModel> Connections { get; set; } = new List<PersonModel>();


    }
}
