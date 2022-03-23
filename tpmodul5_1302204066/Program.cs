using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat instance class
            SayaTubeVideo videoSaya = new SayaTubeVideo("Tutorial Design By Contract – [Mohamad Lutfi]");
            videoSaya.IncreasePlayCount(1302204066);
            videoSaya.PrintVideoDetails();
        }
    }
}
