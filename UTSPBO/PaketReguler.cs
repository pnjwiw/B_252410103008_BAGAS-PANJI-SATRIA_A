using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    class PaketReguler : PaketMBG
    {
        private const decimal HargaPerPaket = 15000;

        public PaketReguler(string idPaket, string namaPaket, int stokDapur)
            : base(idPaket, namaPaket, stokDapur)
        {
        }

        public override decimal HitungBiaya(int jumlah)
        {
            return jumlah * HargaPerPaket;
        }
        
        public override void TampilInfo()
        {
            base.TampilInfo();
            Console.WriteLine("Jenis   : Paket Reguler (Nasi, Ayam, Sayur, Buah)");
            Console.WriteLine("Harga per paket  : Rp" + HargaPerPaket);
        }
    }
}
