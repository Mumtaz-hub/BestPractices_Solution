using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices
{
    public static class SelectVSSelectMany
    {
        public static List<string> Select(List<string> list)
        {
            
            var result = list.Select(x => x + "a");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            return result.ToList();
        }

        public static string SelectMany(List<string> list)
        {
            var result = list.SelectMany(x => x + "a");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            return new string(result.ToArray()); ;
        }
        
        public static List<int> select_selectmany(List<List<int>> numbers)
        {
            

            // Use SelectMany() to flatten the collection of lists into a single, one-dimensional collection.
            var flattenedNumbers = numbers.SelectMany(list => list);

            // Use Select() to transform each element in the flattened collection.
            var squaredNumbers = flattenedNumbers.Select(n => n * n);

            // Output the results.
            foreach (var n in squaredNumbers)
            {
                Console.WriteLine(n);
            }

            return squaredNumbers.ToList();


        }

    }
}
