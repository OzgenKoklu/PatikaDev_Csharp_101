using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceOrnek
{
    //INTERFACE'DEN  INHERIT EDILMIS 
    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz; 
        }
    }
}
