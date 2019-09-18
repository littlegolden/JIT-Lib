using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD121 {

    class W4_Scoring {

        static void Main(string[] args) {

            int[][] results ={
                             new int [] {900, 750, 1020 },
                             new int [] {300, 1000, 2700},
                             new int [] {500, 700, 2100},
                             new int [] {400, 900, 1780},
                             new int [] {600, 1020, 1000}
                              };

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


        static double CalculateAverageScore(int[] scores) {
            double total = 0.0;

            total = SumArray(scores);

            return (total / scores.Length);
        }// end CalculateAverageScore


        static int SumArray(int[] scores) {
            int total = 0;

            foreach (int score in scores) {
                total += score;
            }

            return total;
        }//end SumArray


        static void DisplayArray(int[] scores) {

            foreach (int element in scores) {
                Console.Write("{0,5}", element);
            }//end foreach
        }//end DisplayArray

        static void Display2DArray(int[][] results, int[] scores) {
            Console.WriteLine("\n");

            for (int row = 0; row < results.GetLength(0); row++) {

                Console.Write("Player {0} your scores are", row + 1);
                DisplayArray(results[row]);
                Console.WriteLine(" which is a total of {0}\n", scores[row]);

            }//end for

        }//end Display2DArray

        static void DisplayOverallResults(int total, double average, int[] scores) {

            Console.WriteLine("\n\nOverall {0} was scored by {1} players at an average of {2:f} per player\n\n", total, scores.Length, average);
        }//end DisplayOverallResults

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    }//end class
}//end namespace
