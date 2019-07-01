using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LecturePrep {

    class L6_RaceToTheEnd {

        const int END_SQUARE = 10;
        const int START_SQUARE = 0;
        const int NUM_PLAYERS = 2;
        const int TIE = 0;

        static int[] players = new int[NUM_PLAYERS]; // players[0] is player 1
        static Die myDie = new Die();

        /// <summary>
        /// Set up the players at the starting square of the game
        /// </summary>
        static void InitialisePlayers() {
            for (int i = 0; i < NUM_PLAYERS; i++) {
                players[i] = START_SQUARE;
            }
            UpdatePlayersPosition(); 
        } //end InitialisePlayers

        /// <summary>
        /// Play the game until someone hits the finish line
        /// </summary>
        static void PlayGame() {
            do {
                Console.WriteLine("\nENTER to play one round...");
                Console.ReadLine();
                PlayOneRound();
                UpdatePlayersPosition();
            } while (!PastThePost());
        } //end PlayGame 


        /// <summary>
        /// Advance each player by a random amount of squares
        /// </summary>
        static void PlayOneRound() {
            for (int i = 0; i < NUM_PLAYERS; i++) {
                myDie.RollDie();
                players[i] = players[i] + myDie.GetFaceValue(); // Die.cs getter
            } //end for 
        } //end PlayOneRound

        /// <summary>
        /// Checks if either player has hit (or gone past) the end square
        /// </summary>
        /// <returns>true if either player has reached the end, false otherwise</returns>
        static bool PastThePost() {
            bool finished = false;

            if ((players[0] >= END_SQUARE) || (players[1] >= END_SQUARE)) {
                finished = true;
            }
            return finished;
        }// end PastThePost

        /// <summary>
        /// Output the position for each of the players
        /// </summary>
        static void UpdatePlayersPosition() {
            for (int i = 0; i < NUM_PLAYERS; i++) {
                Console.WriteLine("Player {0} is at position {1}", i + 1, players[i]);
            }//end for
        }//end OutputPlayersPosition

        /// <summary>
        /// Determine the winner of the game
        /// </summary>
        /// <returns>0 if a tie; 1 if player 1 is winner; 2 if player 2 is winner</returns>
        static int DetermineWinner() {
            int winner = 0;

            if (players[0] > players[1]) {
                winner = 1; // player 1, at index 0
            } else if (players[0] < players[1]) {
                winner = 2; // player 2 at index 1
            }
            return winner;
        }//end DetermineWinner


        /// <summary>
        /// Output message regarding the winner (if any)
        /// </summary>
        /// <param name="whoWon">value in range 0..2 representing the winner</param>
        static void OutputResult(int whoWon) {
            if (whoWon != TIE) {
                Console.WriteLine("\n** GAME OVER **\nPlayer {0} is first past the post\n", whoWon);
            } else {
                Console.WriteLine("\n** GAME OVER **\nIt was a dead heat!\n");
            }
        }//end OutputResults

        /// <summary>
        /// Output exit message
        /// </summary>
        static void ExitProgram() {
            Console.WriteLine("That's all folks!");
        }

        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main() {

            // overall algorithm for the game
            int winner = TIE;
            InitialisePlayers();
            PlayGame();
            winner = DetermineWinner();
            OutputResult(winner);
            ExitProgram();
        } //end Main 
    }
}