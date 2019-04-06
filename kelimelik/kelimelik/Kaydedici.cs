using System;
using System.IO;

namespace kelimelik
{
    class Kaydedici
    {
        static private string name = "PlaceHolder";
        public static string N{ set => name = value; get => name; }
        public static int PasSayisi { get => pasSayisi; set => pasSayisi = value; }
        public static int TahminSayisi { get => tahminSayisi; set => tahminSayisi = value; }
        public static int BilinenKelimeSayisi { get => bilinenKelimeSayisi; set => bilinenKelimeSayisi = value; }
        public static string Zorluk { get => zorluk; set => zorluk = value; }

        private static string zorluk = "";
        static private string path;
        private static int pasSayisi=0;
        private static int tahminSayisi=0;
        private static int bilinenKelimeSayisi = 0;
   
        static private FileStream fs;
        static private StreamWriter sw;
        static private StreamReader sr;
        public static void LogYaz()
        {
            StreamAc();
            sw.WriteLine("* Yeni Oyuna Baslandi *");
            sw.Flush();
        }//her oyun basinda yapilicak // yeniden oyna dendiginde de bu method cagirilacak ! 
        public static void LogYaz(int kacinciKelime , int KacTahmindeBildi , int KelimeKacHarfli, string zorlukSeviyesi)//bilinen kelimeler icin
        {
            EoF();
            sw.WriteLine("! "+KelimeKacHarfli.ToString()+" Harfli "+zorluk+ " zorluktaki " +kacinciKelime.ToString()+".Kelime "+KacTahmindeBildi.ToString()+" Tahminde Bilindi");
            sw.Flush();
        }
        public static void LogYaz(string a)
        {
            sw.WriteLine(a);
            sw.Flush();
        }
        public static double OyunBasinaOrtalamaTahminSayisi()
        {
            string[] temp1;
            string temp = " ";
            int kacOyunVar = 0;
            int toplamTahmin = 0;
            SoF();
            temp = sr.ReadLine();
            while (temp != null)
            {
                
                if(temp[0] =='*')
                {
                    kacOyunVar++;
                }
                else if (temp[0] == '&')
                {
                    temp1 = temp.Split(' ');
                    toplamTahmin += Convert.ToInt32(temp1[1]);
                }
                temp = sr.ReadLine();
            }
            EoF();
            return Convert.ToDouble(toplamTahmin) / Convert.ToDouble(kacOyunVar);
        }//oyun basina ortalama tahmin sayisini dondurur
        public static int ToplamOyunSayisi()
        {
            string temp = " ";
            int toplamOyun = 0;
            SoF();
            temp = sr.ReadLine();
            while (temp != null)
            {
                
                if (temp[0] == '*')
                {
                    toplamOyun++;
                }
                temp = sr.ReadLine();
            }
            return toplamOyun;
        } //toplamda oynanan oyun sayisini dondurur
        public static int ToplamBilinenKelime()
        {
            SoF();
            string temp = " ";
            int bilinenKelimeSayisi = 0;
            temp = sr.ReadLine();
            while (temp != null)
            {
                
                if (temp[0] == '!')
                {
                    bilinenKelimeSayisi++;
                }
                temp = sr.ReadLine();
            }
            return bilinenKelimeSayisi;
        }//oynanan butun oyunlardaki bilinen kelime sayisini dondurur
        public static int ToplamPasSayisi()
        {
            SoF();
            int sayac = 0;
            string temp = sr.ReadLine();
            while(temp != null)
            {
                if(temp[0] == 'P')
                {
                    sayac++;
                }
                temp = sr.ReadLine();
            }
            return sayac;
        }

        public static int ToplamTahminSayisi()
        {
            SoF();
            int sayac = 0;
            string temp = sr.ReadLine();
            while(temp != null)
            {
                if (temp[0] == '-')
                {
                    sayac++;
                }
                temp = sr.ReadLine();
            }
            return sayac;
        }
        public static void StreamKapat()
        {
            sw.Close();
            sr.Close();
        }
        

        public static void EoF()
        {
            fs.Seek(fs.Length, SeekOrigin.Begin);
        }//End of file methodu
        public static void SoF()
        {
            fs.Seek(0, SeekOrigin.Begin);
        }//Start of file methodu
        public static void StreamAc()
        {
            path = @"..\" + name + "-Log.txt";
            fs = new FileStream(
            path,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite); //okunabilir ve yazilabilir.
            sw = new StreamWriter(fs);
            sr = new StreamReader(fs);
            EoF();
        }
    }

}