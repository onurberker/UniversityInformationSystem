using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInformationSystem
{
    abstract class Ogrenci : IHesaplayıcı
    {
        protected int no;
        protected string ad, soyad, bolumAdi;
        protected List<Ders> dersler;
        private double kumulatifNotu;

        protected Ogrenci(int no, string ad, string soyad, string bolumAdi, List<Ders> dersler)
        {
            if (no >= 2000000000)
                this.no = no;
            else this.no = new Random().Next(2000000001, 2019000000);

            this.ad = ad ?? throw new ArgumentNullException(nameof(ad));
            this.soyad = soyad ?? throw new ArgumentNullException(nameof(soyad));
            this.bolumAdi = bolumAdi ?? throw new ArgumentNullException(nameof(bolumAdi));
            this.dersler = dersler ?? throw new ArgumentNullException(nameof(dersler));

            KumulatifHesaplayıcı();
        }

        public double KumulatifNotu { get => kumulatifNotu; set => kumulatifNotu = value; }

        /// <summary>
        /// mevcut dersdlerin basarı notu ve akts sine bağlı kumulatif not hesaplaması yapar
        /// </summary>
        /// <param name="akts"> akts belirtilmeyen dersler için param</param>
        public void KumulatifHesaplayıcı(int akts = 5)
        {
            if (dersler != null)
            {
                //akts si olmayanlara atama yaptık
                foreach (Ders ders in dersler)
                {
                    if (ders.Akts == -1) // yani akts belirtilmemişse
                    {
                        ders.Akts = akts;
                    }

                }
                double total = 0.0;
                double aktsTotal = 0;
                foreach (Ders ders in dersler)
                {
                    total += (ders.Akts * 1.0) * ders.BasariNotu;
                    aktsTotal += (ders.Akts * 1.0);

                }

                kumulatifNotu = total / aktsTotal;


            }
            else kumulatifNotu = 0.0;

        }

        public override string ToString()
        {

            string ret = "";

          
            ret += "\t" + no + "; " + ad + " " + soyad + "; " + bolumAdi + "\n";

            ret += "Ders Bilgileri\n";
            foreach (Ders ders in dersler)
            {
                ret += "\t\t" + ders.ToString() + "\n";

            }

            return ret;
        }


        
    }
}
