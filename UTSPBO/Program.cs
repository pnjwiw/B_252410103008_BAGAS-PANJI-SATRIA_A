using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   SISTEM MANAJEMEN MAKAN BERGIZI GRATIS PRAWOWO      ");

            Console.WriteLine("informasi sekolah ");
            Sekolah sekolah1 = new Sekolah("sekolah-001", "SDN Merdeka 01");
            Sekolah sekolah2 = new Sekolah("sekolah-002", "SMPN Nusantara 03");

            Console.WriteLine("\nSekolah 1");
            sekolah1.TampilInfo();
            Console.WriteLine("\nSekolah 2");
            sekolah2.TampilInfo();

            PaketReguler paketReguler = new PaketReguler("paket01", "Paket Reguler Harian", 100);
            PaketKhusus paketKhusus = new PaketKhusus("paket01", "Paket Khusus Diet", 5, "Vegetarian");

            Console.WriteLine("\nPaket Reguler");
            paketReguler.TampilInfo();

            Console.WriteLine("\nPaket Khusus");
            paketKhusus.TampilInfo();

            paketReguler.KurangiStok(150); 
            Console.WriteLine("Stok setelah percobaan: " + paketReguler.StokDapur);

            paketReguler.KurangiStok(10); 
            Console.WriteLine("Stok setelah pengurangan: " + paketReguler.StokDapur);

            paketReguler = new PaketReguler("PKT-R01", "Paket Reguler Harian", 100);
            paketKhusus = new PaketKhusus("PKT-K01", "Paket Khusus Diet", 5, "Vegetarian");

            PaketMBG paketA = new PaketReguler("PKT-R01", "Paket Reguler Harian", 100);
            PaketMBG paketB = new PaketKhusus("PKT-K01", "Paket Khusus Diet", 5, "Vegetarian");

            int jumlahHitung = 30;
            Console.WriteLine("\nHitung biaya untuk " + jumlahHitung + " paket:");
            Console.WriteLine("PaketReguler HitungBiaya " + jumlahHitung + " = Rp " + paketA.HitungBiaya(jumlahHitung));
            Console.WriteLine("PaketKhusus  HitungBiaya " + jumlahHitung + " = Rp " + paketB.HitungBiaya(jumlahHitung));

        }
    }
}
