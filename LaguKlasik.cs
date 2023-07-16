using System;

namespace Polymorpihsm
{
    // Definisi kelas turunan LaguKlasik yang mewarisi kelas Musik
    public class LaguKlasik : Musik
    {
        // Implementasi metode Mainkan() untuk lagu klasik.
        public override void Mainkan()
        {
            Console.WriteLine($"Memainkan lagu klasik: {Judul}");
            // Logika khusus untuk memainkan lagu klasik...
        }
    }
}
