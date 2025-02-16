using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCheckSing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(CheckSing(num));
        }
        static int CheckSing(int num)
        {
            if(num<0) return -1;
            if (num>0) return 1;  
            else return 0;
        }
    }
}
