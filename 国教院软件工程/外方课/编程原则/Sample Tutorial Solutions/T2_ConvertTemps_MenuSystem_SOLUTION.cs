using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturePrep {

    class L3_TempConversions_IncrementalDev {

        static void Main() {

            int menuOption;
            double temperature;
            double newTemperature;
            bool repeat = true;

            WelcomeMessage();

            while (repeat) {

                DisplayMenu();
                menuOption = ReadOption();
                if (menuOption != 5) {
                    temperature = InputTemp();

                    // what type of conversion is required?
                    if (menuOption == 1) {
                        newTemperature = CelsiusToFahrenheit(temperature);
                    } else if (menuOption == 2) {
                        newTemperature = FahrenheitToCelsius(temperature);
                    } else if (menuOption == 3) {
                        newTemperature = CelsiusToKelvin(temperature);
                    } else if (menuOption == 4) {
                        newTemperature = KelvinToCelsius(temperature);
                    }

                    repeat = AnotherCalculation();

                } 
                // the user must have entered 5 to exit
                else {
                    repeat = false;
                } // end outer conditional block

            } // end while

            ExitProgram();

        }//end Main


        // Determines if the user wants to perform another calculation
        public static bool AnotherCalculation() {

            string answer;

            Console.Write("Another Calculation? (y / n): ");
            answer = Console.ReadLine();

            while (answer != "n" && answer != "N" && answer != "y" && answer != "Y") {
                Console.WriteLine("Please enter 'y' or 'n': ");
                Console.Write("Another Calculation? (y / n): ");
                answer = Console.ReadLine();
            }

            answer = answer.ToLower();
            if (answer == "y") {
                return true;
            } else {
                return false;
            }
        }

    // Conversion methods
    // Simply 'stubs' - calculations needed to be added
    public static double CelsiusToFahrenheit(double temp) {
            Console.WriteLine("In CtoF");
            return 0.0;
        }


        public static double FahrenheitToCelsius(double temp) {
            Console.WriteLine("In FtoC");
            return 0.0;
        }

        public static double CelsiusToKelvin(double temp) {
            Console.WriteLine("In CtoK");
            return 0.0;
        }

        public static double KelvinToCelsius(double temp) {
            Console.WriteLine("In KtoC");
            return 0.0;
        }

        // Gets decimal value representing a temperature
        // and returns it
        // post: value returned in a decimal value
        static double InputTemp() {

            double aTemp;
            bool ok = false;

            do {
                Console.Write("Enter a temperature: ");
                ok = double.TryParse(Console.ReadLine(), out aTemp);
                if (!ok) {
                    Console.WriteLine("You did not enter a decimal value.");
                    Console.Write("Please try again\n\n");
                }
            } while (!ok);

            return aTemp;


        } // end InputTemp


        static void DisplayMenu() {
            string menu = "Please choose from one of the following options:"
                + "\n1.  Convert Celsius to Fahrenheit"
                + "\n2.  Convert Fahrenheit to Celsius"
                + "\n3.  Convert Celsius to Kelvin"
                + "\n4.  Convert Kelvin to Celsius"
                + "\n5.  Exit this program\n\n"
                + "\n\nEnter your option from 1 to 5: ";

            Console.Write(menu);
        } //end DisplayMenu

        static void WelcomeMessage() {
            Console.WriteLine("Welcome to the Temperature Conversion Calculator!\n\n");
        }//end WelcomeMessage



        static void ExitProgram() {
            Console.Write("\n\n Thanks for using my calculator!!\n\n");
        }//end ExitProgram


        // post: returns integer value between 1 and 5
        static int ReadOption() {
            string choice;
            int option;
            bool okayChoice;

            do {
                choice = Console.ReadLine();
                okayChoice = int.TryParse(choice, out option);
                if (!okayChoice || (option > 5 || option < 1)) {
                    okayChoice = false;
                    Console.WriteLine("You did not enter a correct option.");
                    Console.Write("Please try again\n\n");
                    DisplayMenu();
                }
            } while (!okayChoice);

            return option;
        } //end ReadOption


    }
}





