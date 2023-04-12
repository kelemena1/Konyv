using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    public class KonyvesPolc
    {
        List<Konyv> _konyvek=new List<Konyv>();
        Dictionary<string, int> konyvekDict = new Dictionary<string, int>();

        public void konyvHozzaAdasa(Konyv konyv)
        {
            _konyvek.Add(konyv);
        }

        public void konyvSelejtezese(Konyv konyv)
        {
            _konyvek.Remove(konyv);
        }

        public int konyvekSzama
        {
            get { return _konyvek.Count;}
        }

        public int konyvekSzamaFuggveny()
        {
            return _konyvek.Count;
        }
        //public KonyvesPolc() { }
        //Dictionary eljárások:
        public void konyvDictionaryHozzaadas(Konyv konyv)
        {
           // Console.WriteLine("Index"+_konyvek.IndexOf(konyv));
            konyvekDict.Add(konyv.LeltariSzam, _konyvek.IndexOf(konyv));
        }
        public int konyvDictHossz() 
        {
            
            return konyvekDict.Count;
        }
        public void konyvDictTorles(string leltariszam)
        { 
            konyvekDict.Remove(leltariszam);
            
        }
    }
}
