using System;

namespace TıpDonusumlerı
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit Converyum(Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:"+ d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Özlem";
            char f = 'ö';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            Console.WriteLine("************");

            //Explicit Converyum(Bilinçli Dönüşüm)
            int x = 4;
            byte y=(byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            Console.WriteLine("************");
            // ToString Metodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            Console.WriteLine("************");


            //System.Convert

            string s1 = "10", s2 = "20";
            int sayı1, sayı2;
            int toplam;
            sayı1 = Convert.ToInt32(s1);
            sayı2 = Convert.ToInt32(s2);
            toplam = sayı1 + sayı2;
            Console.WriteLine(toplam);

            Console.WriteLine("************");

            //Parse
            ParseMethod();


        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1:"+rakam1);
            Console.WriteLine("double1:"+double1);

        }
    }
}
