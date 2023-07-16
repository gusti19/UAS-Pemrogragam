using System;

namespace Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Membuat objek kendaraan dari berbagai jenis
            Kendaraan mobil = new Mobil { Merk = "Toyota", Model = "Avanza", JumlahPintu = 4 };
            Kendaraan motor = new Motor { Merk = "Honda", Model = "CBR500R", Tipe = "Sport" };

            // Memanggil metode Info() pada setiap objek kendaraan
            mobil.Info();
            mobil.Start();

            Console.WriteLine();

            motor.Info();
            motor.Start();
            motor.Stop();
        }
    }

}
