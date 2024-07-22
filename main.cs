using System;

class Program
{
  static void Main()
  {   bool endapplication = false;
              string choice;

              Console.WriteLine("************************************");
              Console.WriteLine("*  The stars shine in Greenville.  *");
              Console.WriteLine("************************************");

              while (!endapplication) // start of the loop for user input
              {
                  Console.WriteLine("Please enter the following number below from the following menu:");
                  Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                  Console.WriteLine("2. Exit");

                  choice = Console.ReadLine(); // read the choices from the user

                  switch (choice)
                  {
                      case "1":
                          CalculationMethod(); // call the calculation method if user enters 1
                          break;
                      case "2":
                          Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!"); // end the program if user enters 2
                      endapplication = true; // break from the switch statement
                          break;
                      default:
                          Console.WriteLine("This option is invalid, please enter 1 or 2."); // prompt for valid input if user enters anything else
                          break;
                  }
              }
          }


    
    static void CalculationMethod() // the calculation method
    {
        // Prompt for and read the number of contestants from last year
        int lastYear = ValidateEntry("Enter the number of contestants last year:");

        // Prompt for and read the number of contestants from this year
        int thisYear = ValidateEntry("Enter the number of contestants this year:");

        double revenuePerContestant = 25.0; // the revenue per contestant is $25
        // Calculate the revenue for this year
        double revenue = thisYear * revenuePerContestant; // the revenue is the number of contestants this year multiplied by the revenue per contestant

        // Adjusted comparison logic based on assignment v.03 requirements.
        if (thisYear == 2 * lastYear) // Checks if this year's contestants are exactly double last year's
        {
            Console.WriteLine("The competition is more than twice as big this year!");
            Console.WriteLine("");
        }
        else if (thisYear > 2 * lastYear) // Checks if this year's contestants are more than double last year's
        {
            Console.WriteLine("The competition is bigger than ever!");
            Console.WriteLine("");
        }
        else // Checks if this year's contestants are fewer or the same number as last year
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            Console.WriteLine("");
        }

        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }

          static int ValidateEntry(string prompt)// the method to validate the user input
          {
              int number; // declare the variable to hold the number
              while (true)
              {
                  Console.WriteLine(prompt);
                  if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 30) // if the input is a valid integer between 0 and 30, return the number
                  {
                      break; // valid number entered
                  }
                  Console.WriteLine("Invalid number. Please enter a number between 0 and 30."); // prompt for valid input
              }
              return number; // return the valid number
          }
      }