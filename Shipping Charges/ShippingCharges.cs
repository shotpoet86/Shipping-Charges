/* Programmer: Austin Parker
   Date: Feb 24th, 2020
   Purpose: This program displays shipping charges
   based on number of items purchased for an internet retailer.
 */
using static System.Console;

namespace Shipping_Charges
{
    class ShippingCharges
    {
        static void Main()
        {
            //This allows the user to start or continue program
            while (true)
            {
                string startApp = "y";
                string endApp = "n";
                WriteLine("\n Select \"{0}\" to Start or Continue application. " +
                          "\n Select \"{1}\" to End application.", startApp, endApp);
                string startProgram = ReadLine();
                Clear();
                if (startProgram == endApp)
                {
                    WriteLine("\n Thanks for using the Shipping Charges application.");
                    break;
                }

                // Instructions for application and instantiates the default constructor from Charges class
                var charges = new Charges();
                {
                    WriteLine("\n Welcome to the shipping charges application.\n" +
                              "\n In the next screen you will be asked to enter how many items you purchased." +
                              "\n The shipping rates will display in the next screen based on quantity shipped.\n" +
                              "\n Please press enter key to begin");
                    ReadKey();
                    Clear();
                }

                //Displays shipping charges based on user input and instantiates constructor with four arguments
                var chargesTotal = new Charges(2.99M, 1.99M, 1.49M, .99M);
                {
                    Write("\n Please enter amount purchased " +
                          " to display standard shipping charges: ");
                    Write(chargesTotal.ToString() + "\n");

                }

            }
        }


    }
}

