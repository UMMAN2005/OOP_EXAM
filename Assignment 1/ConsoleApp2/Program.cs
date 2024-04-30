using ConsoleApp2;

List<Student> students = new();
uint n;
do {
    Console.Write("Enter the number of students: ");
} while (!uint.TryParse(Console.ReadLine(), out n));

for (int i = 0; i < n; i++) {
    Student student = new(i + 1);
    students.Add(student);
    Console.WriteLine($"Student {student.Id} has a total score of {student.TotalScore}");
}

Console.WriteLine($"The average score is {Calculator.CalculateAverageScore(students)}");
