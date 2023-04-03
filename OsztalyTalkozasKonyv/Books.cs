using OsztalyTalkozasKonyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osztaly_Konyv;

namespace OsztalyTalkozasKonyv
{
    public class Book
    {
        //Konyv osztaly
        //isbnSzám 
        //Szerző
        //mű címe
        //Kiadási éve
        //nyelv
        //enciklopedia - t | f
        //ebook - i/n
        string isbnSzam;
        string szerzo;
        string muCim;
        int kiadasEv;
        string nyelv;
        bool enciklopedia;
        char ebooke;

        public Book(string isbnSzam, string szerzo, string muCim, int kiadasEv, string nyelv, bool enciklopedia, char ebooke)
        {
            this.isbnSzam = isbnSzam;
            this.szerzo = szerzo;
            this.muCim = muCim;
            this.kiadasEv = kiadasEv;
            this.nyelv = nyelv;
            this.enciklopedia = enciklopedia;
            this.ebooke = ebooke;
        }

        public string IsbSzam
        {
            get { return this.isbnSzam; }
            set
            {
                bool helyes = false;
                string bement = value;
                if (bement.Length == 10)
                {
                    List<int> szamok = new List<int>();
                    for (int i = 0; i < bement.Length; i++)
                    {
                        szamok.Add(Convert.ToInt32(bement.Split()[i]));
                    }
                    //ISBN számolás
                    int indexer = 10;
                    int osszes = 0;
                    foreach (int szam in szamok)
                    {

                        osszes += szam * indexer;
                        indexer--;
                    }
                    int oszto = osszes;
                    while (indexer % 11 != 0)
                    {
                        oszto++;
                    }
                    int uccso = oszto - osszes;
                    if (Convert.ToInt32(bement.Split()[bement.Length - 1]) == uccso)
                    {
                        isbnSzam = value;
                    }
                    else
                    {
                        throw new HibasIsbnSzamExpection(value);


                    }
                }
            }
        }
        
        public string Szerzo
        {
            get { return this.szerzo; }
            set { this.szerzo = value; }
        }
        public string MuCim
        {
            get { return MuCim; }
            set { MuCim = value; }
        }
        public int KiadasEv
        { 
        get { return this.kiadasEv; }
        set { this.kiadasEv = value;}
        }
        public string Nyelv
        { 
        get { return this.nyelv; }
        set { this.nyelv = value;}
        }
        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { this.enciklopedia = value; }
        
        }
        public char Ebooke
        { 
        get { return ebooke; }
        set { ebooke = value; }
        }

        //Konyv osztaly
        //isbnSzám 
        //Szerző
        //mű címe
        //Kiadási éve
        //nyelv
        //enciklopedia - t | f
        //ebook - i/n
        public override string ToString()
        {
            return $"Isbn száma: {isbnSzam}\nSzezője: {szerzo}\nA mű címe: {muCim}\nKiadás éve: {kiadasEv}\nNyelve:{nyelv}\nEnciklopédiának számít-e?: {(enciklopedia ? "Igen":"Nem")}\nE-Book formában elérhető-e?: {(ebooke == 'i' ? "Igen":"Nem")}";
        }
         



    }
}
