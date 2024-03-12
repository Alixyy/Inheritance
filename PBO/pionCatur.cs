using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO
{
    class pionCatur
    {
        public string nama;
        public int poin;

        public pionCatur(string nama, int poin) 
        {
            this.nama = nama;
            this.poin = poin;
        }

        public void penjelasan()
        {
            Console.WriteLine($"{nama} adalah salah satu buah catur yang memiliki poin {poin}");
        }
    }

    class Benteng : pionCatur 
    {
        public string posisiAwal;

        public Benteng(string nama, int poin, string posisiAwal) : base (nama, poin) 
        {
            this.posisiAwal = posisiAwal;
        }

        public void tempat()
        {
            penjelasan();
            Console.WriteLine($"Banteng memiliki posisi awal di {posisiAwal}\n");
        }
    }

    class Kuda : pionCatur 
    { 
        public string caraJalan;

        public Kuda(string nama, int poin, string caraJalan) : base (nama, poin)
        {
            this.caraJalan = caraJalan;
        }

        public void gerak()
        {
            penjelasan();
            Console.WriteLine($"Kuda memiliki cara gerak {caraJalan}\n");
        }
    
    }
}
