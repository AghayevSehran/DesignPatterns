using System;

namespace OpenClosed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product apple = new Product("Apple", Color.Green, Size.Small);
            Product tree = new Product("Tree", Color.Green, Size.Large);
            Product house = new Product("House", Color.Blue, Size.Large);
            Product[] products = { apple, tree, house };
            ProductFilter pf = new ProductFilter();
            
            Console.WriteLine("Green products (old):");
            //Every time for creating new filter we have to change the ProductFilter class
             
            foreach (Product item in pf.FilterByColoe(products, Color.Green))
            {
                Console.WriteLine($" - {item.Name} is green");
            }

            //Open Closed Principle
            var bf =new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var item in bf.Filter(products,new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {item.Name} is green");
            }
            Console.ReadKey();
            
        }
    }
}
