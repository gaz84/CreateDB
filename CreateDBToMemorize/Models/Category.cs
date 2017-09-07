using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        
        public virtual Course Courses { get; set; }
    }
}