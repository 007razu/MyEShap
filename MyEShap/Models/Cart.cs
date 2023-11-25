using System.Collections.Generic;
using System.Linq;

namespace MyEShap.Models
{
    public class Cart
    {
        public int OrderId { get; set; }
        public List<CartItem> CartItems { get; set;}
        public Cart() 
        { 
            CartItems = new List<CartItem>();
        } 
        public void AddItem(CartItem item) 
       
        { if(CartItems.Exists(match: i=>i.Item.Id == item.Id)) 
            {
                CartItems.Find(match: i => i.Item.Id == item.Item.Id)
                    .Quantity+=1;
                    }
        else 
            { 
                CartItems.Add(item); 
            }
           
        }
        public void removeItem(int itemId) 
        {  
            var item=CartItems.SingleOrDefault(c=> c.Item.Id == itemId);
            if (item?.Quantity<=1)
            {
                CartItems.Remove(item);
            }
            else if(item!=null)
            { 
                item.Quantity-=1;
            }
           
        }

    }
}
