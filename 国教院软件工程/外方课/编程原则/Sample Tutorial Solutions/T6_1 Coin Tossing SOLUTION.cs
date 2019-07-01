using System;


namespace CoinApplication {
    class CoinTossing {
        static void Main(string[] args) {

            // declare 2 counter variables
            int heads = 0;
            int tails = 0;

            // declare a Coin variable and create (instantiate) the Coin object
            Coin coin = new Coin();

            Console.WriteLine("Welcome to 1000 Coin Toss Simulation\n");

            // repeat the following 1000 times
            for (int i = 0; i < 1000; i++) {
                //   flip the Coin object
                coin.Flip();
                //   if Coin shows a Head
                //      increment Head counte
                if (coin.IsHeads()) {
                    heads++;
                }
                //   else 
                //       increment Tail Counter
                else {
                    tails++;
                }
                //   end if

            }
            // end repeat


            // Output result of 1000 coin tosses
            Console.WriteLine("{0} times coin landed on Heads\n", heads);
            Console.WriteLine("{0} times coin landed on Tails", tails);


            Console.Write("\n\n Press any key to continue ...");
            Console.ReadKey();

        }
    }
}
