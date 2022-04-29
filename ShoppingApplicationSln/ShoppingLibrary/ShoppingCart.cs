using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> _shoppingCartItems = new List<ShoppingCartItem>(); //dynamic list for storing items
        private double subtotalValue = 0.00;

        public void AddItemToCart(ShoppingCartItem item)
        {
            _shoppingCartItems.Add(item);
        }

        public List<ShoppingCartItem> GetItems()
        {
            return _shoppingCartItems;
        }

        public double GetSubTotal() //returns subtotal of all items
        {
            foreach (ShoppingCartItem item in _shoppingCartItems)
            {
                subtotalValue += item.GetItemPrice();
            }
            return subtotalValue;

        }

        public double GetSubTotalIncludingVAT() //returns subtotal of all items including 15% vat
        {
            double subtotalVatValue = 0.00;
            double vatPercentage = 0.00;

            vatPercentage = subtotalValue * 0.15;
            subtotalVatValue = subtotalValue + vatPercentage;
            return subtotalVatValue;
        }
    }

}
