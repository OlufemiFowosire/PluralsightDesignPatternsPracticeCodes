﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern_First_Look.Business.Models.Commerce
{
    public abstract class OrderFactory
    {
        protected abstract Order CreateOrder();
        public Order GetOrder()
        {
            var order = CreateOrder();
            order.LineItems.Add(
                new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1
            );
            order.LineItems.Add(
                new Item("CONSULTING", "Build a website", 200m), 1
            );
            return order;
        }
    }
    public class StandardOrderFactory : OrderFactory
    {
        protected override Order CreateOrder()
        {
            var order = new Order
            {
                Recipient = new Address
                {
                    To = "Filip Ekberg",
                    Country = "Sweden"
                },
                Sender = new Address
                {
                    To = "Someone else",
                    Country = "Sweden"
                },
                TotalWeight = 100
            };
            return order;
        }
    }

    public class InternationalOrderFactory : OrderFactory
    {
        protected override Order CreateOrder()
        {
            var order = new Order
            {
                Recipient = new Address
                {
                    To = "Filip Ekberg",
                    Country = "Sweden"
                },
                Sender = new Address
                {
                    To = "Someone else",
                    Country = "Denmark"
                },
                TotalWeight = 100
            };
            return order;
        }
    }
}
