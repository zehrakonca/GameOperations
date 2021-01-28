using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Services
{
    class UserValidationService : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "ZEHRA" && user.LastName =="KONCA" && user.IdentityNumber ==12345611111
                && user.BirthYear == 1996 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
