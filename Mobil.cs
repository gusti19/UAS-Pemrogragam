using System;

namespace Abstraction
{
    // Definisi kelas turunan Mobil yang mewarisi kelas Kendaraan
    public class Mobil : Kendaraan
    {
        public int JumlahPintu { get; set; }

        // Implementasi metode Info() untuk mobil.
        public override void Info()
        {
            Console.WriteLine($"Mobil {Merk} {Model} dengan {JumlahPintu} pintu.");
        }
    }

}
