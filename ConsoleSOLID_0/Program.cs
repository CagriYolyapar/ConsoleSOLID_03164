using ConsoleSOLID_0.DIP.Good.Concretes;
using ConsoleSOLID_0.DIP.Good.Interfaces;
using ConsoleSOLID_0.LSP.BAD;
using ConsoleSOLID_0.LSP.BAD.IkinciOrnek;
using ConsoleSOLID_0.LSP.GOOD.Abstracts;
using ConsoleSOLID_0.LSP.GOOD.Concretes;
using ConsoleSOLID_0.LSP.GOOD.Interfaces;
using ConsoleSOLID_0.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_0
{
    internal class Program
    {
        /*
         
         S => Single Responsibility => Bir yapının tekil bir sorumluluga sahip olmasıdır(DantexCrypt,MailService,ImageUloader class'larınızın hepsinin görevi tektir...Baska bir sorumluluk almamıslardır...N-Tier paterninin katmanları buna cok güzel bir örnektir...Kullanılan metotlar hep tekil sorumluluklardır...

         O => Open Closed => Bir projenin gelişmeye acık degişime kapalı olmasıdır...Degişim kastımız projenin normalde hicbir hata cıkarmayan ve güzel bir şekilde calısan kaynak kodlarının kökten modifiye edilmesidir..Bu sekilde proje degişiyorsa proje Open Closed prensibine aykırıdır...Proje eger gercekten gelişecek ise güzel bir şekilde calısan kodlar bozulmadan üzerine zarif eklemeler yapılarak geliştirilmesi gerekir...


         L=> Liskov's Substitution =>  Bir yapılar kümesinin tek bir catı altında toplanması halinde bu catı icerisinde bulunan her nesnenin Base'teki tipinden kullanıldıgı zaman Base'deki her türlü davranısa sadık kalabilmesidir... Yani BaseClass tipimizde bir koleksiyon yaratıyorsak ve  bu koleksiyon icerisine farklı nesneler alıyorsak BaseClass tipinin her davranısı bu nesnelerin herbiri icin anlamlı eylemler olmak zorundadır...


        I => Interface Segregation => Yarattıgımız Interface'ler icerisinde implement edilmeyecek veya kullanılmayacak metotların yazılmaması gerektigini savunan bir prensiptir...Cünkü böyle yapmak Interface'in gereksiz kodlara bogulmasına neden olacaktır...
         
        D => 
         
         
         
         
         
         
         
         
         
         */





        static void Main(string[] args)
        {
            //  List<Egitmen> egitmenler = new List<Egitmen>
            //{
            //    new SozlesmeliEgitmen(),
            //    new KadroluEgitmen(),
            //    new SirketEgitmeni(),
            //    new KadroluEgitmen()
            //};


            //List<GoodAraba> arabalar = new List<GoodAraba>
            //{
            //    new GoodMercedes(),
            //    new GoodTofas(),
            //    new GoodFerrari()

            //};


            //List<ICLeaner> klimaliArabalar = new List<ICLeaner>
            //{
            //    new GoodMercedes(),
            //    new GoodFerrari()
            //};



            //List<ITusluSpec> tusluEnstrumanlar = new List<ITusluSpec>
            //{
            //    new Piyano(),
            //    new Klavsen()
            //};


            List<IProduct> urunler = new List<IProduct>
            {
                new GoodMeat(),
                new GoodChicken()
            };

            Console.WriteLine(new GoodRestaurant(urunler).GenerateInstructions());
            Console.ReadLine();

        }
    }
}
