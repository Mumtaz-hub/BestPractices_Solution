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

/* 
 * Select() is used to transform each element of a collection into a new form, by applying a transformation function to each element. 
 * For example, you could use Select() to take a collection of integers and transform it into a collection of strings by calling .ToString() on each element.

SelectMany() is used to flatten a collection of collections into a single, one-dimensional collection. This is useful when you have a collection of collections 
and you want to work with the individual elements of the nested collections as if they were all in a single collection. 
For example, you could use SelectMany() to take a collection of lists of strings and flatten it into a single collection of strings.

https://medium.com/bytehide/senior-c-developer-shows-5-tips-to-master-your-c-level-a03b2619358b
The client has requested all the technologies that your employees know.

In the code, we have a class Employee with the name of the employee and a list of technologies he knows how to work:

𝐜𝐥𝐚𝐬𝐬 𝐄𝐦𝐩𝐥𝐨𝐲𝐞𝐞
{
  𝐩𝐮𝐛𝐥𝐢𝐜 𝐬𝐭𝐫𝐢𝐧𝐠 𝐍𝐚𝐦𝐞 { 𝐠𝐞𝐭; 𝐬𝐞𝐭; }
  𝐩𝐮𝐛𝐥𝐢𝐜 𝐋𝐢𝐬𝐭<𝐬𝐭𝐫𝐢𝐧𝐠> 𝐒𝐤𝐢𝐥𝐥𝐬 { 𝐠𝐞𝐭; 𝐬𝐞𝐭; }
}

List<Employee> employees = new();
Employee emp1 = new Employee { Name = "Stefan", Skills = new List<string> {"C", "C++", "Java"}};
Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> {"SQL Server", "C#", "ASP.NET"}};
Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> {"C#", "ASP.NET MVC", "Windows Azure", "SQL Server"}};

employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);

𝐒𝐞𝐥𝐞𝐜𝐭():
IEnumerable<List<String>> resultSelect = employees.Select(e=> e.Skills);

foreach (List<String> skillList in resultSelect)
{
    foreach (string skill in skillList)
    {
        Console.WriteLine(skill);
    }
}

• We are using 2 𝐥𝐨𝐨𝐩𝐬. 
• The first loop goes through all the employees.
• The second loop goes through all the skills of each employee.

𝐒𝐞𝐥𝐞𝐜𝐭𝐌𝐚𝐧𝐲():

IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

foreach (string skill in resultSelectMany)
{
    Console.WriteLine(skill);
}
• We are getting the list of the skills immediately. 
• The first and only loop goes through the skills of each employee.

 * */