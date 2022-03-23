using System;
using System.Collections.Generic;
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
        }

        public void IncreasePlayCount (int playCount)
        {
            this.playCount = playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Song ID\t\t: " + this.id);
            Console.WriteLine("Song Title\t: " + this.title);
            Console.WriteLine("Playcount\t: " + this.playCount);
        }
    }
}
