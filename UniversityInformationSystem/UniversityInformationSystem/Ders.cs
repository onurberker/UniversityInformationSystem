using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityInformationSystem
{
    class Ders
    {
        private string dersKodu, adi;
        private int akts;
        private double basariNotu;

        public Ders(string dersKodu, string adi, int akts, double basariNotu)
        {
            this.dersKodu = dersKodu ?? throw new ArgumentNullException(nameof(dersKodu));
            this.adi = adi ?? throw new ArgumentNullException(nameof(adi));
            this.akts = akts;
            this.basariNotu = basariNotu;
        }

        public double BasariNotu
        {

            get
            {
                return basariNotu;
            }
            set
            {
                if (value >= 0.0 && value <= 100.0)
                    basariNotu = value;
                else basariNotu = 0.0;
            }

        }

        public int Akts
        {

            get
            {
                return akts;
            }
            set
            {
                if (value > 0)
                    akts = value;
                else akts = -1;
            }

        }

        public override string ToString()
        {
            return dersKodu + "\t" + adi + "\t" + akts + " akts\t" + basariNotu;
        }
    }
}
