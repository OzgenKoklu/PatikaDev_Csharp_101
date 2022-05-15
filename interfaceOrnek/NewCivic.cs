using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceOrnek
{
    //ABSTRACT CLASSTAN INHERIT EDILMIS 
    internal class NewCivic : Otomobil
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Honda;
        }
    }
}
