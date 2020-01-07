using System;

namespace YourFirstVisualStudioCSharpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Brandon Smith";
            string location = "Newbury Park, CA";
            DateTime date = DateTime.Today;
            DateTime christmas = new DateTime(2020, 12, 25);
            TimeSpan days = (christmas - date);
            double numDays = days.TotalDays;

            Console.WriteLine("My name is " + name + " I am from " + location);
            Console.WriteLine("Todays date is " + date.ToString("d") + " and there are " + numDays + " days until christmas!!");

            Console.WriteLine("Press any key to continue to the GlazerCalc program.");
            Console.ReadKey();
            /*This is the start of the GlazerCalc program from the textbook section 2.1*/

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            height = 0;
            width = 0;
            while (width == 0) /*While loop to repeat width request until valid entry*/
            {
                Console.WriteLine("Enter the width in Metres");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);

                if (width < 0.5)
                {
                    width = 0;
                    Console.WriteLine("Incorrect Width Cannot be less than 0.5 Metres");
                }
                else if (width > 5)
                {
                    width = 0;
                    Console.WriteLine("Incorrect Width Cannot be greater than 5.0 Metres");
                }
            }

            while (height == 0) /*While loop to repeat width request until valid entry*/
            {
                Console.WriteLine("Enter the height in Metres");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);

                if (height < 0.75)
                {
                    height = 0;
                    Console.WriteLine("Incorrect Height Cannot be less than 0.75 Metres");
                }
                else if (height > 3.0)
                {
                    height = 0;
                    Console.WriteLine("Incorrect Height Cannot be greater than 3.0 Metres");
                }
            }

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);


            Console.WriteLine("The length of the wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
