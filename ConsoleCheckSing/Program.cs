using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCheckSing
{
    /*Проверка знака числа (положительное, отрицательное, ноль)
🔹 Структура:
Вход: одно целое число number.
Выход: 1, если число положительное, -1, если отрицательное, 0, если равно нулю.
🔹 Пример ввода и вывода:
ввод 
с клавиатуры
а вывод
1
 -1
0*/
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
