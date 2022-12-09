using BestPractices;
using BestPractices_Yieldreturn;
using System.Linq;
// See https://aka.ms/new-console-template for more information
Yield.DisplyNumbers();


StringConcatenate.UsingPlusOperator("Hello","World");
StringConcatenate.UsingConcatMethod("Hello", "World");
StringConcatenate.UsingFormatMethod("Hello", "World");
StringConcatenate.UsingInterpolation("Hello", "World");

Point p1 = new Point(10, 20);
p1.Display();

var list = new List<string> { "1", "2", "3" };
SelectVSSelectMany.Select(list);
SelectVSSelectMany.SelectMany(list);

var numbers = new List<List<int>>
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 }
};
SelectVSSelectMany.select_selectmany(numbers);
