using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            uint N = Convert.ToUInt32(Console.ReadLine());
            uint N2;
            for (uint i = 0; i <= N; i++)

            {

                Console.WriteLine("Квадрат числа {0} равен {1}", i , N2 = i * i);
            }
            
           
            Console.ReadKey();
        }
    }
}
