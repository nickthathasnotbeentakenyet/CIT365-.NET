using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("What is the width value?: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What is the height value?: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
