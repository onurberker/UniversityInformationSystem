using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInformationSystem
{
    class YuksekLisans : Ogrenci
    {
        private string lisansMezunUniAdi,lisanMezunBolumAdi;

        
        public YuksekLisans(string lisansMezunUniAdi, string lisanMezunBolumAdi, int no, string ad, string soyad, string bolumAdi, List<Ders> dersler) : base(no, ad, soyad, bolumAdi, dersler)
        {
            this.lisansMezunUniAdi = lisansMezunUniAdi ?? throw new ArgumentNullException(nameof(lisansMezunUniAdi));
            this.lisanMezunBolumAdi = lisanMezunBolumAdi ?? throw new ArgumentNullException(nameof(lisanMezunBolumAdi));


        }

        public override string ToString()
        {
            string ret = "Lisans Bilgileri\n";
            ret += "\t\t\t" + lisansMezunUniAdi + "; " + lisanMezunBolumAdi + "\n";

            return ret + base.ToString();
        }
    }
}
