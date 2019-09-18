using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_SuperHeroes {
    class Human : SuperHero {

        public Human(string name, string secretId) : 
            base(name, secretId) {
        }

        public override bool HasPower(SuperPower whatPower) {
            return false;
        }

        public override int TotalPower() {
            return 0;
        }
    }
}
