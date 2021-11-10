using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework
{
    class StudentManagementConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentManagementConfiguration()
        {
            this.ToTable("MyTable", "MyTableSchema");
        }
    }
}
