using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleEntityFramework
{
    //[Table("MyTable")]
    public class Student
    {
       // [Column("StudentName", Order = 1)]
        //[MinLength(5)]
        public string Name { get; set; }
        //[Column("StudentAddress", Order = 0)]
        //[MaxLength(20)]
        //[Required]
        public string Address { get; set; }
        //[Column("RollNumber", Order = 2)]
        //[Key]
        public int StudentRollNumber { get; set; }
        //[Column("StudentID", Order = 3)]
        //[Key]
        //public int StudentUniqueIdentifier { get; set; }
        //[NotMapped]
        public string StudentRemarks { get; set; }
        //[Timestamp]
        //public byte[] RowVersion { get; set; }
        //[ConcurrencyCheck]
        //public string RowIdentifier { get; set; }
         public int StudentID { get; set; }
        //ComplexType
        //ConcurrencyCheck
        //Multiple-Column Indexes
        //[Index]
        //public int StudentRank { get; set; }
        public List<School> SchoolStudied { get; set; }
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
        public List<Student> Studentenrolled { get; set; }
    }

    public class StudentDetails
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public Student Student { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to first EF demo");
            using (StudentManagementContext stuContext = new StudentManagementContext())
            {
                //Student student1 = new Student() {Name = "Irfan" , Address="Pearson Vue, 1"};
                //School school1 = new School() { Name = "Irfan"};
                ////School school1 = new School() { Name = "Singapore International School" };
                ////student1.School = school1;
                ////FormerStudent student2 = new FormerStudent() { StudentID = 2, Name = "Marvin" };
                ////student2.School = school1;
                ////CurrentStudent student3 = new CurrentStudent() { StudentID = 3, Name = "Han" };
                ////student3.School = school1;
                ////stuContext.Schools.Add(school1);
                //List<School> schoolList = new List<School>();
                //schoolList.Add(school1);
                //List<Student> stuList = new List<Student>();
                //stuList.Add(student1);
                //student1.SchoolStudied = schoolList;
                //school1.Studentenrolled = stuList;
                //stuContext.Students.Add(student1);
                //stuContext.Schools.Add(school1);
                //stuContext.Students.Add(student2);
                //stuContext.Students.Add(student3);
                //stuContext.SaveChanges();
                Student student1 = new Student() {Name = "Han" , Address="Pearson Vue, 1"};
                School school1 = new School() { Name = "Han"};
                stuContext.Schools.Add(school1);
                stuContext.Students.Add(student1);
                stuContext.SaveChanges();
            }
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
