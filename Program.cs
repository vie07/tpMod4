using System;

namespace TP_MODUL4_103022400147
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePos kode = new KodePos();

            //minta inputan nama kelurahan
            Console.Write("Masukkan kelurahan: ");
            string kel = Console.ReadLine();

            //manggil method getKodePos buat nyari kode pos
            int hasil = kode.getKodePos(kel);

            // mengecek apakah kode pos ditemukan
            if (hasil != -1)
            {
                Console.WriteLine("Kode Pos: " + hasil);
            }
            else
            {
                // jika tidak ditemukan
                Console.WriteLine("Kelurahan tidak ditemukan");
            }

            Console.WriteLine(); // spasi

            // simulasi DoorMachine
            DoorMachine pintu = new DoorMachine();

            pintu.BukaPintu();
            pintu.KunciPintu();
            pintu.BukaPintu();
        }
    }
}