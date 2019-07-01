using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTempConversion {
    /* Class to convert Celsius temperature to Fahrenheit
     * Author ....
     * Date: July 2015
     */
    class Convert {
        static void Main() {
            double celsius = 0.0;
  
            
            //input the temperature in degrees Celsius
            Console.WriteLine("Enter degrees Celsius: ");
            celsius = double.Parse(Console.ReadLine());
           
           // Calculate degrees Fahrenheit and output the result
            Console.WriteLine("\n\nThe equivalent in Fahrenheit is {0}" + (celsius/5*9.0+32));

            Console.Write("\n\n Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}
