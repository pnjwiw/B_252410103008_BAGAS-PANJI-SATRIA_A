using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    public interface DapatDidistribusikan
    {
    }
    public class DistribusiMBG : DapatDidistribusikan
    {
        public Sekolah SekolahTujuan { get; set; }
        public PaketMBG PaketMakanan { get; set; }
        public int JumlahPaket { get; set; }

        public DistribusiMBG(Sekolah sekolah, PaketMBG paket, int jumlah)
        {
            SekolahTujuan = sekolah;
            PaketMakanan = paket;
            JumlahPaket = jumlah;
        }

        public void KirimPaket()
        {
            if (JumlahPaket <= 0)
            {
                Console.WriteLine("Distribusi gagal: Jumlah paket yang dikirim harus lebih dari 0 !!!");
                return;
            }
            if (JumlahPaket > PaketMakanan.StokDapur)
            {
                Console.WriteLine("Distribusi gagal: Stok dapur tidak mencukupi " +
                                  "Stok tersedia: " + PaketMakanan.StokDapur, "diminta: " + JumlahPaket);
                return;
            }

            PaketMakanan.KurangiStok(JumlahPaket);
            SekolahTujuan.jumlahPaketDiterima += JumlahPaket;

            Console.WriteLine("Distribusi MBG berhasil! Sebanyak " + JumlahPaket + "paket makanan " +
                              "telah dikirim ke sekolah " + SekolahTujuan.namaSekolah);
        }
    }
}
