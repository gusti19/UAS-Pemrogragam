using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Definisi kelas LandCruiserVX80 sebagai kelas turunan (derived class) dari Mobil.
    public class LandCruiserVX80 : Mobil
    {
        // Konstruktor untuk mengatur merek dan model mobil LandCruiserVX80.
        public LandCruiserVX80()
        {
            Merek = "Toyota";
            Model = "LandCruiser VX80";
        }

        // Implementasi metode DisplayInfo() untuk menampilkan informasi spesifik tentang LandCruiserVX80.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("LandCruiser VX80 adalah mobil SUV legendaris dari Toyota.");
        }
    }
}
