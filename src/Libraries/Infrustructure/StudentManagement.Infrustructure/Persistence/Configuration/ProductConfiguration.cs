using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Model;
using StudentManagement.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrustructure.Persistence.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Category).WithMany(x => x.products).HasForeignKey(x => x.CategoryId).IsRequired(true);
            builder.HasData(new
            {
                Id = 1,
                ProductName = "Samsung S23 Ulta",
                price = 1000.00,
                ProductModel= "5G",
                CategoryId = 1,
                Created = DateTimeOffset.Now,
                CreatedBy = "1",
                Status = EntityStatus.Created
            });
        }
    }

}
