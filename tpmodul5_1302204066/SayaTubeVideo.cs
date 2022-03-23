using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204066
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo (string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
            this.title = title;
            
            Contract.Requires(title != null);
            Contract.Requires(title.Length < 100);
        }

        public void IncreasePlayCount (int playCount)
        {
            int temp = this.playCount;
            try
            {
                if (playCount > 10000000) return;
                temp = checked (playCount + temp);
                this.playCount = temp;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("WARNING: Angka play count yang anda masukkan melebihi batas maksimal");
            }
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Song ID\t\t: "  + id);
            Console.WriteLine("Song Title\t: " + title);
            Console.WriteLine("Playcount\t: "  + playCount + "\n");
        }
    }
}
