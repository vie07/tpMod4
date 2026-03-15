using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400147
{
    internal class DoorMachine
    {
        // kondisi awal pintu terkunci
        string state = "Terkunci";

        // fungsi untuk membuka pintu
        public void BukaPintu()
        {
            if (state == "Terkunci")
            {
                state = "Terbuka";
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        // fungsi untuk mengunci pintu
        public void KunciPintu()
        {
            if (state == "Terbuka")
            {
                state = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
