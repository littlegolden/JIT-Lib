using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {
    class Enhanced_Human : SuperHero {

        private int sumOfPowers = 0;
        private bool enhanced = false;
        private List<SuperPower> powerSet;

        public Enhanced_Human(string name, string secretId, List<SuperPower> myPowers) : base(name, secretId) {
            powerSet = myPowers;

            foreach (SuperPower sp in powerSet) {
                sumOfPowers += GetPowerValue(sp);
            }
        }

        public override void SwitchIdentity() {
            base.SwitchIdentity();
            enhanced = !(enhanced);
        }

        public override bool HasPower(SuperPower whatPower) {
            return (enhanced && powerSet.Contains(whatPower));
        }

        public override int TotalPower() {
            if (enhanced) {
                return sumOfPowers;
            } else {
                return 0;
            }

        }
    }
}
