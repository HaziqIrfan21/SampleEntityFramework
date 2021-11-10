using System.Data.Entity;

namespace SampleEntityFramework
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext() : base("Name=SchoolManagementDBConnectionString")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<StudentManagementContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentManagementContext>());
            Database.SetInitializer(new DropCreateDatabaseAlways<StudentManagementContext>());
            //Database.SetInitializer(new );
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.HasDefaultSchema("My");
            //modelBuilder.Entity<Student>().ToTable("MyTable", "MyTableSchema");
            modelBuilder.Entity<Student>().HasRequired(s => s.SchoolStudied).WithRequiredPrincipal(t => t.Studentnrolled);
            //modelBuilder.Entity<Student>()
            //modelBuilder.Entity<FormerStudent>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("FormerStudent");
            //});
            //modelBuilder.Entity<CurrentStudent>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("CurrentStudent");
            //});
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
