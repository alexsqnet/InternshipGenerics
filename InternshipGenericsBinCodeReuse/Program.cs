using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenericsBinCodeReuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat() { Name = "Tom"};
            Dog dog = new Dog() { Name = "Buddy" };

            Show<Cat>(cat);
            Show<Dog>(dog);
        }

        static void Show<T>(T animal) where T : Animal
        {
            Console.WriteLine(animal.Name);
        }
    }

    abstract class Animal { public string Name { get; set; }}

    class Cat : Animal {}

    class Dog : Animal {}
}
