using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void GettingNameandLocation()
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

            //Variable with the format using string polarization where all the variables are included
            String strIntr = $"My name is {name}, and from {location}.";

            //Command to print in the console the final requested information
            Console.WriteLine(strIntr);

        }

        static void GettingChristmasDay()
        {
            //Variable of the Christmas Date
            DateTime christmasDate = new DateTime(2020, 12, 25);

            //Variable of the current day
            DateTime thisDay = DateTime.Today;

            //Variable to assign the result of the calculation of the numbers of day  between today and christmas
            Double countDays = 0;

            //Calculation of the numbers the days between today and christams
            countDays = (christmasDate - thisDay).TotalDays;

            //Variable with the format using string polarization where all the variables are included
            String strIntr1 = $"Today is {thisDay.ToShortDateString()}, and {countDays} days to go for Christmas!!!!";

            //Command to print in the console the final requested information
            Console.WriteLine(strIntr1);
        }

        static void GlazerCalc()
        {
            //Declared variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            
            //Command to ask for the width information to the user
            Console.WriteLine("Enter the width in meter");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //Command to ask for the height information to the user
            Console.WriteLine("Enter the height in meter");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //Caculation method to get the wood lenght in foot, and glass area in meters
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //Command to write the results of the calculation in the terminal
            Console.WriteLine($"The length of the wood is {woodLength} feet");
            //Console.WriteLine("\n");
            Console.WriteLine($"The area of the glass is {glassArea} square meter");

        }

        static void Main(string[] args)
        {
            GettingNameandLocation();

            GettingChristmasDay();

            Console.WriteLine("\n");

            GlazerCalc();

            Console.WriteLine("\n");

            Console.WriteLine("Please press any key to exit");

            /*Command to keep the console and avoid the application does  automatically
            terminate when launched from the Visual Studio run debugger tool*/
            Console.ReadKey();

            

        }
    }

    
}
