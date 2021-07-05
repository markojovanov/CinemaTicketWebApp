using CinemaTicket.Domain.DomainModels;
using CinemaTicket.Repository.Interface;
using CinemaTicket.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicket.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }

        public Order getOrderDetails(BaseEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
