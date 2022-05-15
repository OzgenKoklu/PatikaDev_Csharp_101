using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceOrnek
{
    //INTERFACE'DEN  INHERIT EDILMIS 
    public class Corolla:IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
