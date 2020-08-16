using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenericsTypeSafety
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not type safety
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Child());
            arrayList.Add(new Man());
            arrayList.Add(33);
            arrayList.Add("Hello");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            //Type safety
            List<Man> list = new List<Man>();
            list.Add(new Man());

            //list.Add(new Child());  //compiler error  
            //list.Add(4);            //compiler error  
        }
    }

    class Child
    { 
    }

    class Man
    {
        public void GoToWork()
        { 
        }
    }
}
