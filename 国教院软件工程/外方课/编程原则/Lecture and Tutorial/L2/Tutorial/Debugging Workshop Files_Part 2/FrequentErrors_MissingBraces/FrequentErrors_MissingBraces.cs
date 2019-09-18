using System;

namespace FrequentErrors_MissingBraces {

    class FrequentErrors_MissingBraces {

        static void Main(string[] args) {

            Console.WriteLine("Part 1.  Impossible?");

            if (1 == 2)
                Console.WriteLine("??");
                Console.WriteLine("1 is equal to 2. The impossible has happened!!");

            Console.WriteLine("");

            Console.WriteLine("Part 2.  The dangling else.");
            bool happy = false;
            bool friend = true;

            if (happy) 
                if (friend) 
                    Console.WriteLine("both");
            else
                Console.WriteLine("not happy");

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
