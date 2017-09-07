using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class CardType: BaseEntity
    {
        public virtual ICollection<Card> Cards { get; set; }
    }
}