using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicket.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
        [Required]
        public String TicketName { get; set; }
        [Required]
        public String TicketDesc { get; set; }
        [Required]
        public double TicketPrice { get; set; }
        [Required]
        public String TicketImage { get; set; }
        [Required]
        public String TicketTime { get; set; }
        public String TicketGenre { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }

        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }


    }
}
