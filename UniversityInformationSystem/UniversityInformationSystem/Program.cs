using System;
using System.Collections.Generic;

namespace UniversityInformationSystem
{
    class Program
    {

        private static List<Ogrenci> ogrler;
        static void Main(string[] args)
        {
            
           FirstBoot();
            Menu();


           

          


        }

        static void FirstBoot()
        {
           ogrler = new List<Ogrenci>();


            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders("MAT101", "Matematik1",6,62));
            dersler.Add(new Ders("MAT107", "Soyut Matematik", 6, 60));
            dersler.Add(new Ders("FSH333", "Hayat Bilgisi", 8, 60));
            Ogrenci ogr1 = new Lisans(2008291014, "HAMIYET","MANDIRALI", "MATEMATIK",dersler);

            ogrler.Add(ogr1);

            dersler = new List<Ders>();


            dersler.Add(new Ders("MAT101", "Matematik1", 6, 95));
            dersler.Add(new Ders("MAT107", "Soyut Matematik", 6, 90));
            dersler.Add(new Ders("FSH333", "Hayat Bilgisi", 8, 100));
            dersler.Add(new Ders("AST101", "Astrofizige Giris", 12, 88));

             ogr1 = new Lisans(2008291022, "TANER", "INER", "ASTROFIZIK", dersler);

            ogrler.Add(ogr1);


            dersler = new List<Ders>(); 

            dersler.Add(new Ders("TAR505", "Tatar Tarihi", 18, 79));
            dersler.Add(new Ders("TAR511", "Uzakdogu Halklari", 18, 100));
             ogr1 = new YuksekLisans("ISTANBUL ÜNIVERSITESI", "TARIH", 2009291062, "ADIL KEMAL", "KUKRER", "TARIH", dersler);

            ogrler.Add(ogr1);

            dersler = new List<Ders>();

            dersler.Add(new Ders("CSC5001", "Fuzzy Data Analysis", 8, 78));
            dersler.Add(new Ders("CSC5019", "Software Requirements Engineering", 8, 40));
            dersler.Add(new Ders("MAT5101", "Applied Mathematics", 9, 83));
            ogr1 = new YuksekLisans("DOKUZ EYLÜL ÜNIVERSITESI", "BILGISAYAR BILIMLERI", 2010432000, "SENEM", "BILGIÇ", "BILGISAYAR BILIMLERI", dersler);

            ogrler.Add(ogr1);

            dersler = new List<Ders>();

            dersler.Add(new Ders("SPB603", "Rehabilitatif Spor", 18, 95));
            dersler.Add(new Ders("SPB630", "Sporda Sponsorluk", 6, 100));
            ogr1 = new Doktora("UNVERSITY OF BRITISH COLUMBIA", "KINESIOLOGY", "EGE ÜNIVERSITESI", "BEDEN EGITIMI VE SPOR", 2009291030, "DOGAÇ", "SAZAN", "SPOR BILIMLERI", dersler);

            ogrler.Add(ogr1);






            /*Console.WriteLine("Kayıtlı Öğrenciler\n\n");
            foreach(Ogrenci ogrenci in ogrler)
            {
                Console.WriteLine(ogrenci.GetType().Name);
                Console.WriteLine(ogrenci.ToString() + "Kumulatif basari Notu : " + ogrenci.KumulatifNotu + "\n");
            } */



        }


        static void Menu()
        {

            string ch;

            while(true)
            {
                Console.WriteLine("\n1 - Bilgi girisi\n2- Bilgileri ekranda goster\n3- Çıkış");

                ch = Console.ReadLine();

                switch(ch)
                {
                    case "1":
                        {

                            BilgiGirisi();
                            break;
                        }

                    case "2":
                        {
                            BilgileriEkrandaGoster();
                            break;
                        }
                    case "3":
                        {


                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nHatali islem girdiniz\n");
                            break;
                        }

                }



            }

        }

        static void BilgileriEkrandaGoster()
        {
            Console.WriteLine("Kayıtlı Öğrenciler\n\n");
            foreach (Ogrenci ogrenci in ogrler)
            {
                Console.WriteLine("\n"+ogrenci.GetType().Name);
                Console.WriteLine(ogrenci.ToString() + "Kumulatif basari Notu : " + ogrenci.KumulatifNotu + "\n");
            }
        }

        static void BilgiGirisi()
        {


            Console.WriteLine("\nOgr no girin :\n");

            int ogrno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Isim girin :\n");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyisim girin :\n");

            string soyIsim = Console.ReadLine();

            Console.WriteLine("Bolum adını girin :\n");

            string bolumadi = Console.ReadLine();



            Console.WriteLine("Ders sayısını girin :\n");
            int sayi;
            while(true)
            {
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    break;
                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nHatali giris\n");
                }
            }

            List<Ders> dersler = new List<Ders>();
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("\n" +(i+1) + ". Ders kodunu girin :");
                string dersKodu = Console.ReadLine();

                Console.WriteLine("\n" + (i + 1) + ". Adını girin :");
                string adi = Console.ReadLine();

                Console.WriteLine("\n" + (i + 1) + ". akts girin mevcut değilse -1 girin :");
                int akts = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + (i + 1) + ". Dersin basari notunu girin :");

                string str = Console.ReadLine();
               str = str.Replace(".", ",");
                double basariNotu = Convert.ToDouble(str);

                dersler.Add(new Ders(dersKodu, adi, akts, basariNotu));

            }

            Console.WriteLine("Ogrenci tipini seçin\n1-Lisans\n2-Yuksek Lisans\n3-Doktora");

            string ch = Console.ReadLine();
            Ogrenci ogr=null;
            bool exit = false;
           while(!exit)
            {
            switch(ch)
            {
                case "1":
                    {
                        ogr = new Lisans(ogrno, isim, soyIsim, bolumadi, dersler);
                        exit = true;
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Lisanstan mezun oldugu okul adini giriniz.\n");
                        string lisansMezuniyetOkulAdi = Console.ReadLine();
                        Console.WriteLine("Lisanstan mezun oldugu bolumun adini giriniz.\n");
                        string lisansMezuniyetBolumAdi = Console.ReadLine();
                        ogr = new YuksekLisans(lisansMezuniyetOkulAdi,lisansMezuniyetBolumAdi,ogrno, isim, soyIsim, bolumadi, dersler);
                        exit = true;
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Lisanstan mezun oldugu okul adini giriniz.\n");
                        string lisansMezuniyetOkulAdi = Console.ReadLine();
                        Console.WriteLine("Lisanstan mezun oldugu bolumun adini giriniz.\n");
                        string lisansMezuniyetBolumAdi = Console.ReadLine();
                        Console.WriteLine("Yuksek Lisanstan mezun oldugu okul adini giriniz.\n");
                        string yuksekLisansMezuniyetOkulAdi = Console.ReadLine();
                        Console.WriteLine("Yuksek Lisanstan mezun oldugu bolumun adini giriniz.\n");
                        string yuksekLisansMezuniyetBolumAdi = Console.ReadLine();
                        ogr = new Doktora(yuksekLisansMezuniyetOkulAdi,yuksekLisansMezuniyetBolumAdi,lisansMezuniyetOkulAdi, lisansMezuniyetBolumAdi, ogrno, isim, soyIsim, bolumadi, dersler);
                        exit = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hatali Ogrenci Tipi sectiniz.\n");
                        break;
                    }
                }
            }
            ogrler.Add(ogr);







        }

    }
}
