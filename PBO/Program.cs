using PBO;

class Program
{
    public static void Main(string[] args)
    {
        mobilSedan honda = new mobilSedan("Honda City", "Bensin", 5, 519);
        honda.infoKendaraan();

        Tuna tuna = new Tuna("Tuna", "Skombride", "Layak Dikonsumsi", "Insang");
        tuna.caraKonsumsi();

        Benteng benteng = new Benteng("Benteng", 5, "a1, h1, a8 dan h8");
        benteng.tempat();

        Kuda kuda = new Kuda("Kuda", 3, "Seperti huruf L");
        kuda.gerak();

        bri setor = new bri(00567, "BRI", 50.000);
        setor.setorTunai();

        mandiri transaksi = new mandiri(00782, "Mandiri", "OVO");
        transaksi.transaksi();

        sedan mobil = new sedan(4, "Bensin", "Honda", "Sedan", 519, 5);
        mobil.print();

        truk Truk = new truk(4, "Bensin", "Toyota", "Truk", "Baik", 4009);
        Truk.print();

        sepedaMotor motor = new sepedaMotor(2, "Bensin", "Honda Beat", "Sepeda Motor", "Matic", "Merah");
        motor.print();
    }
}