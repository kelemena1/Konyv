using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class EbookException:Exception
    {
        private string bevittadat;

        public EbookException(string bevittadat)
        {
            this.bevittadat = bevittadat;
        }
        public override string Message => $"A bevitt adat csak i vagy n lehet!\nAz általad megadott adat: {bevittadat}";

    }
}
