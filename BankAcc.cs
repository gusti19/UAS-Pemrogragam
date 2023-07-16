using System;

public class AkunBank
{
    private string noRek; // Variabel untuk menyimpan nomor rekening.
    private string pin; // Variabel untuk menyimpan PIN (Personal Identification Number) akun.
    private decimal saldo; // Variabel untuk menyimpan saldo akun.

    public string NoRek
    {
        get { return noRek; } // Getter untuk mendapatkan nomor rekening.
        set { noRek = value; } // Setter untuk mengatur nomor rekening.
    }

    public string Pin
    {
        get { return pin; } // Getter untuk mendapatkan PIN.
        set { pin = value; } // Setter untuk mengatur PIN.
    }

    public decimal Saldo
    {
        get { return saldo; } // Getter untuk mendapatkan saldo akun.
        set { saldo = value; } // Setter untuk mengatur saldo akun.
    }

    public void Setor(decimal jumlah)
    {
        saldo += jumlah; // Metode untuk melakukan setor uang ke akun (menambahkan jumlah ke saldo).
    }

    public void Tarik(decimal jumlah)
    {
        if (jumlah <= saldo)
        {
            saldo -= jumlah; // Metode untuk melakukan penarikan uang dari akun (mengurangkan jumlah dari saldo).
        }
        else
        {
            Console.WriteLine("Saldo Tidak Cukup!"); // Pesan yang akan ditampilkan jika saldo tidak mencukupi untuk melakukan penarikan.
        }
    }

    public void TampilSaldo()
    {
        Console.WriteLine("No. Rekening: " + noRek); // Metode untuk menampilkan nomor rekening.
        Console.WriteLine("Saldo: Rp" + saldo); // Metode untuk menampilkan saldo akun.
    }
}
