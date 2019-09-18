using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {
    class Super_Human : SuperHero {

        private int sumOfPowers = 0;
        private List<SuperPower> powerSet;

        public Super_Human(string name, string secretId, List<SuperPower> myPowers) : base(name, secretId) {
            powerSet = myPowers;

            foreach (SuperPower sp in powerSet) {
                sumOfPowers += GetPowerValue(sp);
            }
        }

        public override bool HasPower(SuperPower whatPower) {
            return (powerSet.Contains(whatPower));
        }

        public override int TotalPower() {
            return sumOfPowers;
        }

        public void AddSuperPower(SuperPower newPower) {
            if (!powerSet.Contains(newPower)) {
                powerSet.Add(newPower);
                sumOfPowers += GetPowerValue(newPower);
            }
        }

        public void LoseSinglePower(SuperPower power) {
            if (powerSet.Contains(power)) {
                powerSet.Remove(power);
                sumOfPowers -= GetPowerValue(power);
            }
        }

        public void LoseAllSuperPowers() {
            powerSet = new List<SuperPower>();
            sumOfPowers = 0;
        }
    }
}
