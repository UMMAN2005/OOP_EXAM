using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Workers {
    public class Worker {
        public string Name { get; private set; }
        protected int Salary { get; private set; }
        protected int Money { get; set; }

        public Worker(string name, int salary, int money) {
            Name = name;
            Salary = salary;
            Money = money;
        }

        protected virtual void Work(int hours) {
            Money += hours * Salary;
        }
    }
}
