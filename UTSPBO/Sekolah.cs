using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    public class Sekolah
    {
        public string idSekolah;
        public string namaSekolah;
        public int jumlahPaketDiterima;

        public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima = 0)
        {
            this.idSekolah = idSekolah;
            this.namaSekolah = namaSekolah;
            this.jumlahPaketDiterima = jumlahPaketDiterima;
        }

        public void TampilInfo()
        {
            Console.WriteLine("ID Sekolah     : " + idSekolah);
            Console.WriteLine("Nama Sekolah   : " + namaSekolah);
            Console.WriteLine("Paket Diterima : " + jumlahPaketDiterima);
        }
    }
}
