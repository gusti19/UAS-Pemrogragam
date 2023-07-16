using System;

namespace Inheritance
{
    // File utama yang berisi metode Main untuk menjalankan program.
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Menentukan tahun masing-masing mobil.
            int tahunCivicTypeR = 2022;
            int tahunLandCruiserVX80 = 2021;
            int tahunInnova2KD = 2023;

            // Membuat objek dari masing-masing kelas mobil dan mengatur tahunnya.
            CivicTypeR civicTypeR = new CivicTypeR { Tahun = tahunCivicTypeR };
            LandCruiserVX80 landCruiserVX80 = new LandCruiserVX80 { Tahun = tahunLandCruiserVX80 };
            Innova2KD innova2KD = new Innova2KD { Tahun = tahunInnova2KD };

            // Menampilkan informasi tentang setiap mobil.
            Console.WriteLine("Informasi Civic Type R:");
            civicTypeR.DisplayInfo();

            Console.WriteLine("\nInformasi LandCruiser VX80:");
            landCruiserVX80.DisplayInfo();

            Console.WriteLine("\nInformasi Innova 2KD:");
            innova2KD.DisplayInfo();
        }
    }


}
