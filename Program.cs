using System.Runtime.CompilerServices;
using System.Text;

using System.Text.Json.Serialization;

namespace Test
{
    class A
    {
       

        public static void Main(string[] args)
        {
            List<string> my_list = new List<string>() {
                "This is my Dog",
                "Name of my Dog is cocoa",
                "This is my Cat",
                "Name of the cat is KK"
                };
            // Creating LINQ Query
            // Using Method syntax
            var res = my_list.Where(a => a.Contains("Dog"));

            // Executing LINQ Query
            foreach (var q in res)
            {
                Console.WriteLine(q);
            }
            var res1 = from l in my_list
                       where l.Contains("my")
                       select l;

            // Executing LINQ Query
            foreach (var q in res1)
            {
                Console.WriteLine(q);
            }

            // Creating data
            IEnumerable<int> data = ((ParallelQuery<int>)ParallelEnumerable.Range(10, 20)).Where(i => i % 2 == 0).Select(value => value);

            // Condition for generating even numbers


            // Display even numbers
            foreach (int even in data)
            {
                Console.WriteLine(even);
            }
        }

    }


}