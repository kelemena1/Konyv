using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv k = new Konyv();
            bool helyes = false;
            /*do
            {

                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums = "";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums += item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);*/

            KonyvesPolc konyvesPolc1 = new KonyvesPolc();
            
            try
            {
                Konyv konyv1 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2023, "Magyar", false, 'n', "12345678910");
                Konyv konyv2 = new Konyv("0306406152", "Szerző 1", "Cím 1", 2018, "Magyar", false, 'n', "10343674919");
                konyvesPolc1.konyvHozzaAdasa(konyv1);
                konyvesPolc1.konyvHozzaAdasa(konyv2);
                konyvesPolc1.konyvDictionaryHozzaadas(konyv1);
                konyvesPolc1.konyvDictionaryHozzaadas(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ISBN_NumberFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BookInventoryNumberException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BookNameLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EbookException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EnciException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (LanguageEmptyFieldException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TitleLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (WriterNameExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (YearOfPublicationException e)
            {
                Console.WriteLine(e.Message);
            }
            int db = konyvesPolc1.konyvekSzama;
            Console.WriteLine(db);
            Console.WriteLine(konyvesPolc1.konyvekSzama);
            Console.WriteLine(konyvesPolc1.konyvekSzamaFuggveny());
            Console.WriteLine(konyvesPolc1.konyvDictHossz());
            //Konyv osztályba + leltári szám pontosan 11 karakter
            //minden mezőt ellenörző adatbevitelel elkésziteni
            //Szerző minimum 6 karakter
            //Mű cime minimum 1 karakter
            //Kiadás éve -10000 -- 2023 akt évig
            //nyelv nem lehet üres
            //enci - true/false
            //eBook i/n

            //Minden hibát saját exceptionnal megoldani!!!!
            //Konyvespolc osztályban Szótárat létrehozni
            //A szótár kulcsa a könyv leltári száma
            //A szótár értéke a könyvnek a listában szereplő indexe
            Console.ReadKey();
        }
    }
}
