using System;

namespace Abstraction
{
    // Definisi kelas abstrak Kendaraan
    public abstract class Kendaraan
    {
        public string Merk { get; set; }
        public string Model { get; set; }

        // Metode abstrak Info() yang akan diimplementasikan oleh kelas turunannya.
        public abstract void Info();

        // Metode Start() untuk memulai kendaraan.
        public void Start()
        {
            Console.WriteLine($"{Merk} {Model} telah dinyalakan.");
        }

        // Metode Stop() untuk menghentikan kendaraan.
        public void Stop()
        {
            Console.WriteLine($"{Merk} {Model} telah dimatikan.");
        }
    }
}
