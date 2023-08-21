using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Model;
using StudentManagement.Shared.Enum;

namespace StudentManagement.Infrustructure.Persistence.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.HasData(new
            {
                Id = 1,
                CategoryName = "Mobile",
                Created = DateTimeOffset.Now,
                CreatedBy = "1",
                Status=EntityStatus.Created
            });
        }
    }
}
