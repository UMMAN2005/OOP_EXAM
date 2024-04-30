using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    internal static class Calculator {
        public static int CalculateScore(int TasksCompleted, int TasksFailed, int BonusTasksCompleted) {
            int totalScore =  (TasksCompleted + BonusTasksCompleted) - TasksFailed;
            if (totalScore < 0) {
                return 0;
            }
            return totalScore;
        }

        public static float CalculateAverageScore(List<Student> students) {
            int totalScore = 0;
            foreach (Student student in students) {
                totalScore += student.TotalScore;
            }
            return (float)totalScore / students.Count;
        }
    }
}
