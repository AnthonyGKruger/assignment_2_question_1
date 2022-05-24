using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace assignment_2_question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables used throughout the program
            int Amount;
            double dollars, halfDollars, quarters, dimes, nickels, cents;

            
            //welcoming the user and giving the user some more information about the program 
            System.Console.Write("\nWelcome to the change calculator, the purpose of this program is to calculate" +
                                 " how much change can be made using the US coin system.\nIt will output the amount " +
                                 "of coins needed to make up for the amount of dollars used as input. \n\n");

            //using goto label in case we have an error in the try block to divert the user back to the beginning
            //of the program or to restart the program should the user complete using the program.
            restartTheProgram:
            
            //requesting that the user enters and amount that they would need change for
            System.Console.Write("How many dollars do you need change for ?    ");
            
            //Wrapping program in a try catch statement to try and catch any errors for smoother user experiance
            try
            {
                //storing the amount entered by the user into a variable for later use in the program.
                Amount = int.Parse(Console.ReadLine());

                //declaring a self defined object, a class that calculates the amount of coins that can be given for
                //each the amount of dollars entered for each type of US coin 
                ChangeCalculator calculatorObj = new ChangeCalculator();

                //using the ChangeCalculator class helper functions to calculate the values for the various types of us
                //coins and storing it into the relevant variable.
                //EACH HELPER FUNCTION TAKES THE FORMAL PARAMETER INT AMOUNT AS AN ARGUMENT
                //(this is as per the assignment requirement.)
                dollars = ChangeCalculator.Dollars(Amount);
                halfDollars = ChangeCalculator.HalfDollars(Amount);
                quarters = ChangeCalculator.Quarters(Amount);
                dimes = ChangeCalculator.Dimes(Amount);
                nickels = ChangeCalculator.Nickels(Amount);
                cents = ChangeCalculator.Cents(Amount);
                
                //Calling the last helper function of our class to display the change that is possible with
                //the various US coins
                System.Console.WriteLine(
                    "\n" + ChangeCalculator.GiveChange(dollars, halfDollars, quarters, dimes, nickels, cents)
                    );

            }
            //catching any errors that could be generated.
            catch (Exception e)
            {
                //printing out the error message.
                System.Console.WriteLine("\n\nOOPS, Somthing went wrong, here is the error message ->" + e.Message);
            }
            //finally statement which will run regardless of whether there is an error or not.
            finally
            {
                //Thanking the user for using the program.
                System.Console.WriteLine("\n\nThank you for using the program. " +
                                         "Please feel free to run some more calculations!\n\n");
                
            }
            //Restarting the program regardless of whether there was an error or not.
            goto restartTheProgram;
        }
        
    }

    //self defined class with helper functions used to calculate the amount of coins the user input can generate.
    public class ChangeCalculator
    {
        
        //returns the amount of dollars are in the user input
        // -> Accepts a single int formal parameter Amount
         public static double Dollars(int Amount)
         {
             double toReturn = Amount;
             return  toReturn / 1;  
         }

         //returns the amount of half dollars that can be made from the user input
         // -> Accepts a single int formal parameter Amount
         public static double HalfDollars(int Amount)
         {
             double toReturn = Amount;
             return  toReturn / 0.5;
         }
         
         //returns the amount of quarters that can be made from the user input
         // -> Accepts a single int formal parameter Amount
         public static double Quarters(int Amount)
         {
             double toReturn = Amount;
             return toReturn / .25;
         }
         
         //returns the amount of dimes that can be made from the user input
         // -> Accepts a single int formal parameter Amount
         public static double Dimes(int Amount)
         {
             double toReturn = Amount;
             return toReturn / .10;
         }
         
         //returns the amount of nickels that can be made from the user input
         // -> Accepts a single int formal parameter Amount
         public static double Nickels(int Amount)
         {
             double toReturn = Amount;
             return toReturn / .05;
         }

         //returns the amount of cents that can be made from the user input
         // -> Accepts a single int formal parameter Amount
         public static double Cents(int Amount)
          {
              double toReturn = Amount;
              return toReturn / .01;
          }

         //Returns a string with all the various coin values using string.format to neaten the output.
         public static string GiveChange(double dollars, double halfDollars, double quarters, double dimes, 
             double nickels, double cents)
         {
             return "Using the US coin system, the maximum number of coins needed by each type of coin to " +
                    "give change for $" + dollars + " is:\n\n"
                    + string.Format("{0,10}{1,-15}{2,10}", "->  ","Half Dollars:", halfDollars) + "\n" 
                    + string.Format("{0,10}{1,-15}{2,10}", "->  ", "Quarters:", quarters) + "\n"
                    + string.Format("{0,10}{1,-15}{2,10}", "->  ", "Dimes:", dimes) + "\n"
                    + string.Format("{0,10}{1,-15}{2,10}", "->  ", "Nickels:", nickels) + "\n"
                    + string.Format("{0,10}{1,-15}{2,10}", "->  ", "Cents:", cents);
         }
    }
}