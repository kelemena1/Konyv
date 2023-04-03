using OsztalyTalkozasKonyv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static public List<Book> konyvtar = new List<Book>();
        static void Main(string[] args)
        {
            //Konyv osztaly
            //isbnSzám 
            //Szerző
            //mű címe
            //Kiadási éve
            //nyelv
            //enciklopedia - t | f
            //ebook - i/n

            //feladatok:
            
            int konyvekSzama = 0; ;
            bool xd = true;
            //Hány datab könyvet szeretne bevinni a felhasználó?
            while (xd)
            { 
            Console.Write("Hány könyvet szeretbél bevinni a rendszerbe?: ");
            try { 
                    konyvekSzama = int.Parse(Console.ReadLine());
                    xd = false;

                
               }
            catch (System.FormatException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("A könyvek száma csak szám lehet!");
            }
                }
            //Könyv adatainak bekérése:
            for (int i = 0; i < konyvekSzama; i++)
            {

                
            }


            Console.ReadKey();
        }
    }
}
