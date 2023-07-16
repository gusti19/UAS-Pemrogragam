using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Selamat Datang di ATM BANK AMIKOM UNGU ====="); // Sambutan di awal program

        // Membuat objek AkunBank
        AkunBank akun = new AkunBank();
        akun.NoRek = "6975851919";
        akun.Pin = "340410";
        akun.Saldo = 50000;

        // Proses login
        bool isLoggedIn = Login(akun);

        if (isLoggedIn)
        {
            // Jika berhasil login, tampilkan menu
            Console.WriteLine("Login berhasil!");

            // Membersihkan output sebelum menampilkan menu transaksi
            Console.Clear();

            Menu(akun);
        }
        else
        {
            Console.WriteLine("Login gagal!"); // Tampil teks login gagal jika salah no.Rek & PIN
        }
    }


    public static bool Login(AkunBank akun) //Metode untuk meminta user untuk input No.Rek dan PIN
    {
        Console.WriteLine("Silakan masukkan nomor rekening: ");
        string inputRek = Console.ReadLine();
        Console.WriteLine("Masukkan PIN: ");
        string inputPin = Console.ReadLine();

        if (inputRek == akun.NoRek && inputPin == akun.Pin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Metode untuk menampilkan menu transaksi dan mengelola pilihan pengguna.
    // Parameter akun adalah objek AkunBank yang digunakan untuk melakukan transaksi.
    public static void Menu(AkunBank akun) 
    {
        // Variabel isExit digunakan untuk mengontrol perulangan while.
        // Jika isExit bernilai false, perulangan akan terus berjalan, dan program akan tetap menampilkan menu.
        bool isExit = false; 

        while (!isExit)
        {
            Console.WriteLine("===== Menu Transaksi =====");
            Console.WriteLine("1. Tarik");
            Console.WriteLine("2. Setor");
            Console.WriteLine("3. Tampil Saldo");
            Console.WriteLine("4. Keluar");

            Console.WriteLine("Pilih menu [1..4]: ");
            string menuInput = Console.ReadLine();

            switch (menuInput) // Control structure untuk pilihan menu
            {
                case "1":
                    Console.WriteLine("Masukkan jumlah penarikan: ");
                    decimal jumlahTarik = Convert.ToDecimal(Console.ReadLine());
                    akun.Tarik(jumlahTarik);

                    Console.WriteLine("Transaksi berhasil!");
                    break;
                case "2":
                    Console.WriteLine("Masukkan jumlah setoran: ");
                    decimal jumlahSetor = Convert.ToDecimal(Console.ReadLine());
                    akun.Setor(jumlahSetor);

                    Console.WriteLine("Transaksi berhasil!");
                    break;
                case "3":
                    akun.TampilSaldo();
                    break;
                case "4":
                    isExit = true;
                    break;
                default:
                    Console.WriteLine("Menu tidak valid!");
                    break;
            }

            // Tunggu pengguna menekan tombol Enter atau tombol lain sebelum kembali ke menu utama
            Console.WriteLine("\nTekan Enter untuk kembali ke Menu Utama...");
            Console.ReadLine();

            // Bersihkan output sebelum menampilkan menu transaksi lagi
            Console.Clear();
        }

        Console.WriteLine("Terima kasih telah menggunakan layanan kami!");
    }


}
