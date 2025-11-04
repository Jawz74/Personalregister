
//C# Övning 1 - Personalregister

//Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
//personalregister. De har endast två krav:

//1.Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
//i konsolen, inget krav på persistent lagring)
//2.Programmet skall kunna skriva ut registret i en konsol.

//Uppgift 1 - Vilka klasser bör ingå i programmet?
//Uppgift 2 - Vilka attribut och metoder bör ingå i dessa klasser?
//Uppgift 3 - Skriv programmet





using System.Runtime.CompilerServices;

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            
            List<Employee> employeeList = new List<Employee>();

            const decimal minSalarySEK = 100, maxSalarySEK = 100_000;
            const bool capsLettersOnly = true;

            Console.WriteLine("*** Lägg till anställda i personalregistret ***");

            do
            {
                employee = new Employee();

                Console.Write("\n--------------------------------------------------");

                employee.FirstName = Helpers.ReadStringInput("\nAnge förnamn: ", "Du har angett ett felaktigt namnformat, försök igen!", capsLettersOnly);

                employee.LastName = Helpers.ReadStringInput("\nAnge efternamn: ", "Du har angett ett felaktigt namnformat, försök igen!", capsLettersOnly);

                employee.Salary = Helpers.ReadDecimalInput("\nAnge lön (100-100 000 SEK): ", minSalarySEK, maxSalarySEK, "Du har angett ett felaktigt belopp, försök igen!");

                employeeList.Add(employee);

                Console.Write("\nVill du mata in en till? (J/N): ");

            } while (Console.ReadLine()?.ToUpper() == "J");

            Console.WriteLine("\n----------- Personalregister (Namn, Lön) -----------\n");
            StaffManager.PrintEmployeeList(employeeList);
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Programmet avslutas!");
        }
    }

    
}







