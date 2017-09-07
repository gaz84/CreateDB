using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateDBToMemorize.Models
{
    public class Card
    {
        public Card()
        {
            Comments = new List<Comment>();
        }
        public string Question { get; set; }

        public virtual CardType CardType { get; set; }
        public virtual Deck Decks { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}