using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class EnciException:Exception
    {
        public EnciException()
        {
            
        }
        public override string Message => $"Az enci mezőnek true vagy false értéknek kell lennie!";

    }
}
