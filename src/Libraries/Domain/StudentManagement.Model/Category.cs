using StudentManagement.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class Category:BaseEntity,IEntity
    {
        public string? CategoryName { get; set; }
        public ICollection <Product> products { get; set; }= new HashSet<Product>();

    }
}
