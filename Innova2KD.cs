using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Definisi kelas Innova2KD sebagai kelas turunan (derived class) dari Mobil.
    public class Innova2KD : Mobil
    {
        // Konstruktor untuk mengatur merek dan model mobil Innova2KD.
        public Innova2KD()
        {
            Merek = "Toyota";
            Model = "Innova 2KD";
        }

        // Implementasi metode DisplayInfo() untuk menampilkan informasi spesifik tentang Innova2KD.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Innova 2KD adalah mobil MPV khas Indonesia dengan desain khas.");
        }
    }
}
