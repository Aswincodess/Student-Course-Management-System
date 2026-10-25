
using System;
using System.Collections.Generic;

namespace StudentCourseManagement
{
    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

    
        public void AddCourse(Course course)
        {
            courses.Add(course);

            Console.WriteLine("Course added successfully!");
        }

  
        public void ListCourses()
        {
            Console.WriteLine("\n=== Available Courses ===");

            foreach (Course course in courses)
            {
                Console.WriteLine($"Course ID: {course.CourseId}");
                Console.WriteLine($"Course Name: {course.CourseName}");
                Console.WriteLine("--------------------");
            }
        }
    }
}
