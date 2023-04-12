using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class TitleLengthException:Exception
    {
        private int length;

        public TitleLengthException(int length)
        {
            this.length = length;
        }
        public override string Message => $"A könyv címének legalább 1 karakter hosszúnak kell lennie!\nEz a feltétel nem teljesült! (Hossz: {length})";
    }
}
