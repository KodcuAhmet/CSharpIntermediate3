using System.Diagnostics.Tracing;

namespace CSharpIntermediate3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Add <word>");
                Console.WriteLine("Define <word>");
                Console.WriteLine("------------------");

                var input = Console.ReadLine();
                var parts = input.Split(" ");

                if (parts.Length != 2)
                    continue;

                if (parts[0] == "add")
                {
                    Console.Write("Define {0}: ", parts[1]);
                    var definition = Console.ReadLine();
                    words.Add(parts[1], definition);
                }
                else if (parts[0] == "define")
                {
                    string definition;
                    if (!words.TryGetValue(parts[1], out definition))
                    {
                        Console.WriteLine("I don't know what a {0} is", parts[1]);
                    }
                    Console.WriteLine("{0} = {1}", parts[1], words[parts[1]]);
                }
            }
        }
    }
}
