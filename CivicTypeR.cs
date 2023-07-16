using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Definisi kelas CivicTypeR sebagai kelas turunan (derived class) dari Mobil.
    public class CivicTypeR : Mobil
    {
        // Konstruktor untuk mengatur merek dan model mobil CivicTypeR.
        public CivicTypeR()
        {
            Merek = "Honda";
            Model = "Civic Type R";
        }

        // Implementasi metode DisplayInfo() untuk menampilkan informasi spesifik tentang CivicTypeR.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Civic Type R adalah mobil sport andalan Honda.");
        }
    }
}
