using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class YearOfPublicationException:Exception
    {
        private int PublicationYear;
        public YearOfPublicationException(int PublicationYear)
        {
            this.PublicationYear = PublicationYear;
        }
        public override string Message => $"A kiadás éve -10.000 és 2023 között kell lennie!\nEz a feltétel nem teljesült! (A megadott év: {PublicationYear})";
    }
}
