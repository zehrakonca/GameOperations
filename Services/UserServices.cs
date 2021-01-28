using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Services
{
    class UserServices : IUserServices
    {
        IUserValidationService _userValidationService;
        public UserServices(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(User user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
