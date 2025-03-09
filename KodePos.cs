using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300050
{
    class KodePos
    {
        public int GetKodePos(string input)
        {
            string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

            for (int i = 0; i < kelurahan.Length; i++)
            {
                if (kelurahan[i] == input)
                {
                    return kodePos[i];
                }
            }
            return -1;
        }
    }
}
