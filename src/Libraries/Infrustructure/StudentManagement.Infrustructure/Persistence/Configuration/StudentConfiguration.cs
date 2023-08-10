using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Model;
using StudentManagement.Shared.Enum;

namespace StudentManagement.Infrustructure.Persistence.Configuration;

internal class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");
        builder.HasKey(x => x.Id);
        builder.HasData(new
        {
            Id = 1,
            StudentName ="Sharier",
            AdmissionFee = 32000.00,
            CourseName = ".NET",
            CategoryId = 1,
            Created = DateTimeOffset.Now,
            CreatedBy = "1",
            Status = EntityStatus.Created



        });
    }
}
