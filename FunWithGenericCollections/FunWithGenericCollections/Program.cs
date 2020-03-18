using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try out generic list
            UseGenericList();

            Console.WriteLine();

            // Try out generic queue
            UseGenericQueue();

            Console.WriteLine();

            // Try out sorted set
            UseSortedSet();

            Console.WriteLine();

            // Try out Dictionary
            UseDictionary();

            Console.ReadLine();
        }
    
        static void UseGenericList()
        {
            // Make a list of Person objects, filled with collection/object
            // init syntax
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 }
            };

            // Print out # of items in list
            Console.WriteLine($"Items in list: {people.Count}");

            // Enumerate over list
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            // Insert a new person
            Console.WriteLine("\n ->Inserting new person");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine($"Items in list: {people.Count}");

            // Copy data into new array.
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine($"First Names: {p.FirstName}");
            }
        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine($"{p.FirstName} got coffee!");
        }

        static void UseGenericQueue()
        {
            // Make a queue with 3 persons.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Peek at first in line.
            Console.WriteLine($"{peopleQ.Peek().FirstName} is first in line");

            // Remove each person from queue
            Console.WriteLine(peopleQ.Dequeue());
            Console.WriteLine(peopleQ.Dequeue());
            Console.WriteLine(peopleQ.Dequeue());

            // Try to de-Q again
            try
            {
                Console.WriteLine(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error! {e.Message}");
                
            }
        }

        static void UseSortedSet()
        {
            // Make some people with different ages
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 }
            };

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Add a few new people with various ages
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });

            foreach (Person p in setOfPeople)
            {
                Console.WriteLine(p);
            }
        }


        static void UseDictionary()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // GET Homer.
            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);

            // Use initialisation syntax
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                { "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
                { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
                { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
            };

            // GET Lisa.
            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);

            // populate with Dictionary initialisation syntax
            Dictionary<string, Person> peopleC = new Dictionary<string, Person>()
            {
                ["Homer"] = new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 },
                ["Marge"] = new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 },
                ["Lisa"] = new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }
            };
        }
    }
}
