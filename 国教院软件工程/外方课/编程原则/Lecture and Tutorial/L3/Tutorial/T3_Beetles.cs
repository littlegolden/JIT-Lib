using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD121 {

    /// <summary>
    /// Program to practice using a List 
    /// </summary>
    class W4_Beetles {

        static void Main(string[] args) {

            Console.WriteLine("\nWelcome to The Beetles - Member Trivia\n\n");

            // An string array containing the names of some people 
            // who have been members of The Beetles:
            string[] beetleNames = new string[] {
                "John Lennon",
                "Andy White",
                "Stuart Sutcliffe",
                "Paul McCartney",
                "Pete Best",
                "Jimmie Nicol",
                "Ringo Starr",
                "George Harrison" };

            // An string array containing the names of some 
            // temporary members of The Beetles:
            string[] ringIns = new string[] {
                "Andy White",
                "Stuart Sutcliffe",
                "Pete Best",
                "Jimmie Nicol"};


            // Create the LIST of the members of The Beetles
            List<string> theBeetlesList = new List<string>();

            // 1.  Using a FOREACH loop, add each of the elements
            //     of the array BeetleNames to the list theBeetlesList





            Console.WriteLine("Some people who have been Beetles are:");

            // 2.  Output the contents of the theBeetleslist to the screen



            // 3.  Using a FOR loop, delete all but the well-known members of the band.
            //     That is, delete all of the names from the list
            //     that are contained in the array ringIns

            Console.WriteLine("But the REAL Beetles are only:");

            // 4.  Output the new contents of the list to the screen





            Console.WriteLine("\nBye!");
        }
    }
}


