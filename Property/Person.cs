using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Property
{
    class Person : IPerson
    {
        public string BirthDay
        {
            get;set;
        }

        public int ID
        {
            get; set;
        }

        public string IdentityNumber
        {
            get; set;
        }

        public string MailAddres
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Role
        {
            get; set;
        }

        public string Surname
        {
            get; set;
        }

        public string Telephone
        {
            get; set;
        }

        public string Username
        {
            get; set;
        }
        public string Password
        {
            get;set;
        }
    }
}
