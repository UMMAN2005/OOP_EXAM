using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Workers {
    public class BusinessAnalysts : Worker {

        private enum Teaming {
            Income, Taxing
        }

        private Teaming Team { get; }

        public BusinessAnalysts(string name, int salary, int money) : base(name, salary, money) {
            Random random = new();
            Team = (Teaming)random.Next(0, 2);
        }

        protected override void Work(int hours) {
            switch(Team) {
                case Teaming.Income:
                    Money += hours * Salary * 4;
                    break;
                case Teaming.Taxing:
                    Money += hours * Salary * 2;
                    break;
            }
        }
    }
}
