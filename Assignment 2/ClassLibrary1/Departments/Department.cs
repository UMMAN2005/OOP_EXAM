using System;
using System.Collections.Generic;
using ClassLibrary1.Workers;

namespace ClassLibrary1.Departments {
    public abstract class Department {
        public int Budget { get; protected set; }

        public List<Worker> Workers { get; private set; }

        public uint NumberOfWorkers { get; private set; }

        public Department() {
            Random random = new();
            Budget = random.Next(5000, 10000);
            NumberOfWorkers = 0;
            Workers = [];
        }

        public void Hire(Worker worker) {
            NumberOfWorkers++;
            Workers.Add(worker);
        }

        public void Fire(Worker worker) {
            if (!Workers.Contains(worker)) {
                return;
            }
            Workers.Remove(worker);
            NumberOfWorkers--;
        }
    }
}
