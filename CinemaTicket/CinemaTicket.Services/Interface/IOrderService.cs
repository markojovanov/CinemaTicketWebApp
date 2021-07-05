﻿using CinemaTicket.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicket.Services.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders();

        Order getOrderDetails(BaseEntity model);
    }
}