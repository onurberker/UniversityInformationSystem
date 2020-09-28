using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInformationSystem
{
     class Lisans : Ogrenci
    {
        public Lisans(int no, string ad, string soyad, string bolumAdi, List<Ders> dersler) : base(no, ad, soyad, bolumAdi, dersler)
        {

           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
