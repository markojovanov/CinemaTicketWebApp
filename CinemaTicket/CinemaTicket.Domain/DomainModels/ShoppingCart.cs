
using CinemaTicket.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicket.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public String OwnerId { get; set; }
        public virtual CinemaTicketUser Owner { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    } 
}
