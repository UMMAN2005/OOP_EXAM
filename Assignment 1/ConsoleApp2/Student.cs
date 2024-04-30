using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    internal class Student {
        Random random = new();

        private int _id;

        public int Id {
            get => _id;
            init {
                if (value < 1) {
                    throw new ArgumentException("Student ID must be greater than 0");
                }
                _id = value;
            }
        }
        public int TasksCompleted { get; }
        public int TasksFailed { get; }
        public int BonusTasksCompleted { get; }
        public int TotalScore { get; }

        public Student(int id) {
            Id = id;
            TasksCompleted = random.Next(0, 21);
            int remainingTasks = 20 - TasksCompleted;
            TasksFailed = random.Next(0, remainingTasks + 1);
            BonusTasksCompleted = random.Next(0, 6);
            TotalScore = Calculator.CalculateScore(TasksCompleted, TasksFailed, BonusTasksCompleted);
        }
    }

}
