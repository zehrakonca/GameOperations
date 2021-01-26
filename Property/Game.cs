using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Property
{
    class Game : IGame
    {
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Publisher
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public double Price
        {
            get; set;
        }
        public double PriceAfter
        {
            get;set;
        }
    }
}
