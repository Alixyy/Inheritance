using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO
{
    class Ikan
    {
        public string nama;
        public string famili;

        public Ikan(string nama, string famili) 
        { 
            this.nama = nama;
            this.famili = famili;
        }

        public void berenang()
        {
            Console.WriteLine($"Ikan {nama} terlihat sedang berenang sebelum dimasak");
        }
    }

    class Tuna : Ikan
    {
        public string statusKonsumsi;
        public string caraBernapas;

        public Tuna(string nama, string famili , string statusKonsumsi, string caraBernapas) : base( nama, famili)
        {
            this.statusKonsumsi = statusKonsumsi;
            this.caraBernapas = caraBernapas;
        }
        

        public void caraKonsumsi()
        {
            berenang();
            Console.WriteLine($"Ikan {nama} dengan famili {famili} adalah ikan yang bernapas dengan {caraBernapas} " +
                $"yang memiliki status konsumsi {statusKonsumsi} " +
                $"yang dapat dikonsumsi dengan cara digoreng maupun diolah dengan cara lain\n");
        }
    }
}
