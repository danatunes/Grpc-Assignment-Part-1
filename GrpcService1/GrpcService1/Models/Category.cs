using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  ParentCategoryId { get; set; }

        public Category(string Name , int Pid)
        {
            Id++;
            this.Name = Name;
            ParentCategoryId = Pid;
        }

        public Category(int id, string name, int parentCategoryId)
        {
            Id = id;
            Name = name;
            ParentCategoryId = parentCategoryId;
        }
    }
}
