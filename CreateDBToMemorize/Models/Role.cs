using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Role:BaseEntity
    {
        public string Name { get; set; }

        public virtual UserRole UserRoles { get; set; }
    }
}