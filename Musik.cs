using System;

namespace Polymorpihsm
{
    // Definisi kelas abstrak Musik
    public abstract class Musik
    {
        // Properti untuk menyimpan judul lagu.
        public string Judul { get; set; }

        // Metode abstrak Mainkan() yang akan diimplementasikan oleh kelas turunannya.
        public abstract void Mainkan();
    }
}
