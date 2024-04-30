using System;

namespace ClassLibrary1.Workers {
    public class Fisher : Worker {
        private enum Specification {
            Fishing, Loading, Driving
        }

        private Specification Speciality { get; }

        public Fisher(string name, int salary, int money) : base(name, salary, money) {
            Random random = new();

            Speciality = (Specification)random.Next(0, 3);
        }

        protected override void Work(int hours) {
            switch (Speciality) {
                case Specification.Fishing:
                    Money += hours * Salary * 2;
                    break;
                case Specification.Loading:
                    Money += hours * Salary * 3;
                    break;
                case Specification.Driving:
                    Money += hours * Salary * 4;
                    break;
            }
        }
    }
}
