using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declared variables
            String name, location;

            //The console will ask to the user the his name
            Console.WriteLine("My Name is");
            name = Console.ReadLine();
            Console.Clear();

            //The console will ask to the user the his location
            Console.WriteLine("My Location is");
            location = Console.ReadLine();
            Console.Clear();

            //Variable of the Christmas Date
            DateTime christmasDate = new DateTime(2020, 12, 25);
            
            //Variable of the current day
            DateTime thisDay = DateTime.Today;

            //Variable to assign the result of the calculation of the numbers of day  between today and christmas
            Double countDays = 0;
            
            //Calculation of the numbers the days between today and christams
            countDays = (christmasDate - thisDay).TotalDays;

            //Variable with the format using string polarization where all the variables are included
            String strIntr = $"My name is {name}, and from {location}. \nToday is {thisDay.ToShortDateString()}, and {countDays} days to go for Christmas!!!!";

            //Command to print in the console the final requested information
            Console.WriteLine(strIntr);

            /*Command to keep the console and avoid the application does  automatically
            terminate when launched from the Visual Studio run debugger tool*/
            Console.ReadKey();

        }
    }
}
