/* LargestValue.cs	Based on Doyle's Example 5-9 (p.228)
 * Allows the user to input two values.
 * Determine the largest of the two values.
 * Prints the largest and its square root.
 * **************************************/

using System;

namespace LargestValue {

    class LargestValue {

        static void Main() {
            int value1,
                value2,
                largestOne;

            InputValues(out value1, out value2);
            largestOne = DetermineLargest(value1, value2);
            PrintResults(largestOne);
        }

        public static void InputValues(out int v1, out int v2) {
            string inValue;

            Console.Write("Enter the first value: ");
            inValue = Console.ReadLine();
            v1 = int.Parse(inValue);

            Console.Write("Enter the second value: ");
            inValue = Console.ReadLine();
            v2 = int.Parse(inValue);
        }

        public static int DetermineLargest(int value1, int value2) {
            int largestOne;	//local variable declared to 
                            //facilitate single exit from 							
                            //method

            if (value1 > value2) {
                largestOne = value1;
            } else {
                largestOne = value2;
            }
            return largestOne;
        }

        public static void PrintResults(int largestOne) {
            Console.WriteLine();
            Console.WriteLine("The largest value entered was "
                + largestOne);
            Console.WriteLine("Its square root is {0:f2}",
                Math.Sqrt(largestOne));
            Pause();
        }

        public static void Pause() {
            if (System.Diagnostics.Debugger.IsAttached) {
                //  Remove any keys that have been pressed too early.
                while (Console.KeyAvailable) {
                    Console.ReadKey();
                }
                Console.Write("Press any key to continue ...");
                Console.ReadKey();
            }
        }
    }
}
