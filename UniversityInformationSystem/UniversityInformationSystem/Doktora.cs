using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInformationSystem
{
    class Doktora : Ogrenci
    {
        private string lisansMezunUniAdi, lisanMezunBolumAdi;
        private string yuksekLisansMezunUniAdi, yuksekLisanMezunBolumAdi;


        public Doktora(string yuksekLisansMezunUniAdi, string yuksekLisanMezunBolumAdi, string lisansMezunUniAdi, string lisanMezunBolumAdi, int no, string ad, string soyad, string bolumAdi, List<Ders> dersler) : base(no, ad, soyad, bolumAdi, dersler)
        {
            this.lisansMezunUniAdi = lisansMezunUniAdi ?? throw new ArgumentNullException(nameof(lisansMezunUniAdi));
            this.lisanMezunBolumAdi = lisanMezunBolumAdi ?? throw new ArgumentNullException(nameof(lisanMezunBolumAdi));

            this.yuksekLisansMezunUniAdi = yuksekLisansMezunUniAdi ?? throw new ArgumentNullException(nameof(yuksekLisansMezunUniAdi));
            this.yuksekLisanMezunBolumAdi = yuksekLisanMezunBolumAdi ?? throw new ArgumentNullException(nameof(yuksekLisanMezunBolumAdi));

          

        }

        public override string ToString()
        {


            string ret = "Lisans Bilgileri\n";
            ret += "\t\t\t" + lisansMezunUniAdi + "; " + lisanMezunBolumAdi + "\n";

            ret += "Yüksek Lisans Bilgileri\n";
            ret += "\t\t\t" + yuksekLisansMezunUniAdi + "; " + yuksekLisanMezunBolumAdi + "\n";
            return ret + base.ToString();
        }
    }
}

