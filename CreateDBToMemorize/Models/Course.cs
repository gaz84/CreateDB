using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Deck> Deck { get; set; }
        public virtual UserCourse UserCourses { get; set; }
        public virtual ICollection<Comment> Coments { get; set; }
    }
}