using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BestPractices
{
    public static class StringConcatenate
    {

        public static string UsingPlusOperator(string s1, string s2)
        {
            // optimize memory and performance
            // stringConcatenate
            string s3 = s1 + s2;


            // Check memory optimization
            Console.WriteLine("Memory optimization for string concatenation");

            Console.WriteLine("s1: {0}", s1);
            Console.WriteLine("s2: {0}", s2);
            Console.WriteLine("+ operator conatenate s3: {0}", s3);

            //Console.WriteLine("s1: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s1));
            //Console.WriteLine("s2: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s2));
            //Console.WriteLine("+ operator conatenate s3: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s3));

            return s3;
            
        }

        public static string UsingConcatMethod(string s1, string s2)
        {
            string s4 = string.Concat(s1, s2);
            Console.WriteLine("string.Concat() method s4: {0}", s4);
            //Console.WriteLine("string.Concat() method s4: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s4));
            return s4;

        }
        public static string UsingFormatMethod(string s1, string s2)
        {
            // stringFormat
            string s5 = string.Format("{0}{1}", s1, s2);
            Console.WriteLine("Format() method : s5: {0}", s5);
            //Console.WriteLine("Format() method : s5: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s5));
            return s5;

        }
        public static string UsingInterpolation(string s1, string s2)
        {
            // stringInterpolation
            string s6 = $"{s1}{s2}";
            Console.WriteLine("stringInterpolation s6: {0}", s6);
            //Console.WriteLine("stringInterpolation s6: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s6));
            return s6;
        }

        public static string UsingStringBuilder(string s1, string s2)
        {
            // stringConcatenate using stringbuilder
            StringBuilder sb = new StringBuilder();
            sb.Append(s1);
            sb.Append(s2);
            Console.WriteLine(sb.ToString());
            // stringConcatenate using stringbuilder and string.format
            sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", s1, s2);
            Console.WriteLine("string builder: {0}", sb.ToString());

            //Console.WriteLine("string builder: {0}", System.Runtime.InteropServices.Marshal.SizeOf(sb));
            return sb.ToString();
        }
    }
}

/*
 * https://medium.com/bytehide/senior-c-developer-shows-5-tips-to-master-your-c-level-a03b2619358b
 * 
Don’t use ‘+’ string concatenation in a loop This is because a string is immutable
We have a new “Test” string — This string will take up memory space on the Heap
We change the original string to “Test for string. We will create a new string object on the Heap.
Instead of modifying the original string at the same memory address.

string finalStr = "";
foreach (var str in stringArray)
{
    finalStr = finalStr + str;
}
If you are curious to know what happens when you do it this way, the main thing is the possible loss of performance.

Why? Because multiple memory allocations would be used when modifying a string multiple times.

“The 'StringBuilder' doesn’t create a new object in the memory but dynamically expands memory to accommodate the modified string."

StringBuilder builder = new StringBuilder();
foreach( var str in stringArray)
{
    builder.Append(str);
}

string finalStr= builder.ToString();


*/