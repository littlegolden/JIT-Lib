using System;

namespace FrequentErrors_OperatorPrecedence {

    class FrequentErrors_OperatorPrecedence {

        static void Main(string[] args) {

            int startKilometres = 1000;
            int stopKilometres = 1800;
            int hoursTaken = 10;

            int averageKilometresPerHour = stopKilometres - startKilometres / hoursTaken;
            Console.WriteLine("averageKilometresPerHour = " + averageKilometresPerHour);

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
