using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeDirections {

    /// <summary>
    /// Change Directions - a modification of the Race to the End game
    /// introduced in Lecture
    /// Author: Donna Teague
    /// Date: July 2016
    /// </summary>
    class RaceToTheEnd {

        const int NUM_SQUARES = 41;
        const int START_SQUARE = NUM_SQUARES / 2;
        const int NUM_PLAYERS = 2;
        const int TIE = 0;
        const int BOTH_LOSERS = -2;

        static int[] players = new int[NUM_PLAYERS]; // players[0] is player 1
        static Die myDie = new Die();

        /// <summary>
        /// Set both of the players at the starting square
        /// (the middle of the board)
        /// </summary>
        static void InitialisePlayers() {
            for (int i = 0; i < NUM_PLAYERS; i++) {
                players[i] = START_SQUARE;
            }
        } //end InitialisePlayers

        /// <summary>
        /// Play a full game of Changing Directions
        /// </summary>
        static void PlayGame() {

            bool right = true;

            do {
                PlayOneRound(ref right);
                UpdatePlayersPosition();

                Console.WriteLine("\nENTER to play one round...");
                Console.ReadLine();

            } while (!OffTheEnd());
        } //end PlayGame 


        /// <summary>
        /// Play one round of the game - each player takes a turn
        /// </summary>
        /// <param name="right">Represents the direction the players are travelling</param>
        static void PlayOneRound(ref bool right) {

            for (int i = 0; i < NUM_PLAYERS; i++) {
                myDie.RollDie();
                if (right) { // direction is to the right, so increment
                    players[i] = players[i] + myDie.GetFaceValue();
                } else { // need to decrement as heading left
                    players[i] = players[i] - myDie.GetFaceValue();
                }
            } //end for 

            right = !right;

        } //end PlayOneRound

        /// <summary>
        /// Check if either of the players has hit an end of the board
        /// </summary>
        /// <returns>True if one of the players has hit either end</returns>
        static bool OffTheEnd() {
            bool finished = false;

            if (((players[0] >= NUM_SQUARES) || (players[1] >= NUM_SQUARES)) || // AT OR BEYOND THE RIGHT
                    ((players[0] <= 1) || (players[1] <= 1))) { // AT OR BEYOND THE LEFT
                finished = true;
            }
            return finished;
        }// end OffTheEnd

        /// <summary>
        /// Output the position of each player on the board
        /// </summary>
        static void UpdatePlayersPosition() {
            for (int i = 0; i < NUM_PLAYERS; i++) {
                Console.WriteLine("Player {0} is at position {1}", i + 1, players[i]);
            }//end for
        }//end OutputPlayersPosition


        /// <summary>
        /// Find out who has won
        /// </summary>
        /// <returns>A value representing either the winning player number or
        /// BOTH_LOSERS or TIE</returns>
        static int DetermineWinner() {

            int winner = -1;

            // if both <= 1 - no winners
            if ((players[0] <= 1) && (players[1] <= 1)) {
                winner = BOTH_LOSERS;
                // if both >= 41 - tie
            } else if ((players[0] >= NUM_SQUARES) && (players[1] >= NUM_SQUARES)) {
                winner = TIE;
                // player 1 gets to RHS or player 2 gets to LHS then player 1 (at index 0) wins
            } else if ((players[0] >= NUM_SQUARES) || (players[1] <= 1)) {
                winner = 1;
                // player 2 gets to RHS or player 1 gets to LHS then player 2 (at index 1) wins
            } else {
                winner = 2;
            }
            return winner;

        }//end DetermineWinner

        /// <summary>
        /// Display message describing the outcome of the game
        /// </summary>
        /// <param name="whoWon"></param>
        static void OutputResult(int whoWon) {
            if ((whoWon != TIE) && (whoWon != BOTH_LOSERS)) {
                Console.WriteLine("\n Player {0} won\n", whoWon);
            } else if (whoWon == TIE) {
                Console.WriteLine("\n Both players won\n");
            } else {
                Console.WriteLine("\n No-one won!\n");
            }
        }//end OutputResults

        static void ExitProgram() {
            Console.WriteLine("That's all folks!");
        }

        /// <summary>
        /// Program entry point - high level algorithm of the program
        /// </summary>
        static void Main() {
            int winner = TIE;
            InitialisePlayers();
            PlayGame();
            winner = DetermineWinner();
            OutputResult(winner);

        } //end Main 
    }
}