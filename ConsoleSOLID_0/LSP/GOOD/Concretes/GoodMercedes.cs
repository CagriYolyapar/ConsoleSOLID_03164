using ConsoleSOLID_0.LSP.BAD;
using ConsoleSOLID_0.LSP.GOOD.Abstracts;
using ConsoleSOLID_0.LSP.GOOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.LSP.GOOD.Concretes
{
    public class GoodMercedes : GoodAraba, ICLeaner
    {
        public string KlimaCalistir()
        {
            throw new NotImplementedException();
        }
    }
}
