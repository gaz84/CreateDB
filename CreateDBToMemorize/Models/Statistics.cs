using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Statistics: BaseEntity
    {
        public int SuccessPercent { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual Deck Deck { get; set; }
    }
}