using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturePrep {
    using System.Diagnostics;

    class ShoeStock {

        private int inventoryNumber;
        private string shoeStyle;
        private int numberAvailable;

        // Constructor
        public ShoeStock(int inventoryNumber, string shoeStyle, int numberAvailable) {
            this.inventoryNumber = inventoryNumber;
            this.shoeStyle = shoeStyle;
            this.numberAvailable = numberAvailable;
        }

        // Properties
        // read only
        public int InventoryNumber {
            get {
                return this.inventoryNumber;
            }
        }

        // read only property
        public string ShoeStyle {
            get {
                return this.shoeStyle;
            }
        }

        // read+write property
        public int NumberAvailable {
            get {
                return this.numberAvailable;
            }
            set {
                this.numberAvailable = value;
            }
        }

        /// <summary>
        /// Is the shoe in stock?
        /// </summary>
        /// <returns>true if there is at least one in stock
        /// otherwise, returns false</returns>
        public bool ShoeInStock() {
            return (this.numberAvailable > 0);
        }

        /// <summary>
        /// Should the shoe be reordered?
        /// </summary>
        /// <returns>true if there is less than 10 in stock
        /// false otherwise</returns>
        public bool Reorder() {
            return (this.numberAvailable < 10);
        }

        public override string ToString() {
            string output = " (#" + InventoryNumber + ") '" + ShoeStyle + "'";

            if (ShoeInStock()) {
                output += "\tCurrently " + NumberAvailable + " in stock.";
            } else {
                output += "\tOut of stock!\t";
            }

            if (Reorder()) {
                output += "\t* NEED TO REORDER!";
            }

            return output;
        }
    } // end ShoeStock Class

    public class ShoeTester {

        public static void Main() {

            // Create a list of shoes
            List<ShoeStock> myList = new List<ShoeStock>();

            myList.Add(new ShoeStock(10001, "Flats", 115));
            myList.Add(new ShoeStock(20123, "Joggers", 47));
            myList.Add(new ShoeStock(77777, "Heels", 2));
            myList.Add(new ShoeStock(87456, "Courts", 12));
            myList.Add(new ShoeStock(87456, "Ughs", 0));

            // output info about each shoe
            foreach (ShoeStock shoe in myList) {
                Console.WriteLine(shoe.ToString());
            }
        }
    }
}

