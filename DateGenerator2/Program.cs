using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateGenerator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearInput = "";
            int Year = 1;

            string monthInput = "";
            int Month = 1;

            for (;;)
            {
                Console.WriteLine("Please enter the year:");
                yearInput = Console.ReadLine();

                if (!int.TryParse(yearInput, out Year))
                {
                    Console.WriteLine("Invalid input. Please enter Year number");
                    continue;
                }
                else if (Year <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter Year number");
                    continue;
                }

                for (;;)
                {
                    Console.WriteLine("Please enter month number (1-12):");
                    monthInput = Console.ReadLine();

                    if (!int.TryParse(monthInput, out Month))
                    {
                        Console.WriteLine("Invalid input. Please enter Month number");
                        continue;
                    }

                    else if (Month < 1 || Month > 12)
                    {
                        Console.WriteLine("There is only 12 months in a year. Please enter Month number");
                        continue;
                    }
                    break;
                }

                int Days = DateTime.DaysInMonth(Year, Month);
                string formattedOutput = string.Format("{0}-{1} has {2} days", Year, Month, Days);
                Console.WriteLine(formattedOutput);

                Console.WriteLine("Do you want to continue?");
                string closingInput = Console.ReadLine();

                if (closingInput != "y")
                {
                    break;
                }
            }
        }

    }
}
