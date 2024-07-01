using System;

class Program
{
  static void Main()
  {

      bool endapplication = false;
      string choice;

  Console.WriteLine("************************************");
  Console.WriteLine("*  The stars shine in Greenville.  *");
  Console.WriteLine("************************************");
      while (!endapplication) // this is the start of the loop that we will use to give the user the chance of entering 1 or 2.
        {
            Console.WriteLine("Please enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit");

            choice = Console.ReadLine(); // read the choices from the user
 switch (choice)
      {
          case "1":
          calculationmethod(); // if the user enters 1, the calculation method will be called
              break;
          case "2":
              Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!"); // if the user enters 2, the program will end

        endapplication = true; // break from the switch statement
              break;
          default:
              Console.WriteLine("This option is invalid is invalid, please enter 1 or 2."); // if the user enters anything else, the program will ask the user to enter 1 or 2
              break;
      }
}
     static void calculationmethod() // the calculation method
        {
            Console.WriteLine("Enter the number of contestants last year:");
            int lastyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of contestants this year:");
            int thisyear = int.Parse(Console.ReadLine());
            double revenuePerContestant = 25.0; // the revenue per contestant is 25 dollars

            double revenue = thisyear * revenuePerContestant; // the revenue is the number of contestants this year multiplied by the revenue per contestant
            Console.WriteLine("Last year's competition had "+(lastyear)+" contestants, and this year's has "+ (thisyear)+" contestants"); // the program will display the number of contestants last year and this year


            Console.WriteLine($"Revenue expected this year is ${revenue}"); // the program will display the revenue expected this year

            if (thisyear > lastyear) // if the number of contestants this year is greater than the number of contestants last year, the program will display
                Console.WriteLine("It is true that this year's competition is bigger than last year's.");
            else
                Console.WriteLine("It is false that this year's competition is not bigger than last year's."); // if the number of contestants this year is less than the number of contestants last year, the program will display
            
            Console.WriteLine("");
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");

        }
    }
    }