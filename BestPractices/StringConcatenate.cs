using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string s5 = string.Format("{0} {1}", s1, s2);
            Console.WriteLine("Format() method : s5: {0}", s5);
            //Console.WriteLine("Format() method : s5: {0}", System.Runtime.InteropServices.Marshal.SizeOf(s5));
            return s5;

        }
        public static string UsingInterpolation(string s1, string s2)
        {
            // stringInterpolation
            string s6 = $"{s1} {s2}";
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
            sb.AppendFormat("{0} {1}", s1, s2);
            Console.WriteLine("string builder: {0}", sb.ToString());

            //Console.WriteLine("string builder: {0}", System.Runtime.InteropServices.Marshal.SizeOf(sb));
            return sb.ToString();
        }
    }
}
