﻿using StrategyPatternFirstLook.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternFirstLook.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy : IInvoiceStrategy
    {
        public abstract bool Generate(Order order);
        public string GenerateTextInvoice(Order order)
        {
            var invoice = $"INVOICE DATE: {DateTimeOffset.Now}{Environment.NewLine}";
            invoice += $"ID|NAME|PRICE|QUANTITY: {Environment.NewLine}";
            foreach (var item in order.LineItems)
                invoice += $"{item.Key.Id}|{item.Key.Name}|{item.Key.Price}|{item.Value}";

            invoice += Environment.NewLine + Environment.NewLine;

            var tax = order.GetTax();
            var total = order.TotalPrice;

            invoice += $"TAX TOTAL: {tax}{Environment.NewLine}";
            invoice += $"TOTAL: {total}{Environment.NewLine}";

            return invoice;
        }
    }
}
