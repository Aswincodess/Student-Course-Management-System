
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentCourseManagement
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        // 1. Add Student
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        // 2. List Students
        public void ListStudents()
        {
            Console.WriteLine("\n=== Registered Students ===");

            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Course ID: {student.CourseId}");
                Console.WriteLine("--------------------");
            }
        }

        // 3. Update Student
        public void UpdateStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine() ?? "";

            Console.Write("Enter new age: ");
            student.Age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter new course ID: ");
            student.CourseId = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Student updated successfully!");
        }

       
        public void DeleteStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            students.Remove(student);

            Console.WriteLine("Student deleted successfully!");
        }

        public void FilterStudentsAboveAge(int age)
        {
            var result = students.Where(s => s.Age > age);

            Console.WriteLine($"\n=== Students Above Age {age} ===");

            foreach (Student student in result)
            {
                Console.WriteLine(
                    $"{student.Name} - Age: {student.Age}");
            }
        }


        public void GetStudentsByCourse(int courseId)
        {
            var result = students.Where(s => s.CourseId == courseId);

            Console.WriteLine(
                $"\n=== Students in Course {courseId} ===");

            foreach (Student student in result)
            {
                Console.WriteLine(
                    $"{student.Name} - Course ID: {student.CourseId}");
            }
        }
    }
}
