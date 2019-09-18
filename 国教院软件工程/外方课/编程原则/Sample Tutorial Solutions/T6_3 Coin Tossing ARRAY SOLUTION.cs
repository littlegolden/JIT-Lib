using System;


namespace CoinApplication {

    /// <summary>
    /// Driver for the Coin Class
    /// Simulates a coin tossing game - using an array of Coin
    /// NB: Work in progress - need to modularise
    /// Author: Donna Teague (2016)
    /// </summary>
    class CoinTossing {

        static void Main(string[] args) {

            // declare 2 counter variables
            int heads = 0;
            int tails = 0;
            int different = 0;

            const int NUM_TOSSES = 1000; // test for 1000 tosses

            // declare a Coin variable and create (instantiate) the Coin object
            //Coin coin = new Coin(); 

            // variation - an array of 2 coins
            const int NUMCOINS = 2;

            // create an array of Coin
            Coin[] coins = new Coin[NUMCOINS];

            for (int i = 0; i < NUMCOINS; i++) {
                coins[i] = new Coin();
            }

            Console.WriteLine("Welcome to Coin Toss Simulation\n");

            // repeat the following 
            for (int i = 0; i < NUM_TOSSES; i++) {
                //   flip the Coin object

                coins[0].Flip();
                coins[1].Flip();
                Console.WriteLine("\nCoin tosses were: {0} and {1}", coins[0].ToString(), coins[1].ToString());
                //Console.Write("Enter for next toss...");
                //Console.ReadKey();
                //   if Coins both show Heads
                //      increment Head counte
                if (coins[0].IsHeads() && coins[1].IsHeads()) {
                    heads++;
                }
                //   also check if both Coins are Tails
                else if (!coins[0].IsHeads() && !coins[1].IsHeads()) {

                    tails++;
                } else { // coins must be different
                    different++;
                }
                //   end if
            }
            // end repeat


            // Output result 
            Console.WriteLine("\n{0} times both coins were Heads", heads);
            Console.WriteLine("{0} times both coins were Tails", tails);
            Console.WriteLine("{0} times both coins were different", different);


            Console.Write("\n\n Press any key to continue ...");
            Console.ReadKey();

        }
    }
}
