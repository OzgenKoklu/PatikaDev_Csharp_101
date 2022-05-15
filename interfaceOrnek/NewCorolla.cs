using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceOrnek
{
    //ABSTRACT CLASSTAN INHERIT EDILMIS 
    internal class NewCorolla : Otomobil
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
