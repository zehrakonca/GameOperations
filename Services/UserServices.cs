﻿using GameOperations.Interfaces;
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
        List<User> players = new List<User>() { };
        public UserServices(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(User user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                players.Add(user);
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
        public void ShowUser()
        {
            int i = 1;
            foreach (User player in players)
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("{0}. Ad Soyad: {1} {2}\n"+
                                  "T.C Kimlik No : {3}\n" +
                                  "Doğum Tarihi : {4}",
                                   i, player.FirstName,
                                   player.LastName, player.IdentityNumber,
                                   player.BirthYear);
                Console.WriteLine("_____________________________________");
                i += 1;
            }
        }
    }
}
