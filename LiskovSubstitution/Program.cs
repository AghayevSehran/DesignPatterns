using System;

namespace LiskovSubstitution
{
    internal class Program
    {
        public static int Area(Rectangle r)
        {
            return r.Height * r.Width;
        }

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
