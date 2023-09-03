using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Papagan p = new Papagan();
            p.tur = "Papagan";
            p.hiz = 50;
            p.isim = "Sultan";
            p.renk = "Sari-Kirmizi";
            //p.ses = "Cik";
            p.agirlik = 1650;
            p.SesCikar();

            Console.WriteLine("Tur : " + p.tur);
            Console.WriteLine("Isim : " + p.isim);
            Console.WriteLine("Hiz :" + p.hiz);
            Console.WriteLine("Agirlik : " + p.agirlik);
            Console.WriteLine("Renk : " + p.renk);
            //Console.WriteLine("Ses : " + p.ses);
            Console.WriteLine("Ses : " + p.SesCikar());
            Console.WriteLine();
            Console.WriteLine();

            Karga k = new Karga();
            k.agirlik = 1350;
            k.hiz = 80;
            k.isim = "Alacakarga";
            k.renk = "Siyah";
            k.tur = "Karga";
            k.SesCikar();

            Console.WriteLine("Agirlik : " + k.agirlik);
            Console.WriteLine("Hiz : " + k.hiz);
            Console.WriteLine("Isim : " + k.isim);
            Console.WriteLine("Renk : " + k.renk);
            Console.WriteLine("Tur : " + k.tur);
            Console.WriteLine("Ses : " + k.SesCikar());


            Console.Read();
        }
    }
}
