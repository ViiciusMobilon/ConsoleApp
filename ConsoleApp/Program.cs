using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ;

            Console.WriteLine("Escreva um valor para b");
           int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva um valor para a");
            int a = int.Parse(Console.ReadLine());

            int c = b;
            b = a;
            a = c;

            Console.WriteLine("O valor de b é:" + b);
            Console.WriteLine("O valor de a é:" + a);
            Console.ReadKey();



        }
    }
}
