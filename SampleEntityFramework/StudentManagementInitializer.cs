using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SampleEntityFramework
{
    public class StudentManagementInitializer : DropCreateDatabaseAlways<StudentManagementContext>
    {
        protected override void Seed(StudentManagementContext context)
        {
            Student student1 = new Student() { Name = "Irfan", Address = "Pearson Vue, 1" };
            School school1 = new School() { Name = "Irfan" };
            List<School> schoolList = new List<School>();
            schoolList.Add(school1);
            List<Student> stuList = new List<Student>();
            stuList.Add(student1);
            student1.SchoolStudied = schoolList;
            school1.Studentenrolled = stuList;
            context.Students.Add(student1);
            context.Schools.Add(school1);
            base.Seed(context);
        }
    }
}
