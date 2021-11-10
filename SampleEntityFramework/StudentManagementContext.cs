using System.Data.Entity;

namespace SampleEntityFramework
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext() : base("Name=SchoolManagementDBConnectionString")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<StudentManagementContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StudentManagementContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<StudentManagementContext>());
            //Database.SetInitializer(new );
            Database.SetInitializer(new StudentManagementInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.HasDefaultSchema("My");
            //modelBuilder.Entity<Student>().ToTable("MyTable", "MyTableSchema");
            //modelBuilder.Entity<Student>().HasOptional(s => s.SchoolStudied).WithRequired(t => t.Studentenrolled);
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
            //modelBuilder.Entity<Student>().HasMany(m => m.SchoolStudied).WithMany(s => s.Studentenrolled).Map(ms =>
            //{
            //    ms.MapLeftKey("StudentID");
            //    ms.MapRightKey("SchoolID");
            //    ms.ToTable("StudentSchool");
            //});
           // modelBuilder.Configurations.Add(new StudentManagementConfiguration());
            // modelBuilder.Entity<Student>().MapToStoredProcedures();
            modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
