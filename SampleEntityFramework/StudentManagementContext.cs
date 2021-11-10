using System.Data.Entity;

namespace SampleEntityFramework
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext() : base("Name=SchoolManagementDBConnectionString")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<StudentManagementContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentManagementContext>());
           // Database.SetInitializer(new DropCreateDatabaseAlways<StudentManagementContext>());
            //Database.SetInitializer(new );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
