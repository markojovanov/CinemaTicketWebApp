using CinemaTicket.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicket.Domain.Idenitity
{
    public enum Role
    {
        Admin,
        Standard
    }
    public class CinemaTicketUser : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public String Adress { get; set; }
        public virtual ShoppingCart UserCart { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
