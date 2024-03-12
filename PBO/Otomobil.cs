using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO
{
    class Otomobil
    {
        public int roda;
        public string bahanBakar;
        public string merk;
        public string jenisKendaraan;

        public Otomobil(int roda, string bahanBakar, string merk, string jenisKendaraan) 
        { 
            this.roda = roda;
            this.bahanBakar = bahanBakar;
            this.merk = merk;
            this.jenisKendaraan = jenisKendaraan;
        }
    }

    class sedan : Otomobil
    {
        public int bagasi;
        public int kursi;

        public sedan(int roda, string bahanBakar, string merk, string jenisKendaraan, int bagasi, 
            int kursi) : base (roda, bahanBakar, merk, jenisKendaraan)
        {
            this.bagasi = bagasi;
            this.kursi = kursi;
        }

        public void print()
        {
            Console.WriteLine($"Roda : {roda}");
            Console.WriteLine($"Bahan Bakar : {bahanBakar}");
            Console.WriteLine($"Merk : {merk}");
            Console.WriteLine($"Jenis Kendaraan : {jenisKendaraan}");
            Console.WriteLine($"Bagasi : {bagasi} liter");
            Console.WriteLine($"Jumlah Kursi : {kursi}\n");
        }
    }

    class truk : Otomobil
    {
        public string kondisiBak;
        public int muatan;

        public truk(int roda, string bahanBakar, string merk, string jenisKendaraan, string kondisiBak,
            int muatan) : base(roda, bahanBakar, merk, jenisKendaraan)
        {
            this.kondisiBak = kondisiBak;
            this.muatan = muatan;
        }

        public void print()
        {
            Console.WriteLine($"Roda : {roda}");
            Console.WriteLine($"Bahan Bakar : {bahanBakar}");
            Console.WriteLine($"Merk : {merk}");
            Console.WriteLine($"Jenis Kendaraan : {jenisKendaraan}");
            Console.WriteLine($"Kondisi Bak : {kondisiBak}");
            Console.WriteLine($"Jumlah Muatan : {muatan}\n");
        }
    }

    class sepedaMotor : Otomobil
    {
        public string pengoprasian;
        public string warna;

        public sepedaMotor(int roda, string bahanBakar, string merk, string jenisKendaraan, string pengoprasian,
            string warna) : base(roda, bahanBakar, merk, jenisKendaraan)
        {
            this.pengoprasian = pengoprasian;
            this.warna = warna;
        }

        public void print()
        {
            Console.WriteLine($"Roda : {roda}");
            Console.WriteLine($"Bahan Bakar : {bahanBakar}");
            Console.WriteLine($"Merk : {merk}");
            Console.WriteLine($"Jenis Kendaraan : {jenisKendaraan}");
            Console.WriteLine($"Pengoprasian : {pengoprasian}");
            Console.WriteLine($"Warna Body : {warna}\n");
        }
    }
}
