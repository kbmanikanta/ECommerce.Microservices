﻿using System;
namespace ECommerce.Common.Events
{
    public class PaymentAcceptedEvent
    {
        public PaymentAcceptedEvent()
        {
        }

        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public double Total { get; set; }
    }
}
