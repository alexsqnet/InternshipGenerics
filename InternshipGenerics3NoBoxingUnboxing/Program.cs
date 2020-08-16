using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenerics3NoBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> obj = new List<int>();

            obj.Add(50);                //No boxing  
            
            int x = obj[0];             // No unboxing  
            
            foreach (int i in obj)
            {
                Console.WriteLine(i);   //No unboxing  
            }
        }
    }
}
