using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors {
    /// <summary>
    /// Game of Rock Paper Scissors - to demonstrate use of enum
    /// A work-in-progress.  Need to:
    /// - add input checking
    /// - add exception handling
    /// Rev: Donna Teague 2017
    /// </summary>
    class W5_RockPaperScissors {

        //static Random randomChoice = new Random();

        public enum StateOfPlay { ROCK, PAPER, SCISSORS }

        /// <summary>
        /// Main method resembles the high-level algorithm for the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {

            Random randomChoice = new Random();

            bool tie;
            bool again;

            DisplayWelcomeMessage();

            do {
                tie = false;
                again = false;

                PromptUser();

                StateOfPlay userSelection = UserChoice();
                StateOfPlay compSelection = ComputerChoice(randomChoice);

                DisplayChoices(userSelection, compSelection);

                tie = DetermineWinner(userSelection, compSelection);

                if (!tie) {
                    again = PlayAgain();
                }

            } while (tie || again);
        } // end Main

        /// <summary>
        /// Display a welcome message
        /// </summary>
        public static void DisplayWelcomeMessage() {
            Console.WriteLine("\n\tLet's Play ROCK PAPER SCISSORS\n\n");
        } // end DisplayWelcomeMessage

        /// <summary>
        /// Display a menu summarising input options
        /// </summary>
        public static void PromptUser() {
            Console.WriteLine("Select your move:");
            Console.WriteLine("  For Rock    \tenter 0:");
            Console.WriteLine("  For Paper   \tenter 1:");
            Console.WriteLine("  For Scissors\tenter 2:\n");

            Console.Write("Enter your single letter <0, 1 or 2>: ");
        } // end PromptUser

        /// <summary>
        /// Read the human player's choice from the keyboard
        /// </summary>
        /// <returns></returns>
        public static StateOfPlay UserChoice() {
            return (StateOfPlay)int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Randomly select a choice for the computer player
        /// </summary>
        /// <returns></returns>
        public static StateOfPlay ComputerChoice(Random randomChoice) {

            return (StateOfPlay)randomChoice.Next((int)StateOfPlay.SCISSORS + 1); // 3 choices, between 0 and 2
        } // end ComputerChoice

        /// <summary>
        /// Display the choices made by both players
        /// </summary>
        /// <param name="user"></param>
        /// <param name="computer"></param>
        public static void DisplayChoices(StateOfPlay user, StateOfPlay computer) {
            Console.WriteLine("I played {0} and you played {1}", computer, user);


        } // end Display Choices

        /// <summary>
        /// Calculate who the winner of the game is
        /// </summary>
        /// <param name="user">The human player</param>
        /// <param name="computer">The human player's computer oponent</param>
        /// <returns>True if there has been a tie, False otherwise</returns>
        public static bool DetermineWinner(StateOfPlay user, StateOfPlay computer) {

            bool tie = false;

            // when the user wins
            if ((user == StateOfPlay.PAPER) && (computer == StateOfPlay.ROCK) ||
                (user == StateOfPlay.SCISSORS) && (computer == StateOfPlay.PAPER) ||
                (user == StateOfPlay.ROCK) && (computer == StateOfPlay.SCISSORS)) {
                Console.WriteLine("You won, lucky choice!");
                tie = false;
                // when user and computer have chosen the same thing
            } else if (user == computer) {
                tie = true;
                Console.WriteLine("Great minds think alike!");
                // all other cases - computer wins
            } else {
                Console.WriteLine("I won!");
                tie = false;
            }

            return tie;
        } // end DetermineWinner

        /// <summary>
        /// Find out if the user wants to play again
        /// Any input apart from y or Y is assumed to mean NO
        /// </summary>
        /// <returns>True if they do, False if they don't</returns>
        public static bool PlayAgain() {

            Console.Write("Another game?? (y/n): ");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y") {
                return true;
            } else {
                return false;
            }
        } // end PlayAgain
    }
}
