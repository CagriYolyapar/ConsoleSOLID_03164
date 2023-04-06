using ConsoleSOLID_0.DIP.Good.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0.DIP.Good.Concretes
{
    public class GoodRestaurant
    {
        //Bu versiyonda Restaurant sınıfı alt seviye modüllerdne daha bagımsız bir hale gelecektir...Kendisine ne geliyorsa ona göre bir işlem yapacaktır...

        List<IProduct> _products;

        public GoodRestaurant(List<IProduct> products)
        {
            //Tightly Coupled(sıkı sıkıya bagımlı olan) bir yapıyı burada loosely coupled (gevsek bir şekilde baglı olan) yapıya cevirmek icin kullandıgımız yöntem constructor based injection'dir...Constructor Based Injection'in (yani Constructor'a bir parametre verip alınan argümanı icerideki bir field'a aktarma durummu) bu sekilde kullanılarak bir bagımsızlık yaratmasına da Dependency Injection tasarım paterni denir...Biz bu patern sayesinde Dependency Inversion prensibine sadık kalırız...
            _products = products;
        }

        public string GenerateInstructions()
        {
            string instructions = null;
            foreach (IProduct item in _products)
            {
                instructions += $"{item.GetCookingInstructions()}\n";

            }
            return instructions;
        }

    }
}




/*
 
 public class CategoryController : Controller
{


     MyContext _db;

    public CategoryController()

  {
    
    _db = db;
  }
 

      public ActionResult ListCategories()
    {

          return View();

    }



}
 
 
 
 
 
 
 
 
 
 
 
 
 */