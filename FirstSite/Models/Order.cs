using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstSite.Models
{
    public class Order
    {
        public int OrdersId { get; set; }
        //[Required(ErrorMessage = "Wprowadz imie")]
        //[StringLength(30)]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Wprowadz nzwisko")]
        //[StringLength(30)]
        public string Surname { get; set; }
        //[Required(ErrorMessage = "Wprowadz ulice")]
        //[StringLength(30)]
        public string Street { get; set; }
        //[Required(ErrorMessage = "Wprowadz miasto")]
        //[StringLength(30)]
        public string Town { get; set; }
        //[Required(ErrorMessage = "Wprowadz kod pocztowy")]
        //[StringLength(6)]
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime AddingDate { get; set; }
        public OrderState OrderStates { get; set; }
        public decimal Value { get; set; }

        List<OrderPosition> OrderPositions { get; set; }

        public enum OrderState
        {
            New,
            InProgress,
            Send,
            Finished,        
        }
    }
}