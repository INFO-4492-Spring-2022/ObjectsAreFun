using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAreFun {
    class Villian : Person {
        private string _Minion;

        public string Minion{
            get { return _Minion; }
            set { _Minion = value; }
        }



        public override string Shout() {
            return "You dirty rascal";
        }

        public override string ToString() {
            return "Bad guy";
        }

    }
}
