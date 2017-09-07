using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class UserRole:BaseEntity
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}