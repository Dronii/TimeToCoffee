using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Discount% or 0 if it isn't");

            decimal discount = Convert.ToDecimal(Console.ReadLine());

            Dictionary<string, decimal> coffee = new Dictionary<string, decimal>();

            coffee.Add("Americano", 50.00m - discount*0.01m);
            coffee.Add("Latte", 70.00m - discount * 0.01m);
            coffee.Add("Flat White", 60.00m - discount * 0.01m);
            coffee.Add("Espresso", 60.00m - discount * 0.01m);
            coffee.Add("Cappuccino", 80.00m - discount * 0.01m);
            coffee.Add("Mocha", 90.00m - discount * 0.01m);

            
            
            Console.WriteLine("Coffee: ");
            foreach (string s in coffee.Keys)
                Console.WriteLine(s + ": " + coffee[s]  );


            Console.WriteLine();
        }
    }
}
