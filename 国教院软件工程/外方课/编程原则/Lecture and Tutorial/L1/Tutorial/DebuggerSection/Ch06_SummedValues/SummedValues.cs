/* SummedValues.cs       Author: Doyle
 * Demonstrates use of a loop to add 10 
 * integers. Displays the total after
 * the loop body is completed. 
 */
using System;
namespace SummedValues
{
   class SummedValues
   {
		static void Main( )
       { 
           int sum = 0;
           int number = 1;
           while (number < 11)
           {
              sum = sum + number;
              number++;
           }
           Console.WriteLine("Sum of values 1 through 10 is "
                           + sum);
           Console.Write("\nPress any key to continue ...");
           Console.ReadLine();
       }
   }
}
