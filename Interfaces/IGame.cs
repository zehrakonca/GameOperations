using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Interfaces
{
    interface IGame
    {
        int ID
        {
            get; set;
        }
        string Name
        {
            get; set;
        }
        string Publisher
        {
            get; set;
        }
        string Type
        {
            get; set;
        }
        double Price
        {
            get; set;
        }
        double PriceAfter
        {
            get; set;
        }
    }
}
