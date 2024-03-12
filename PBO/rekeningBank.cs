using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO
{
    class rekeningBank
    {
        public int noRek;
        public string namaBank;

        public rekeningBank(int noRek, string namaBank) 
        { 
            this.noRek = noRek;
            this.namaBank = namaBank;
        }
    }

    class bri : rekeningBank 
    {
        public double uangSetor;

        public bri(int noRek, string namaBank, double uangSetor) : base (noRek, namaBank) 
        { 
            this.uangSetor = uangSetor;
        }

        public void setorTunai()
        {
            Console.WriteLine($"Tecatat setor tunai dengan nomor rekening {noRek} pada bank {namaBank}, sebesar {uangSetor}" +
                $" rupiah\n");
        }
    }

    class mandiri : rekeningBank
    {
        public string eWallet;

        public mandiri(int noRek, string namaBank, string eWallet) : base (noRek, namaBank) 
        {
            this.eWallet = eWallet;
        }

        public void transaksi()
        {
            Console.WriteLine($"Telah terjadi transaksi ke {eWallet} dari bank {namaBank} dengan rekening {noRek}\n");
        }
    }
}
