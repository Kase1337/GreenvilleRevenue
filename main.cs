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
            // Prompt for and read the number of contestants from last year
            Console.WriteLine("Enter the number of contestants last year:");
            int lastYear = int.Parse(Console.ReadLine());
            
            // Prompt for and read the number of contestants from this year
            Console.WriteLine("Enter the number of contestants this year:");
            int thisYear = int.Parse(Console.ReadLine());
            
            double revenuePerContestant = 25.0; // the revenue per contestant is $25
            // Calculate the revenue for this year
            double revenue = thisYear * revenuePerContestant; // the revenue is the number of contestants this year multiplied by the revenue per contestant

            
            // New comparison logic based on v0.2 requirements 
            if (thisYear > 2 * lastYear) // This calculates a more than double the contestants
            {
                Console.WriteLine("The competition is more than twice as big this year!");   // if the number of contestants this year is greater than double the number of contestants last year, the program will
                Console.WriteLine("");
            }
            else if (thisYear > lastYear) // This calculates a more contestants than last year but not double
            {
                Console.WriteLine("The competition is bigger than ever!");   // if the number of contestants this year is greater than the number of contestants last year, the program will
                Console.WriteLine("");
            }
            else // This calculates a fewer or the same number of contestants as last year
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");  // if the number of contestants this year is less than or equal to the number of contestants last year, display "tigher race this year! Come out and cast your vote!"
                Console.WriteLine("");
            }

              Console.WriteLine("************************************");
              Console.WriteLine("*  The stars shine in Greenville.  *");
              Console.WriteLine("************************************");
        }
    }
    }