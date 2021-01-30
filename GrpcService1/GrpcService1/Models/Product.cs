using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public Category ProductCategory { get; set; }

        public Product(string Name, string Description, Category ProductCategory)
        {
            Id++;
            this.Name = Name;
            this.Description = Description;
            this.ProductCategory = ProductCategory;
        }

    }

}
