using System;

namespace Polymorpihsm
{
    // Definisi kelas turunan LaguRock yang mewarisi kelas Musik
    public class LaguRock : Musik
    {
        // Implementasi metode Mainkan() untuk lagu rock.
        public override void Mainkan()
        {
            Console.WriteLine($"Memainkan lagu rock: {Judul}");
            // Logika khusus untuk memainkan lagu rock...
        }
    }
}
