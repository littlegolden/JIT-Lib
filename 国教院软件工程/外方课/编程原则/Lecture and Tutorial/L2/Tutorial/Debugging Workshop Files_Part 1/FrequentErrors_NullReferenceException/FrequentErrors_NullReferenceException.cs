using System;

namespace FrequentErrors_NullReferenceException {

    class FrequentErrors_NullReferenceException {

        static string myString;  

        static void Main(string[] args) {
            // Note that myString is NOT initialised, before we try to use it.
            // I.e. we are demonstrating a frequent bug.
            displayStringLength();

            string result = returnsString(false);
            string uppercase = result.ToUpper();
            Console.WriteLine(uppercase);
        }

        static void displayStringLength() {
            Console.WriteLine("String length is: {0}.", myString.Length);
        }

        static string returnsString(bool ok) {
            if (ok) {
                return "Hi there.";
            } else {
                return null;
            }
        }
    }
}
