using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD121 {

        /// <summary>
        /// Program to demonstrate use of 2D arrays - Workshop 4
        /// Author: Mike Roggenkamp
        /// Date:   Rev 2016
        /// </summary>
        class W4_Scoring {

            static void Main(string[] args) {

                // Create an array of arrays (size 5 x 3)
                int[][] results ={
                             new int [] {900, 750, 1020 },
                             new int [] {300, 1000, 2700},
                             new int [] {500, 700, 2100},
                             new int [] {400, 900, 1780},
                             new int [] {600, 1020, 1000}
            };

                // Create a one dimensional array to store the scores for each row of results
                int[] scores = new int[results.GetLength(0)];

                int overallTotal;
                double averageScore;

                for (int row = 0; row < results.GetLength(0); row++) {

                    scores[row] = SumArray(results[row]);
                }//end for 

                Display2DArray(results, scores);

                overallTotal = SumArray(scores);
                averageScore = CalculateAverageScore(scores);

                DisplayOverallResults(overallTotal, averageScore, scores);

                ExitProgram();
            }//end Main

            /// <summary>
            /// Calculates the average of the scores
            /// </summary>
            /// <param name="scores">an array of score values</param>
            /// <returns>the average of the scores in the array</returns>
            static double CalculateAverageScore(int[] scores) {
                double total = 0.0;

                total = SumArray(scores);

                return (total / scores.Length);
            }// end CalculateAverageScore

            /// <summary>
            /// Sum the values in an array
            /// </summary>
            /// <param name="scores">an array of scores</param>
            /// <returns>the sum of the scores in the array</returns>
            static int SumArray(int[] scores) {
                int total = 0;


                return total;
            }//end SumArray

            /// <summary>
            /// Output the content of an array 
            /// </summary>
            /// <param name="scores">the array of scores</param>
            static void DisplayArray(int[] scores) {

                foreach (int element in scores) {
                    Console.Write("{0,5}", element);
                }//end foreach
            }//end DisplayArray

            /// <summary>
            /// Output the contents of a 2D array
            /// </summary>
            /// <param name="results">a 2D array</param>
            /// <param name="scores">an array of row totals of results</param>
            static void Display2DArray(int[][] results, int[] scores) {
                Console.WriteLine("\n");

                for (int row = 0; row < results.GetLength(0); row++) {

                    Console.Write("Player {0} your scores are", row + 1);
                    DisplayArray(results[row]);
                    Console.WriteLine(" which is a total of {0}\n", scores[row]);

                }//end for

            }//end Display2DArray

            /// <summary>
            /// Output statistic about the players and scores
            /// </summary>
            /// <param name="total">total of the scores</param>
            /// <param name="average">average of the scores</param>
            /// <param name="scores">an array of score totals</param>
            static void DisplayOverallResults(int total, double average, int[] scores) {

                Console.WriteLine("\n\nOverall {0} was scored by {1} players at an average of {2:f} per player\n\n", total, scores.Length, average);
            }//end DisplayOverallResults

            /// <summary>
            /// Output exit message at end of program
            /// </summary>
            static void ExitProgram() {
                Console.Write("\n\nPress any key to exit program: ");
                Console.ReadKey();
            }//end ExitProgram

        }//end class
    }//end namespace

