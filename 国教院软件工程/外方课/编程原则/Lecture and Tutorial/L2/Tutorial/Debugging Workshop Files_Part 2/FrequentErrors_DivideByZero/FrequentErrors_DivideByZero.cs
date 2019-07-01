using System;

namespace FrequentErrors_DivideByZero {

    class FrequentErrors_DivideByZero {

        static void Main(string[] args) {

            int x = 0;
            int y = 1 / x;

            // We never get this far.
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
