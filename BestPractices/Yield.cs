using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices_Yieldreturn
{
    public static class Yield
    {
        public static void DisplyNumbers()
        {
            foreach (int number in GenerateNumbers())
            {
                Console.WriteLine(number);
            }
        }

        public static IEnumerable<int> GenerateNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

    }

}

/*c# BestPractice
 * Use yield whenever you can:
https://www.linkedin.com/posts/djokic-stefan_dotnet-dotnetdeveloper-softwareengineer-activity-6986260323167023104-nhCH/?utm_source=share&utm_medium=member_desktop
developers usually use temporary variables to store collection elements when using loops to create a new collection of elements.

List<int> tempResult = new();
foreach(var item in collection)
{
    tempResult.Add(item);
}
return tempResult;

using yield return as it will provide a statefull and custom iteration:
“Control is returned to the caller each time the “yield return” statement is encountered and executed.”
“Most importantly, with each such call, the callee’s state information is preserved 
so that execution can continue immediately after the yield statement when the control returns.”

foreach(var item in collection)
{
    yield return item;
}

We cannot use the “yield return” or the “yield break” statements inside anonymous & unsafe methods
- The return type of the method where we are using yield, should be IEnumerable or IEnumerator.
- We cannot use the yield return statement in a try-catch block though we can have it inside a try-finally block


The yield return keyword is used in the GenerateNumbers method to return each element in the sequence one at a time.
When the foreach loop in the Main method iterates over the GenerateNumbers method, 
the yield return keyword causes the method to return the next element in the sequence each time it is called. 
This allows the method to generate a sequence of values without having to store the entire sequence in memory at once.

 */