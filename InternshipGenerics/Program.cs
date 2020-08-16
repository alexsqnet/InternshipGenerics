using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //boxing
            list.Add(2);
            list.Add(3);
            list.Add(4);

            var result = Sum(list);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Sum(ArrayList numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                //unboxing
                sum += (int)numbers[i];
            }

            return sum;
        }
    }
}
