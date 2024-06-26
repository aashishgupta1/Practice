﻿using OrderServiceDesign.Domain.BaseDetail;

namespace OrderServiceDesign.Domain.Entities
{
    public class BasketItem : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
