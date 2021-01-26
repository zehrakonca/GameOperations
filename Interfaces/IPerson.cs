using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Property
{
    interface IPerson
    {
        int ID
        {
            get; set;
        }
        string IdentityNumber
        {
            get; set;
        }

        string Name
        {
            get; set;
        }

        string Surname
        {
            get; set;
        }

        string BirthDay
        {
            get; set;
        }

        string Username
        {
            get; set;
        }

        string MailAddres
        {
            get; set;
        }

        string Telephone
        {
            get; set;
        }
        string Role
        {
            get;set;
        }
        string Password
        {
            get;set;
        }
    }
}
