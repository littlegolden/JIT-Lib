using System;

namespace CoinApplication {
   /// <summary>
   /// Coin.cs is based on Coin.java written
   /// by Author: Lewis/Loftus "Java Software Solutions"
   /// 
   /// Represents a coin with two sides that can be flipped.
   /// 
   /// Modification: 
   /// April 2009 by Mike Roggenkamp
   ///      Converted to C# and C# Coding Sytle Convention used in INB270/INN270
   ///      
   /// August 2015 by Mike Roggenkamp for CAB201
   ///      use enumeration Coin_Face rather than named constants to represent Heads and Tails
   /// 
   /// 
   /// </summary>
    class Coin {

        private enum Coin_Face {Heads, Tails};
        
        private Coin_Face face;

        /// <summary>
        /// Random class object used to generate random numbers
        /// 
        /// Decared as static so every Coin object uses the single  
        /// sequence of random values rather than each Coin having its
        /// own sequence of random values
        /// 
        /// Look at Random class for description of methods available
        /// </summary>
        private static Random randomValue = new Random();

       
        /// <summary>
        /// Sets up the coin by flipping it initially.
        /// </summary>
        public Coin() {
            Flip();
        }//end Coin

        
        /// <summary>
        /// Flips the coin by randomly choosing a face value Heads or TailsS
        /// </summary>
        public void Flip() {
            int value = randomValue.Next(2);
            face = (Coin_Face)value;
        }//end Flip

        
        /// <summary>
        /// Tests if the current face is a Head
        /// </summary>
        /// <returns> Returns true if the current face of the coin is heads otehrwise returns false</returns>
        public bool IsHeads() {

            return (face == Coin_Face.Heads);
        }//end IsHeads
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:CoinApplication.Coin"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:CoinApplication.Coin"/>.</returns>

     
        /// <summary>
        /// Returns the current face of the coin as a string.
        /// </summary>
        /// <returns>the current face</returns>
        public override string ToString() {
            
            return face.ToString();
        } //end ToString

    } //end class Coin

}

