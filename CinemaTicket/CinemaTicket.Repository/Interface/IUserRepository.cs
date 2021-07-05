using CinemaTicket.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicket.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<CinemaTicketUser> GetAll();
        CinemaTicketUser Get(string id);
        void Insert(CinemaTicketUser entity);
        void Update(CinemaTicketUser entity);
        void Delete(CinemaTicketUser entity);
    }
}