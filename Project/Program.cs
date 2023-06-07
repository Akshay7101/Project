using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Books
    {
        public void Calles()
        {
            Console.WriteLine("This is New Branch create");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {


            int S = 10 + 20;

            Console.WriteLine(S);


            Console.WriteLine("additon---" + Addition(100, 100));
            Console.WriteLine("additon---" + Subtraction(100, 50));
            Console.ReadLine();

        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a + b;
        }





    }



    
}
