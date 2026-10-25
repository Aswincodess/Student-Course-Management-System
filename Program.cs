
using System;
using StudentCourseManagement;

Console.WriteLine("Student-Course Management System");

StudentManager studentManager = new StudentManager();
CourseManager courseManager = new CourseManager();

Course course1 = new Course();
course1.CourseId = 101;
course1.CourseName = "C# .NET";

Course course2 = new Course();
course2.CourseId = 102;
course2.CourseName = "Angular";

courseManager.AddCourse(course1);
courseManager.AddCourse(course2);

courseManager.ListCourses();

Student student1 = new Student();
student1.Id = 1;
student1.Name = "Aswin";
student1.Age = 21;
student1.CourseId = 101;

Student student2 = new Student();
student2.Id = 2;
student2.Name = "appus";
student2.Age = 22;
student2.CourseId = 102;

Student student3 = new Student();
student3.Id = 3;
student3.Name = "Arun";
student3.Age = 19;
student3.CourseId = 101;

studentManager.AddStudent(student1);
studentManager.AddStudent(student2);
studentManager.AddStudent(student3);

studentManager.ListStudents();

studentManager.FilterStudentsAboveAge(20);

studentManager.GetStudentsByCourse(101);

Console.WriteLine("\n=== Update Student ===");
studentManager.UpdateStudent(2);

studentManager.ListStudents();

Console.WriteLine("\n=== Delete Student ===");
studentManager.DeleteStudent(3);

studentManager.ListStudents();

Console.WriteLine("\nProject completed!");
Console.ReadKey();
