using System;

namespace Abstraction
{
    // Definisi kelas turunan Motor yang mewarisi kelas Kendaraan
    public class Motor : Kendaraan
    {
        public string Tipe { get; set; }

        // Implementasi metode Info() untuk motor.
        public override void Info()
        {
            Console.WriteLine($"Motor {Merk} {Model} tipe {Tipe}.");
        }
    }
}
