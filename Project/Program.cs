using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int S = 10 + 20;

            Console.WriteLine(S);


            Console.WriteLine("additon---"+Addition(100,100));

            Console.ReadLine();

        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
