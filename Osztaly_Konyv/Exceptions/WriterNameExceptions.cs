using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class WriterNameExceptions:Exception 
    {
        private int length;

        public WriterNameExceptions(int length)
        {
            this.length = length;
        }
        public override string Message => $"A szerző nevének legalább 6 karakter hosszúnak kell lennie!\nEz a feltétel nem teljesült! (Hossz: {length})";



    }
}
