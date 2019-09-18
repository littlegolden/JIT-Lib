using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {

    /// <summary>
    /// 
    /// This enumeration lists various super powers commonly available to comic book superheroes
    /// and associates a (subjective) value with each superpower.
    /// This list of powers is by no means comprehensive.
    /// 
    /// Adapted from a Java enumeration, SuperPower.java created by Colin Fidge 
    /// for INB370/CAB302 Software Development.
    /// 
    /// Modified to C# April 2016. Mike Roggenkamp
    /// 
    /// </summary>
    public enum SuperPower {
        Flight = 100,
        SuperStrength = 75,
        XRayVision = 20,
        SuperSpeed = 40,
        Invulnerability =150,
        SuperIntellect = 90
    }

    /// <summary>
    /// A SuperHero has two alternative identities
    /// and may have various super powers or none at all.
    /// 
    /// This class is based on the SuperHero class, SuperHero.java written by Colin Fidge
    /// for INB370/CAB302 Software Development.
    /// 
    /// Modifications: 
    /// April 2016 Mike Roggenkamp
    /// August 2016 Donna Teague
    /// 
    /// </summary>
    public abstract class SuperHero {

        // Instance variables
        private string currentIdentity;
        private string otherIdentity;

        // Constructor       
        public SuperHero(string trueIdentity, string alterEgo) {
            currentIdentity = trueIdentity;
            otherIdentity = alterEgo;
        }

        // Property
        public string CurrentIdentity {
            get {
                return currentIdentity;
            }
        }//end CurrentIdentity


        public int GetPowerValue(SuperPower power) {
            return (int) power;
        }//end GetPowerValue

        public virtual void SwitchIdentity() {

            // CODE TO BE WRITTEN
            string temp = CurrentIdentity;
            currentIdentity = otherIdentity;
            otherIdentity = temp;            

        }//end SwitchIdentity


        // Abstract methods to be implemented by subclasses
        public abstract bool HasPower(SuperPower whatPower);
        public abstract int TotalPower();

        
    }//end class
}
