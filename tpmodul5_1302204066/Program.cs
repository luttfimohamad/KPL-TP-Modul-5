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
            SayaTubeVideo v = new SayaTubeVideo("Tutorial Design By Contract – [Mohamad Lutfi]");

            v.IncreasePlayCount(13);
            v.PrintVideoDetails();

            v.IncreasePlayCount(20);
            v.PrintVideoDetails();

            v.IncreasePlayCount(1302204066);
            v.PrintVideoDetails();
            
            for (int i = 0; i < 218; i++)
            {
                v.IncreasePlayCount(10000000);
            }
            v.PrintVideoDetails();
        }
    }
}
