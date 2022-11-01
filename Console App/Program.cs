using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] x = new int[12];
            for (int i = 0; i < 12; i++)
            {
                x[i] = 0;
            }
            for (int i = 0; i < 954; i++)
            {
                x[rnd.Next(12)]++;
            }
            Array.Sort(x);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(x[i]);
            }
            //This is new change, just for a git test
        }
    }
}
