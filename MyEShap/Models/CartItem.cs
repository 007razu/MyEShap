﻿namespace MyEShap.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
public decimal getTotalprice()
        {
            return Quantity * Item.Price;

    }

}
}
