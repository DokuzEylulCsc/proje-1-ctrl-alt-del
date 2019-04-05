using System;
using System.IO;

namespace kelimelik
{
    class Kaydedici
    {
        static private string name = "PlaceHolder";
        public static string N{ set => name = value; }
        static private string path;
       // static private int[] bilinenKelimeler = {0,0,0,0,0,0,0,0,0,0,0};//0.indis 2 harfliler 10.indis 12 harflilerden bilinenler
        static private FileStream fs;
        static private StreamWriter sw;
        static private StreamReader sr;
        public static void LogYaz()
        {
            path = @"..\" + name + "-Log.txt";
            fs = new FileStream(
            path,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite); //okunabilir ve yazilabilir.
            sw = new StreamWriter(fs);
            sr = new StreamReader(fs);
            EoF();
            sw.WriteLine("* Yeni Oyuna Baslandi *");
            sw.Flush();
        }//her oyun basinda yapilicak // yeniden oyna dendiginde de bu method cagirilacak ! 
        public static void LogYaz(int kacinciKelime , int KacTahmindeBildi , int KelimeKacHarfli, string zorlukSeviyesi)//bilinen kelimeler icin
        {
            EoF();
            sw.WriteLine("! "+KelimeKacHarfli.ToString()+" Harfli "+zorlukSeviyesi+ " zorluktaki " +kacinciKelime.ToString()+".Kelime "+kacinciKelime.ToString()+" Tahminde Bilindi");
            sw.WriteLine("");
            sw.Flush();
        }
        public static void LogYaz(int kacinciKelime,string ZorlukSeviyesi)//pas gecilen kelimeler icin 
        {
            EoF();
            sw.WriteLine(ZorlukSeviyesi + "" + kacinciKelime + ".Kelime pas gecildi");
            sw.Flush();
        }
        public static void LogYaz(int ToplamTahminSayisi)// oyun sonuna kadar yapilan tahmin sayisi
        {
            EoF();
            sw.WriteLine("& "+ToplamTahminSayisi.ToString() + " tahminde oyun bitirildi ");
            sw.Flush();
        }//butun oyun boyunca yapilan tahmin sayisi 
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
        public static void ToplamdaHarfSayisinaGoreBilinenKelimeler()
        {
            SoF();
            int a;
            string temp = sr.ReadLine();
            while(temp != null)
            {
                if(temp[0] == '!')
                {
                    a = Convert.ToInt32(temp.Split(' ')[1]);
                    bilinenKelimeler[a - 2]++;
                }
            }
        }//bilinen kelimeleri agirliklarina gore atar


        public static void EoF()
        {
            fs.Seek(fs.Length, SeekOrigin.Begin);
        }//End of file methodu
        public static void SoF()
        {
            fs.Seek(0, SeekOrigin.Begin);
        }//Start of file methodu
    }

}