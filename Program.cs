using System;
using System.Collections.Generic;

namespace Deligates
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);
        

        static void Main(string[] args)
        {
            var p = new Person();
            var pp = IsChild(p);
            var dd = new Program();
            
            Person p1 = new Person() { Name = "ratan", Age = 56 };
            Person p2 = new Person() { Name = "kamlesh", Age = 70 };
            Person p3 = new Person() { Name = "rajesh", Age = 25 };
            Person p4 = new Person() { Name = "anup", Age = 17 };
            List<Person> list = new List<Person>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);


            //del += IsSenior;
            //del += IsAdult;

            //del.Invoke(p4);

            FilterDelegate del = new FilterDelegate(IsChild);
            Console.WriteLine("Children:");
            DisplayPeople(list, del);
            Console.WriteLine("Adults");
            DisplayPeople(list, new FilterDelegate(IsAdult));
            Console.WriteLine("Senior:");
            DisplayPeople(list, new FilterDelegate(IsSenior));



        }
        static bool IsChild(Person p)
        {
            Console.WriteLine("Executed isChild");
            bool isChild= p.Age < 18;
            return isChild;
        }

        static bool IsAdult(Person p)
        {
            //Console.WriteLine("Executed isAdult");
            return p.Age >= 18 && p.Age < 70;
        }

        static bool IsSenior(Person p)
        {
            Console.WriteLine("Executed isSenior");
            return p.Age >= 65;
        }
        static void DisplayPeople(List<Person> people, FilterDelegate filter)// isChild
        {

            foreach (Person p in people)
            {
              bool flag =filter(p) ;
                if (flag)
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            Console.Write("\n\n");
        }

    }
}
