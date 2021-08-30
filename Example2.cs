using System;
using System.Collections.Generic;

namespace DelegatesExample
{
    internal delegate bool IsPassedExam(int totalMarks);

    internal class Student
    {
        private readonly int TotalMarks;

        private string Name { get; set; }

        internal Student(string name, int totalMarks)
        {
            Name = name;
            TotalMarks = totalMarks;
        }

        internal void CheckIfPassed(IsPassedExam isPassedExam)
        {
            if (isPassedExam(TotalMarks))
            {
                Console.WriteLine($"Student {Name} passed the exam");
            }
            else
            {
                Console.WriteLine($"Student {Name} failed the exam");
            }
        }
    }

    internal class Example2
    {
        private static bool ConditionForPassing(int marks) => marks > 50;

        internal static void Run()
        {
            var students = new List<Student>
            {
                new Student("Hari",90),
                new Student("Tom",98),
                new Student("John",46),
                new Student("James",49)
            };

            var isPassedExam = new IsPassedExam(ConditionForPassing);

            foreach (var student in students)
            {
                student.CheckIfPassed(isPassedExam);
            }
        }
    }
}
