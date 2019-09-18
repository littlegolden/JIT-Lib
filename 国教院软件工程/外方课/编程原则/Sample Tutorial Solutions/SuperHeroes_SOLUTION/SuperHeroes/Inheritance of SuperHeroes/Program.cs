using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {
    /// <summary>
    ///
    /// This class is based on the SuperHero class, HeroTester.java 
    /// created by Colin Fidge for INB370/CAB302 Software Development.
    ///
    /// It is a simple test driver for the subclasses of the SuperHero class
    /// 
    /// The subclassses are develop as a Workshop activity
    /// 
    /// Modifications: April 2016 Mike Roggenkamp
    ///  Converted to C# and C# Coding Sytle Convention used in CAB201
    /// 
    /// </summary>
    class Program {


        static void Main(string[] args) {

            TestHumans();

            TestEnhancedHumans();

            TestSuperHumans();

            Console.Write("\n\n\nPress any key to exit ...");
            Console.ReadKey();

        }// end Main

        /*
         ************************************************************
         *                                                          *
         *  DO NOT UNCOMMENT THE METHODS BELOW UNTIL TOLD TO DO SO  *
         *  BY THE WORKSHEEET ACTIVITY                              *
         *                                                          *
         ************************************************************
         */


        static void TestHumans() {

            Human Batman = new Human("Bruce Wayne", "Batman");
            Human BlackCanary = new Human("Dinah Drake", "Black Canary");

            Console.WriteLine("TESTING HUMANS ***********************************************");
            Console.WriteLine("\nH1: In his normal identity Batman has no superpowers:\n[Bruce Wayne, 0]:\t\t {0}, {1}\n", Batman.CurrentIdentity,
                                            Batman.TotalPower());

            Batman.SwitchIdentity();

            Console.WriteLine("\nH2: After switching identity still has no powers:\n[Batman, 0]:\t\t\t {0}, {1}\n", Batman.CurrentIdentity,
                                            Batman.TotalPower());

            Console.WriteLine("\nH3: Can Batman fly with his cape?\n[No]:\t\t\t\t {0}\n", (Batman.HasPower(SuperPower.Flight) ? "Yes" : "No"));

            Console.WriteLine("\nH4: Batman's identity switch does not alter Black Canary's id:\n[Dinah Drake]:\t\t\t {0}\n", BlackCanary.CurrentIdentity);

            BlackCanary.SwitchIdentity();

            Console.WriteLine("\nH5: Only Dinah Drake can change her idenity:\n[Black Canary]:\t\t\t {0}\n", BlackCanary.CurrentIdentity);

            Console.WriteLine("\nH6: After switching identity Black Canary has no powers:\n[Black Canary, 0]:\t\t {0}, {1}\n", BlackCanary.CurrentIdentity,
                                    BlackCanary.TotalPower());

        }//end TestHumans



        static void TestEnhancedHumans() {

            Console.WriteLine("TESTING ENHANCED HUMANS **************************************");

            Enhanced_Human CaptainMarvel = new Enhanced_Human("Billy Batson", "Captain Marvel", new List<SuperPower> {  SuperPower.Flight,SuperPower.SuperStrength,
                                                                                               SuperPower.Invulnerability});
            Enhanced_Human GreenLanteen = new Enhanced_Human("Hal Jordan", "Green Lanteen", new List<SuperPower> { SuperPower.Flight, SuperPower.SuperStrength,
                                                                                                SuperPower.SuperSpeed, SuperPower.Invulnerability});




            Console.WriteLine("\nEH1: As a mortal Captain Marvel is meek and has no super powers:\n[Billy Batson, 0]:\t\t {0}. {1}\n",
                                       CaptainMarvel.CurrentIdentity, CaptainMarvel.TotalPower());

            CaptainMarvel.SwitchIdentity();

            Console.WriteLine("\nEH2: After Billy Batson says the magic word SHAZAM he becomes who?\n[Captain Marvel, 325]:\t\t {0}, {1}\n",
                                CaptainMarvel.CurrentIdentity, CaptainMarvel.TotalPower());


            Console.WriteLine("\nEH3: Does Captain Marvel have super strength?\n[Captain Marvel, Yes]:\t\t {0}, {1}\n", CaptainMarvel.CurrentIdentity,
                                                                                            (CaptainMarvel.HasPower(SuperPower.SuperStrength) ? "Yes" : "No"));


            Console.WriteLine("\nEH4: Does Captain Marvel have X-ray vision?\n[Captain Marvel, No]:\t\t {0}, {1}\n", CaptainMarvel.CurrentIdentity,
                                                                                            (CaptainMarvel.HasPower(SuperPower.XRayVision) ? "Yes" : "No"));


            Console.WriteLine("\nEH5: Green Lanteen was born a normal human:\n[Hal Jordan, 0]:\t\t {0}, {1}\n", GreenLanteen.CurrentIdentity, GreenLanteen.TotalPower());

            GreenLanteen.SwitchIdentity();

            Console.WriteLine("\nEH6 But he can use his power ring to be a superhero:\n[GreenLantern, 365]:\t\t {0}, {1}\n", GreenLanteen.CurrentIdentity,
                                                                   GreenLanteen.TotalPower());
            GreenLanteen.SwitchIdentity();

            Console.WriteLine("\nEH7: But unless he recharges his ring every day he changes back:\n[Hal Jordan, 0]:\t\t {0}, {1}\n", GreenLanteen.CurrentIdentity,
                                                                   GreenLanteen.TotalPower());


        }//end TestEnhancedHumans



        static void TestSuperHumans() {

            Console.WriteLine("TESTING SUPER HUMANS *****************************************");
            Super_Human WonderWoman = new Super_Human("Wonder Woman", "Diana Prince", new List<SuperPower> { SuperPower.SuperStrength, SuperPower.SuperIntellect });

            Super_Human Superman = new Super_Human("Superman", "Clark Kent", new List<SuperPower> {SuperPower.Flight, SuperPower.SuperStrength, SuperPower.XRayVision,
                                                                                              SuperPower.SuperSpeed, SuperPower.Invulnerability});
            Console.WriteLine("\nSH1: When Superman came to Earth he already had super powers\n[Superman, 385]:\t\t {0}, {1}\n", Superman.CurrentIdentity, Superman.TotalPower());

            Superman.SwitchIdentity();

            Console.WriteLine("\nSH2: He retains his super powers even in his secret identity:\n[Clark Kent, 385]:\t\t {0}, {1}\n", Superman.CurrentIdentity, Superman.TotalPower());

            Superman.LoseAllSuperPowers();

            Console.WriteLine("\nSH3: However when exposed to kryponite he loses all of his powers:\n[Clark Kent, 0]:\t\t {0}, {1}\n", Superman.CurrentIdentity, Superman.TotalPower());

            Console.WriteLine("\nSH4: But kryponite has no effect on Wonder Woman who has all of her powers:\n[Wonder  Women, 165]:\t\t {0}, {1}\n", WonderWoman.CurrentIdentity, WonderWoman.TotalPower());

            WonderWoman.SwitchIdentity();

            Console.WriteLine("\nSH5: when she switches to her plain identity she still has \"Wisom of Athena\":\n[Diana Prince, Yes]:\t\t {0}, {1}\n", WonderWoman.CurrentIdentity,
                                                                        (WonderWoman.HasPower(SuperPower.SuperIntellect) ? "Yes" : "No"));


            //   ADD CALL TO YOUR METHOD TO REINSTATE SUPER_HUMAN POWERS 

            //Console.WriteLine("\nSH6: Fortuantely if the kryptonite is removed, \nSuperman regains his original powers:\n[Clark Kent, 385]:\t\t {0}, {1}", Superman.CurrentIdentity, Superman.TotalPower());

        }//end TestSuperHumans



    }//end class
}//end namespace
