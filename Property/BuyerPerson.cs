using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Property
{
    class BuyerPerson : ILoggerService
    {
        public int BuyID
        {
            get; set;
        }
        public string UserID
        {
            get;set;
        }
        public int gameID
        {
            get; set;
        }
        public string Campaign
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }
    }
}
