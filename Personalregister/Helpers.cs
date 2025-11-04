using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    public class Helpers
    {
        public static decimal ReadDecimalInput(string prompt, decimal min, decimal max, string errorMessage)
        {
            decimal value;
            while (true)  //Evighetsloop tills inmatat värde är korrekt
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                    return value;
                Console.WriteLine(errorMessage);
            }
        }

        public static string ReadStringInput(string prompt, string errorMessage, bool toUpperCase)
        {
            string? value; // Nullable sträng, dvs kan vara tom
            while (true)  //Evighetsloop tills inmatat värde är korrekt
            {
                Console.Write(prompt);
                value = Console.ReadLine()?.Trim();

                if ((!string.IsNullOrEmpty(value)) && value.All(char.IsLetter))
                    return toUpperCase ? value.ToUpper() : value;
                Console.WriteLine(errorMessage);
            }
        }
    }
}
