
using CinemaTicket.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicket.Domain.DomainModels
   { 
        public class Order:BaseEntity
        {
            public string UserId { get; set; }
            public CinemaTicketUser User { get; set; }

            public IEnumerable<TicketInOrder> TicketInOrder { get; set; }
        }
    }