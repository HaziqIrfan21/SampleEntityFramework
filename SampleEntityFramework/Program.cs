using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleEntityFramework
{
    [Table("MyTable")]
    public class Student
    {
        [Column("StudentName",TypeName ="text")]
        public string Name { get; set; }
        public string Address { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public School School { get; set; }
    }

    
    //public class FormerStudent : Student
    //{
    //    public int PassYear { get; set; }
    //    public School School { get; set; }
    //}
    
    //public class CurrentStudent : Student
    //{
    //    public int CurrentGrade { get; set; }
    //    public School School { get; set; }
    //}
    public class School
    {
        public string Name { get; set; }
        public int SchoolID { get; set; }
        //public List<Student> StudentList { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to first EF demo");
            using (StudentManagementContext stuContext = new StudentManagementContext())
            {
                Student student1 = new Student() {StudentID=1, Name = "Irfan" };
                School school1 = new School() { Name = "Singapore International School" };
                student1.School = school1;
                //FormerStudent student2 = new FormerStudent() { StudentID = 2, Name = "Marvin" };
                //student2.School = school1;
                //CurrentStudent student3 = new CurrentStudent() { StudentID = 3, Name = "Han" };
                //student3.School = school1;
                stuContext.Schools.Add(school1);
                stuContext.Students.Add(student1);
                //stuContext.Students.Add(student2);
                //stuContext.Students.Add(student3);
                stuContext.SaveChanges();
            }
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
