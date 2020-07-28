using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstSite.Models
{
    public class Order
    {
        public int OrdersId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime AddingDate { get; set; }
        public OrderState OrderState { get; set; }
        public decimal Value { get; set; }

        List<OrderPositions> OrderPositions { get; set; }

        public enum OrderState
        {
            New,
            InProgress,
            Send,
            Finished,        
        }
    }
}