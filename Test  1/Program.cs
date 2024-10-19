using System.Collections.Generic;
using System.Security.Claims;
using System;
namespace Test__1
{
    
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
    public class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string name = " ";
            foreach (var i in person)
            {
                name += i.Name + " " + i.Address + " ";
            }
            return name;
        }
        public double Average(IList<Person> person)
        {
            double avg = 0;
            double count = 0;
            foreach (var i in person)
            {
                avg += i.Age;
                count++;

            }
            return avg / count;
        }
        public int Max(IList<Person> person)
        {
            int max = 0;
            foreach (var i in person)
            {
                if (max < i.Age)
                {
                    max = i.Age;

                }
            }
            return max;

        }
    }
    class Test
    {
        static void Main(String[] args)
        {
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });
            PersonImplementation pimp = new PersonImplementation();
            Console.WriteLine(pimp.GetName(p));
            Console.WriteLine(pimp.Average(p));
            Console.WriteLine(pimp.Max(p));
        }
    }
}

