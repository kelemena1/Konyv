using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osztaly_Konyv.Exceptions;


namespace Osztaly_Konyv
{
    public class Konyv
    {
        private string isbnSzam;
        private string szerzo;
        private string cim;
        private int _kiadasEv;
        private string nyelv;
        private bool enciklopediae;
        private char eBook;
        private string leltariSzam;
        private Random rand = new Random();

        public string IsbnSzam
        {
            get => isbnSzam;
            set
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new ISBN_NumberLengthException(value.Length);
                }
                switch (value.Length)
                {
                    case 10:

                        //2. tipus
                        /*int szam = 0;
                        int n = 1;
                        for (int i = 0; i < 9; i++)
                        {
                            szam += n * int.Parse(value[i].ToString());
                            n++;
                        }
                        if (szam % 11 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }*/


                        //1. tipus
                        int szam3 = 0;
                        int n3 = 10;
                        int oszto = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            if (n3 >= 2 && n3 <= 10)
                            {
                                szam3 += n3 * int.Parse(value[i].ToString());
                                n3--;

                            }
                        }
                        while ((oszto * 11) < szam3)
                        {
                            oszto++;
                        }
                        if ((oszto * 11) - szam3 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }
                        break;
                    case 13:
                        int szam2 = 0;
                        int n2;
                        for (int i = 0; i < 12; i++)
                        {
                            if (i % 2 == 0)
                            {
                                n2 = 1;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                            else
                            {
                                n2 = 3;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                        }
                        if (szam2 % 10 != int.Parse(value[12].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }

                        break;
                    default:
                        break;
                }
                isbnSzam = value;

            }
        }

        public string Szerzo { 
            get => szerzo; 
            set
            {
                int szerzoHossz= value.Length;
                if (szerzoHossz >= 6)
                {
                    szerzo = value;
                }
                else {
                    throw new WriterNameExceptions(value.Length);
                }
            
            
            
            } 
        }
        public string Cim 
        { 
            get => cim; 
            set 
            { 
                int cimHossz= value.Length;
                if (cimHossz < 1)
                {
                    throw new BookNameLengthException(value.Length);
                }
                else
                {
                    cim = value;
                }

            } 
        }
        public int KiadasEv { get => _kiadasEv; 
            set
            {
                int ev = value;
                if (ev > -10000 && ev <= 2023)
                {
                    _kiadasEv = value;
                }
                else
                {
                    throw new YearOfPublicationException(ev);
                
                }
            }
        }
        public string Nyelv { get => nyelv;
            set
            { 
                int nyelvHossz= value.Length;
                if (nyelvHossz == 0)
                {
                    throw new LanguageEmptyFieldException(nyelvHossz);
                
                }
                else 
                {
                    nyelv = value;
                }
            }
        }
        public bool Enciklopediae { get => enciklopediae; set 
            {

                if (typeof(bool) == value.GetType())
                {
                    enciklopediae = value;

                }
                else
                {
                    throw new EnciException();
                
                }
            }
        }
        public char Ebook { get => eBook; set 
            {
                string bevittadat = Convert.ToString(value);
                if (bevittadat == "i" || bevittadat == "n" && bevittadat.Length == 1)
                {
                    eBook = Convert.ToChar(bevittadat);
                }
                else
                {
                    throw new EbookException(bevittadat);
                
                }
            }
        }
        public string LeltariSzam
        {
            get => leltariSzam; 
            set 
            {
                int leltariszamHossz = value.Length;
                if (leltariszamHossz == 11)
                {
                    leltariSzam = value;

                }
                else 
                { 
                    throw new BookInventoryNumberException(value.Length);
                }
            }
        }

        public Konyv()
        {

        }

        public Konyv(string isbnSzam, string szerzo, string cim, int kiadasEv, string nyelv, bool enciklopediae, char ebook, string leltariSzam)
        {
            IsbnSzam = isbnSzam;
            Szerzo = szerzo;
            Cim = cim;
            KiadasEv = kiadasEv;
            Nyelv = nyelv;
            Enciklopediae = enciklopediae;
            Ebook = ebook;
            LeltariSzam = leltariSzam;

        }

        ~Konyv()
        {
            Console.WriteLine("DESTRUKTOR CSSSSSSSSSSSSSSS");
        }
    }
}
