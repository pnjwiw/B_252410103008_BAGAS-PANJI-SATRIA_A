using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_252410103008_BAGAS_PANJI_SATRIA_A
{
    public abstract class PaketMBG
    {
        private string idPaket;
        private string namaPaket;
        private int stokDapur;

        public string IdPaket
        {
            get { return idPaket; }
            set { idPaket = value; }
        }

        public string NamaPaket
        {
            get { return namaPaket; }
            set { namaPaket = value; }
        }

        public int StokDapur
        {
            get { return stokDapur; }
            private set
            {
                if (value < 0)
                    Console.WriteLine("Stok dapur tidak boleh negatif.");
                stokDapur = value;
            }
        }

        public PaketMBG(string idPaket, string namaPaket, int stokDapur)
        {
            IdPaket = this.idPaket;
            NamaPaket = this.namaPaket;
            StokDapur = this.stokDapur;
        }

        public void KurangiStok(int jumlah)
        {
            if (jumlah <= 0)
            {
                Console.WriteLine("Jumlah pengurangan harus lebih dari 0.");
                return;
            }
            if (jumlah > stokDapur)
            {
                Console.WriteLine($"Stok tidak mencukupi. Stok tersedia: {stokDapur}, diminta: {jumlah}.");
                return;
            }
            stokDapur -= jumlah;
        }

        public abstract decimal HitungBiaya(int jumlah);

        public virtual void TampilInfo()
        {
            Console.WriteLine($"ID Paket  : " + IdPaket);
            Console.WriteLine($"Nama Paket: " + NamaPaket);
            Console.WriteLine($"Stok      : " + StokDapur);
        }
    }
}

