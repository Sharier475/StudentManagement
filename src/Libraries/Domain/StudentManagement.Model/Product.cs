using StudentManagement.Shared.Common;

namespace StudentManagement.Model
{
    public class Product:BaseEntity,IEntity
    {
        public string? ProductName { get; set; }
        public double price { get; set; }
        public string? ProductModel { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set;}

    }
}
