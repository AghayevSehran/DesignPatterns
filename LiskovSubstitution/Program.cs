using System;

namespace LiskovSubstitution
{
    internal class Program
    {
        public static int Area(Rectangle r)
        {
            return r.Height * r.Width;
        }
        //Let q(x) be a property provable about objects of x of type T. Then q(y)
        //should be provable for objects y of type S where S is a subtype of T.
        private static void Main(string[] args)
        {

            Rectangle rec = new Rectangle();
            rec.Width = 6;
            rec.Height = 10;

                
            Console.WriteLine($"{rec} has a area {Area(rec)}");

            Square sqr = new Square
            {
                Width = 4
            };
            Console.WriteLine($"{sqr} has a area {Area(sqr)}");

            Rectangle sq = new Square
            {
                Width = 4
            };
            Console.WriteLine($"{sq} has a area {Area(sq)}");
            Console.ReadLine();
        }
    }
}
