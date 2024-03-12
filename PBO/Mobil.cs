using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO
{
    class Mobil
    {
        public string nama;
        public string bahanBakar;
        public int kursi;

        public Mobil(string nama, string bahanBakar, int kursi)
        {
            this.nama = nama;
            this.bahanBakar = bahanBakar;
            this.kursi = kursi;
        }

        public void listDiskon()
        {
            Console.WriteLine("Berikut adalah mobil yang sedang diskon : ");
        }
    }

    class mobilSedan : Mobil 
    {
        public int kapasitasBagasi;

        public mobilSedan(string nama, string bahanBakar, int kursi, int kapasitasBagasi) : base(nama, bahanBakar, kursi)
        {
            this.kapasitasBagasi = kapasitasBagasi;
        }

        public void infoKendaraan()
        {
            listDiskon();
            Console.WriteLine($"nama : {nama}");
            Console.WriteLine($"bahan bakar : {bahanBakar}");
            Console.WriteLine($"kursi : {kursi}");
            Console.WriteLine($"kapasitas bagasi : {kapasitasBagasi} liter\n");
        }
    }
}
