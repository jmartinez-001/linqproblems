using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            ////var wordlist = words;
            //var wordsWithTH = words.Where(w => w.Contains("th"));
            //foreach (var w in wordsWithTH)
            //{
            //    Console.WriteLine(w);

            //}

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var noDuplicates = names.Distinct().ToList();
            //foreach (string value in noDuplicates)
            //{
            //    Console.WriteLine(value);

            //}


            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"
            };
            //split each string object at commas
            //parse int the numbers
            //convert to list of arrays
            //order by ascending or descending
            //remove first or last number in each array
            //get average of each array, to get average of all arrays
            //return 86.125
            //

            var classAverage = classGrades.Select(g => (Array.ConvertAll(g.Split(','),int.Parse)));
            var CurvedGPA = classAverage.Select(g => g.Where(a => g.Min() != a).Average()).Average();
            Console.WriteLine(CurvedGPA);
        }
    }
}
