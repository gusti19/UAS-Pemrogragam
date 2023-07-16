using System;

namespace Polymorpihsm
{
    // Definisi kelas turunan LaguPop yang mewarisi kelas Musik
    public class LaguPop : Musik
    {
        // Implementasi metode Mainkan() untuk lagu pop.
        public override void Mainkan()
        {
            Console.WriteLine($"Memainkan lagu pop: {Judul}");
            // Logika khusus untuk memainkan lagu pop...
        }
    }
}
