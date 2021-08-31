using System;
using System.Collections.Generic;

namespace DelegatesExample.Examples
{
    internal delegate bool IsPassedExam(int totalScore);

    internal class Student
    {
        private readonly int _totalScore;

        private string Name { get; set; }

        internal Student(string name, int totalScore)
        {
            Name = name;
            _totalScore = totalScore;
        }

        internal void CheckIfPassed(IsPassedExam isPassedExam)
        {
            if (isPassedExam(_totalScore))
            {
                Console.WriteLine($"Student {Name} passed the exam");
            }
            else
            {
                Console.WriteLine($"Student {Name} failed the exam");
            }
        }
    }

    internal class StudentExamExample
    {
        private static bool ConditionForPassing(int score) => score > 50;

        internal static void Run()
        {
            var students = new List<Student>
            {
                new Student("Hari", 90),
                new Student("Tom", 98),
                new Student("John", 46),
                new Student("James", 49)
            };

            var isPassedExam = new IsPassedExam(ConditionForPassing);

            foreach (var student in students)
            {
                student.CheckIfPassed(isPassedExam);
            }
        }
    }
}
