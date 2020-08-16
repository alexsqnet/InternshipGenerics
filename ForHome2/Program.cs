using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForHome2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 332 / 4.8;
            int n = 90;
            bool b = true;

            Show(d);
            Show(n);
            Show(b);

            Console.ReadLine();
        }

        static void Show(object input)
        {
            Console.WriteLine(input);
        }
    }
}
