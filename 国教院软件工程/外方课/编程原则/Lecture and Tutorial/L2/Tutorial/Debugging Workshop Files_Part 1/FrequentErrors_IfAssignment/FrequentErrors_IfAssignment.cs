using System;

namespace FrequentErrors_IfAssignment {

    class FrequentErrors_IfAssignment {

        static void Main(string[] args) {

            bool done = false;

            if (done = true)
                Console.WriteLine("done is true.");
            else
                Console.WriteLine("done is false");

/* When the instructions tell you to, remove this entire line (only).
            int myNumber = 0;

            if (myNumber = 1)
                Console.WriteLine("myNumber is 1.");
            else
                Console.WriteLine("myNumber is not 1.");
When the instructions tell you to, remove this entire line (only). */

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
