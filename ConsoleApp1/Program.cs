using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {// for т.к. можно задать параметры работы цикла
            int minValue = 5;
            int maxValue = 103;
            int numberStep = 7;

            for (int i = minValue; i <= maxValue; i += numberStep)
            {
                Console.WriteLine(i);
            }
        }
    }
}
