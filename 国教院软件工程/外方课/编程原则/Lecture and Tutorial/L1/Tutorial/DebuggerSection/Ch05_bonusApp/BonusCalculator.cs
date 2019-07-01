/* BonusCalculator.cs	Author:	Doyle	
 * Allows the user to input their
 * gross sales for the year. This value
 * is checked to determine whether
 * a bonus is in order.  
 **************************************/

using System;

namespace BonusApp
{
	
	class BonusCalculator
	{
	
		static void Main( )
		{
			string inValue;
			decimal salesForYear;
			decimal bonusAmount = 0M;

			Console.WriteLine("Do you get a bonus this year?");
			Console.WriteLine( );
			Console.WriteLine("To determine if you are due one,");
			Console.Write("enter your gross sales figure: ");
			inValue = Console.ReadLine();
			salesForYear = Convert.ToDecimal(inValue);
			if(salesForYear > 500000.00M)
			{	
				Console.WriteLine( );
				Console.WriteLine("YES...you get a bonus!");
				bonusAmount = 1000.00M;
			}
            Console.WriteLine("Bonus for the year: {0:C}",
                                bonusAmount);
            Console.Write("\nPress any key to continue ...");
			Console.ReadLine( );
		}
	}
}
