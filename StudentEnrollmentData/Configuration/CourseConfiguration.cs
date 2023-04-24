using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentData.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                 new Course
                 {
                     Id = 1,
                     Title = "Minimal API Devlopment",
                     Credit = 3
                 },
                 new Course
                 {
                     Id = 2,
                     Title = "Ultimate API Devlopment",
                     Credit = 5
                 }
            );
        }
    }
}
