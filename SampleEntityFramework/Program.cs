using System;
using System.Collections.Generic;

namespace SampleEntityFramework
{
    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int StudentID { get; set; }
        public School School { get; set; }
    }
    public class School
    {
        public string Name { get; set; }
        public int SchoolID { get; set; }
        public List<Student> StudentList { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to first EF demo");
            using (StudentManagementContext stuContext = new StudentManagementContext())
            {
                Student student1 = new Student() { Name = "Irfan" };
                School school1 = new School() { Name = "Singapore International School" };
                student1.School = school1;
                stuContext.Schools.Add(school1);
                stuContext.Students.Add(student1);
                stuContext.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
