using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Deck: BaseEntity
    {
        public Deck()
        {
            Cards = new List<Card>();
            Statistics = new List<Statistics>();
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Statistics> Statistics { get; set; } 
    }
}