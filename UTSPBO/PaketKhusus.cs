using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    class PaketKhusus : PaketMBG
    {
        public string JenisDiet { get; set; }

        private const decimal HargaPerPaket = 20000;

        public PaketKhusus(string idPaket, string namaPaket, int stokDapur, string jenisDiet)
            : base(idPaket, namaPaket, stokDapur)
        {
            JenisDiet = jenisDiet;
        }
        public override decimal HitungBiaya(int jumlah)
        {
            return jumlah * HargaPerPaket;
        }

        public override void TampilInfo()
        {
            base.TampilInfo();
            Console.WriteLine("Jenis : Paket Khusus" + JenisDiet);
            Console.WriteLine("Harga : Rp" + HargaPerPaket);
        }
    }
    }