using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAreFun {
    class Superhero : Person {

        private string _Identity;

        public string Identity {
            get { return _Identity; }
            set { _Identity = value; }
        }

        public override string Shout() {
            return "Up up and away";
        }

        public override string ToString() {
            return "Super " + base.ToString();
        }

    }
}
