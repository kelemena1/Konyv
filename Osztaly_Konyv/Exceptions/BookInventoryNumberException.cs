using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class BookInventoryNumberException : Exception
    {
        private int length;
        public BookInventoryNumberException(int length)
        {
            this.length = length;
        }
        public override string Message => $"A könyv leltári számának ponttosan 11 karakternek kell lennie!\nEz a feltétel nem teljesült! (Hossz: {length})";
    }
}
