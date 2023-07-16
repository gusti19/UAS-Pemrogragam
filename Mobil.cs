using System; // Definisi kelas Mobil sebagai kelas induk (base class) yang akan diwarisi oleh kelas turunan lainnya.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Mobil
    {
        // Properti untuk menyimpan merek, model, dan tahun mobil.
        public string Merek { get; set; }
        public string Model { get; set; }
        public int Tahun { get; set; }

        // Metode virtual untuk menampilkan informasi umum tentang mobil.
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Merek: {Merek}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Tahun: {Tahun}");
        }
    }

}
