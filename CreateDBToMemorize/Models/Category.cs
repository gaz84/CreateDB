using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Category: BaseEntity
    {
        public Category()
        {
            Courses = new List<Course>();
        }
        public string Name { get; set; }
        
        public virtual ICollection<Course> Courses { get; set; }
    }
}