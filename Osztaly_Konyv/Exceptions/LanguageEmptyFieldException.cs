using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    
    internal class LanguageEmptyFieldException:Exception
    {
        private int length;
        public LanguageEmptyFieldException(int length) 
        { 
            this.length = length; 
        }
        public override string Message => $"A nyelv mező nem lehet üres!";

    }
}
