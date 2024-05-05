using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "kulaklık", "yazılım", "kapı", "kemik", "bilgisayar", "köpük", "ramazan", "bayram" };
            string secilenkelime;
            int hak = 6;
            Random rnd = new Random();
            secilenkelime =kelimeler[rnd.Next(0,kelimeler.Length-1)];
            char[] yertutucu = new char[secilenkelime.Length];
            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '-';
                Console.Write('-');
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Kalan hak:{0}", hak);
                Console.WriteLine("Bir harf giriniz");
                char harf =Convert.ToChar(Console.ReadLine());
                bool a = false;
                int kalankelime = 0;
                for (int i = 0; i < secilenkelime.Length; i++)
                {


                    if (secilenkelime[i] == harf)
                    {
                        yertutucu[i] = harf;
                        a = true;
                    }
                    else if (yertutucu[i] == '-')
                    {
                        kalankelime++;

                    }
                    Console.WriteLine(yertutucu[i]);
                }
                Console.WriteLine();
                if (kalankelime == 0)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                if (a == false)
                {
                    hak--;
                }
                  if (hak == 0)
                {
                    Console.WriteLine("Kaybettiniz");
                    break;
                }
                Console.WriteLine();


            }

            Console.WriteLine("Seçtiğin Kelime:{0}", secilenkelime);
            Console.ReadLine();


        }
    }
}
