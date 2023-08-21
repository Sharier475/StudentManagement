using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Model;
using StudentManagement.Shared.Enum;

namespace StudentManagement.Infrustructure.Persistence.Configuration;

internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teacher");
        builder.HasKey(x=> x.Id);
        builder.HasData(new
        {
            Id = 1 ,
            TeacherName = "Dipon",
            Salary = 15000.00,
            Department = "IT",
            Created = DateTimeOffset.Now,
            CreatedBy = "1",
            Status = EntityStatus.Created
        });
    }
}
