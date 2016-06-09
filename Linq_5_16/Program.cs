using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_5_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person {FirstName= "John", LastName = "Doe", Age = 25 }
            };

            //var is an implicit type. when its initialized, the complier know which type of variable it should be

            var result = from p in people
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine("{1}, {0}", item.FirstName, item.LastName);
            }

            Console.ReadKey();
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
