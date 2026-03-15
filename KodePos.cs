using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400147
{
    internal class KodePos
    {
        //array nyimpen nama kelurahan
        string[] kelurahan =
        {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari",
            "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        //array nyimpen kode pos yang ber urutan sesuai kelurahan
        int[] kodepos =
        {
            40266, 40287, 40267, 40256, 40287, 40286, 40286,
            40286, 40272, 40274
        };

        //method nyari kode pos dari nama kelurahan
        public int getKodePos(string inputKelurahan)
        {
            //perulangan untuk cek nama kelurahan 
            for (int i = 0; i < kelurahan.Length; i++)
            {
                //jika nama kelurahan sama kayak inputan nama kelurahan 
                if (kelurahan[i] == inputKelurahan)
                {
                    //ngembaliin kode pos yang urutanny sama
                    return kodepos[i];
                }
            }
            //klo inputannya gada return -1
            return -1;
        }
    }
}
