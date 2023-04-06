using ConsoleSOLID_0.DIP.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.Good.Concretes
{
    public class GoodMeat : IProduct
    {
        public string GetCookingInstructions()
        {
            return "Cook well";
        }
    }
}
