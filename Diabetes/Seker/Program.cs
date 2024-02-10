using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seker
{
    class Program
    {
        static bool SoruSor(string soru)
        {
            Console.Write(soru);
            string cevap = Console.ReadLine().ToLower();
            return (cevap == "evet");
        }

        static void SonucGoster(double puan)
        {
            Console.WriteLine("Risk Puaniniz: " + puan);

            if (puan >= 6.0 && puan <= 25.0)
            {
                Console.WriteLine("Sonuc: Yuksek Seker Hastaligi Riski");
            }
            else if (puan >= 3.0 && puan < 6.0)
            {
                Console.WriteLine("Sonuc: Orta Seker Hastaligi Riski");
            }
            else
            {
                Console.WriteLine("Sonuc: Dusuk Seker Hastaligi Riski");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Diyabet Risk Değerlendirme Sistemi\n");

            double puan = 0;

            // Poliuri
            bool poliuri = SoruSor("Poliuri (Evet/Hayir): ");
            puan += poliuri ? 3.0 : 0.0;

            // Polidipsi
            bool polidipsi = SoruSor("Polidipsi (Evet/Hayir): ");
            puan += polidipsi ? 2.5 : 0.0;

            // Kasinti
            bool kasinti = SoruSor("Kasinti (Evet/Hayir): ");
            puan += kasinti ? 1.0 : 0.0;

            // IyilesmeninGecikmesi
            bool iyilesmeninGecikmesi = SoruSor("IyilesmeninGecikmesi (Evet/Hayir): ");
            puan += iyilesmeninGecikmesi ? 1.0 : 0.0;

            // Alopesi
            bool alopesi = SoruSor("Alopesi (Evet/Hayir): ");
            puan += alopesi ? 1.0 : 0.0;

            // Cinsiyet (Erkek)
            bool cinsiyetErkek = SoruSor("Cinsiyet (Erkek/Kadin): ");
            if (cinsiyetErkek)
            {
                puan += 0.5; // Erkek cinsiyet için ek puan

                // GorselBulaniklik
                bool gorselBulaniklik = SoruSor("GorselBulaniklik (Evet/Hayir): ");
                puan += gorselBulaniklik ? 0.5 : 0.0;

                // AniKiloKaybi
                bool aniKiloKaybi = SoruSor("AniKiloKaybi (Evet/Hayir): ");
                puan += aniKiloKaybi ? 1.0 : 0.0;
            }
            else
            {
                puan += 1.0; // Kadın cinsiyet için ek puan
            }

            // Sinirlilik
            bool sinirlilik = SoruSor("Sinirlilik (Evet/Hayir): ");
            puan += sinirlilik ? 0.5 : 0.0;

            // GenitalPamukcuk
            bool genitalPamukcuk = SoruSor("GenitalPamukcuk (Evet/Hayir): ");
            puan += genitalPamukcuk ? 0.5 : 0.0;

            Console.Write("Yas (Genc/OrtancaYas/Yasli/UzunOmurlu): ");
            string yas = Console.ReadLine().ToLower();

            // Yas (Genc)
            if (yas == "genc")
            {
                // Polifaji
                bool polifaji = SoruSor("Polifaji (Evet/Hayir): ");
                puan += polifaji ? 1.0 : 0.0;
            }

            SonucGoster(puan);
            Console.ReadLine();
        }
    }
}
