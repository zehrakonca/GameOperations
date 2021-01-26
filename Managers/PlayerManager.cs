using GameOperations.Interfaces;
using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOperations
{
    class PlayerManager 
    {
        List<IPerson> players = new List<IPerson>() { };
        public void Add(IPerson player, string IdentityNumber)
        {
            if (IdentityNumber == player.IdentityNumber)
            {
                players.Add(player);
                Console.WriteLine("{0} {1} adlı kullanıcının kaydı oluşturuldu.", player.Name, player.Surname);
            }
            else
            {
                Console.WriteLine("Hesap doğrulanamadı. Lütfen bilgilerinizi kontrol ediniz.");
            }

        }
        public void Update(IPerson player, int ID)
        {
            Console.WriteLine("{0} {1} adlı kullanıcının bilgileri güncellendi.", player.Name, player.Surname);
        }
        public void Delete(IPerson player,int ID)
        {
                if (player.ID == ID)
                {
                    Console.WriteLine("Kullanıcı sistemden silinmiştir.");
                }
                else
                {
                   
                }
        }
        public void ShowPlayer()
        {
            int i = 1;
            foreach (IPerson player in players)
            {
                Console.WriteLine("__________________________________");
                Console.WriteLine("{0}. Ad Soyad: {1} {2}\n"
                                 +"T.C Kimlik No : {3}\n"+
                                  "Doğum Tarihi : {4}\n"+
                                  "Kullanıcı Adı : {5}\n"+
                                  "Mail Adresi : {6}",i , player.Name,
                                   player.Surname,player.IdentityNumber,
                                   player.BirthDay,player.Surname,
                                   player.Username,player.MailAddres);
                Console.WriteLine("__________________________________");
                i += 1;
            }
        }

    }
}
