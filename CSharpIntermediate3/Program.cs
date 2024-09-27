using System.Diagnostics.Tracing;

namespace CSharpIntermediate3
{
    class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class People
    {
        private Dictionary<int, string> _people = new Dictionary<int, string>();
        public People()
        {
            _people = new Dictionary<int, string>();
        }
        public void AddPerson(Person person)
        {
            _people.Add(person.Id, person.Name);
        }
        public string GetPersonById(int id)
        {
            foreach (var person in _people)
            {
                if (person.Key == id)
                {
                    return person.Value;
                }
            }
            return null;
        }
        public void DisplayPeople()
        {
            foreach (var person in _people)
            {
                Console.WriteLine("{0} - {1}", person.Key, person.Value);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ////\\//\\ PART ONE //\\//\\
            //Dictionary<string, string> words = new Dictionary<string, string>();
            //while (true)
            //{
            //    Console.WriteLine("------------------");
            //    Console.WriteLine("Add <word>");
            //    Console.WriteLine("Define <word>");
            //    Console.WriteLine("------------------");

            //    var input = Console.ReadLine();
            //    var parts = input.Split(" ");

            //    if (parts.Length != 2)
            //        continue;

            //    if (parts[0] == "add")
            //    {
            //        Console.Write("Define {0}: ", parts[1]);
            //        var definition = Console.ReadLine();
            //        words.Add(parts[1], definition);
            //    }
            //    else if (parts[0] == "define")
            //    {
            //        string definition;
            //        if (!words.TryGetValue(parts[1], out definition))
            //        {
            //            Console.WriteLine("I don't know what a {0} is", parts[1]);
            //            continue;
            //        }
            //        Console.WriteLine("{0} = {1}", parts[1], words[parts[1]]);
            //    }
            //}
            ////\\//\\ PART ONE //\\//\\

            //\\//\\ PART TWO //\\//\\
            People people = new People();
            people.AddPerson(new Person(1, "John Doe"));
            people.AddPerson(new Person(2, "Jane Smith"));

            people.DisplayPeople();

            string personName = people.GetPersonById(1);
            if (personName != null)
            {
                Console.WriteLine("Found: " + personName);
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
            //\\//\\ PART TWO //\\//\\


            Console.ReadKey();
        }
    }
}
