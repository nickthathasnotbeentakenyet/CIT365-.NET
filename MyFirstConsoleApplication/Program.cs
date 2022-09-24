using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            GlazerApp.RunExample();
            Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();
            Console.ReadKey();
        }
        private static void GetUserNameAndLocation()
        {
            Console.WriteLine("What is your name? ");
            string personName = Console.ReadLine();
            Console.WriteLine($"Hi {personName}! Where are you from? ");
            string personLocation = Console.ReadLine();
            Console.WriteLine($"I have never been to {personLocation}. I bet it is nice. Press any key to continue...");
            // exit
            Console.ReadLine();
            Person person = new Person
            {
                Name = personName,
                Location = personLocation
            };

        }
        private static void ChristmasCountdown()
        {
            // method calculates the number of days before X-mas this year.
            DateTime currentDate = DateTime.Now.Date;
            Console.WriteLine($"Today's date is: {currentDate.ToString("dd/MM/yyyy")}");
            DateTime xmas = DateTime.Parse("2022, 12, 25");
            int daysUntilX = (xmas - currentDate).Days;
            Console.WriteLine($"There are {daysUntilX} days until Christmas");
            // exiting
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
