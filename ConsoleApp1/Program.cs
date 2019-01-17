using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("hELLO WORLD");
            var red = new Blue("Roy", 17);
            //how to construct objects??
            //a constructor is a special method that constructs the objects.
            Console.WriteLine(red.addSum());
            Console.ReadLine();
        }
    }
    class Blue
    {
        public Blue()
        {
            Console.WriteLine("ghj");
        }
        public Blue(string a, int b)
        {
            Console.WriteLine("{0}  {1}", a, b);
        }
        public int addSum()
        {
            int i;
            int sum = 0;
            for (i = 618; i >= 211; i -= 18)
            {
                sum += i;
                // Console.WriteLine("su is " + sum);
                //  Console.ReadLine();
            }
            return sum;
        }
    }