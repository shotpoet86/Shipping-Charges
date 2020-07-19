/* Programmer: Austin Parker
   Date: Feb 24th, 2020
   Purpose: This program displays shipping charges
   based on number of items purchased for an internet retailer.
 */
using System;
using static System.Console;

namespace Shipping_Charges
{
    public class Charges
    {
        //Constructors
        public Charges()
        { 
            
        }
        public Charges(decimal onePurchased, decimal levelTwoDiscount, decimal levelThreeDiscount,
            decimal levelFourDiscount)
        {
            OnePurchased = onePurchased;
            LevelTwoDiscount = levelTwoDiscount;
            LevelThreeDiscount = levelThreeDiscount;
            LevelFourDiscount = levelFourDiscount;
        }

        //Properties using auto- implemented properties
        public decimal OnePurchased { get; set; }

        public decimal LevelTwoDiscount { get; set; }

        public decimal LevelThreeDiscount { get; set; }

        public decimal LevelFourDiscount { get; set; }

        //Methods for calculating values
        public decimal ReturnAmountPurchased()
        {
            //Switch/Case statement to display different messages based on user input of items purchased
            decimal purchaseTotals = Convert.ToDecimal(ReadLine());
            Clear();
            switch (purchaseTotals)
            {
                case 0:
                case 1:
                    WriteLine("\n Shipping cost for 1 item is: {0:C}", OnePurchased);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    WriteLine("\n Shipping cost for up to 5 items is as follows:\n" +
                              " First item ships at = {0:C}" +
                              "\n Items 2 to 5 = {1:C}", OnePurchased, LevelTwoDiscount);
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                    WriteLine("\n Shipping cost for less than 15 items is as follows:\n" +
                              " First item ships at = {0:C}" +
                              "\n Items 2 to 5 ship at = {1:C}" +
                              "\n Items 6 to 14 ship at = {2:C}",
                        OnePurchased, LevelTwoDiscount, LevelThreeDiscount);
                    break;
                default:
                    WriteLine("\n Shipping cost for 15 items and over is as follows:\n" +
                              " First item ships at = {0:C}" +
                              "\n Items 2 to 5 ship at = {1:C}" +
                              "\n Items 6 to 14 ship at = {2:C}" +
                              "\n Items 15 and over ship at = {3:C}",
                        OnePurchased, LevelTwoDiscount, LevelThreeDiscount, LevelFourDiscount);
                    break;
            }

            return purchaseTotals;
        }
        //Displays total items to be shipped and results of Switch/Case statement
        public override string ToString()
        {
            return "\n Total items to be shipped: " + ReturnAmountPurchased();
        }
    }
}