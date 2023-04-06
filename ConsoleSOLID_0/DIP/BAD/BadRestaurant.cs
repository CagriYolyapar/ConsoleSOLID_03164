using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.BAD
{
    public class BadRestaurant
    {
        //Restaurant sınıfı High Level bir modüldür...Yalnız low level modüllerden olan baska sınıflara bagımlılıgı vardır...

        //Tightly Coupled (sıkı sıkıya bagımlı)
        BadFish _tuna = new BadFish();
        BadChicken _tavuk = new BadChicken();

        public string TumTarifeler()
        {
            return $"{_tuna.GetCookingInstructions()} {_tavuk.GetCookingInstructions()}";
        }


    }
}
