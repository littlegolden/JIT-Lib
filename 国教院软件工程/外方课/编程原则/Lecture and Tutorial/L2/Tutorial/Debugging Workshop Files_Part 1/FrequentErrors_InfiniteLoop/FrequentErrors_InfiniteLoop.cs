using System;

namespace FrequentErrors_InfiniteLoop {

    class FrequentErrors_InfiniteLoop {

        static void Main(string[] args) {
        
            string response;
            Console.Write("Please enter y for yes, or n for no: ");
            response = Console.ReadLine();

            while ( (response != "y") || (response != "n") ) {
                Console.Write("Incorrect response. Please enter y for yes, or n for no: ");
                response = Console.ReadLine();
            }

            Console.Write("Your response was " + response);
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
