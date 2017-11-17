using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6versioon
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("-------------------------------------------");

            double total = 0;

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();

                
                double value = double.Parse(input);

               

                if (value == -1)
                    break;

                total = total + value;

            }

            double gratuity = total * 0.15;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Subtotal: €{total}");   
            Console.WriteLine($"15.00 % Gratuity: €{total * 0.15}");
            Console.WriteLine($"Total: €{total - gratuity}");

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
