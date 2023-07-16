using System;

namespace Polymorpihsm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Membuat objek lagu dari berbagai jenis musik
            Musik lagu1 = new LaguPop { Judul = "Perfect" };
            Musik lagu2 = new LaguRock { Judul = "Sweet Child O' Mine" };
            Musik lagu3 = new LaguKlasik { Judul = "Canon in D" };

            // Memainkan lagu-lagu tersebut menggunakan polymorphism
            MainkanLagu(lagu1);
            MainkanLagu(lagu2);
            MainkanLagu(lagu3);
        }

        // Metode untuk memainkan lagu dengan memanfaatkan polymorphism
        public static void MainkanLagu(Musik lagu)
        {
            lagu.Mainkan(); // Panggil metode Mainkan() tanpa peduli tipe spesifiknya.
        }
    }
}

