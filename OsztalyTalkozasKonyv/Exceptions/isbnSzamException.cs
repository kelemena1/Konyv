using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyTalkozasKonyv.Exceptions
{
    internal class HibasIsbnSzamExpection : Exception
    {
        string isbnSzam;
        public string IsbnSzamEllenorzes
        {
            get { return isbnSzam; }
            set { isbnSzam = value; }
        }

        public HibasIsbnSzamExpection(string isbnSzam)
        {
            this.isbnSzam = isbnSzam;
        
        }



    }
        
}
