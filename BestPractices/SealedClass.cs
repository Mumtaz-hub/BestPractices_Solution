using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices
{
    public sealed class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public int Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
            return X + Y;
        }
    }

    // This will generate a compile-time error
    //class MyPoint : Point
    //{
    //    // Class members here
    //}
}

/*
 * A sealed class is a class that cannot be inherited from. This means that any class that derives 
 * from a sealed class will generate a compile-time error.
 * You can create instances of a sealed class just like any other class,
 * using the new keyword and passing the required constructor arguments
 * 
 * https://medium.com/bytehide/senior-c-developer-shows-5-tips-to-master-your-c-level-a03b2619358b
 *  using Sealed classes is much more appropriate is to restrict the inheritace feature.
 *  on a method or property that overrides a virtual method or property in a base class, we may also use the sealed keyword.
 *  This prevents other classes from overriding certain virtual methods or attributes while still enabling them to inherit from the base class.
 *  4 advantages of using sealed classes
 *   1.Best when we have a class with static members.
 *   2.Best when we have a class with a private constructor.
 *   3. Sealed classes are not allowed to be inherited.
 *   4. Can lead to improved performances
 */