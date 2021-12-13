﻿namespace CourseApp.Models
{
    public class Repository
    {
        private static List<Student> _students = new List<Student>();
        //Repository.Students
        public static List<Student> Students 
        {
            get 
            {
                return _students; 
            }
        }
        //repository.AddStudent(student);
        public static void AddStudent(Student student)
        { 
            _students.Add(student); 
        }
    }
}
