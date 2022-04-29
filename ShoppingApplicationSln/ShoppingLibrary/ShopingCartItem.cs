using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem : ShoppingCart
    {
        public string _itemName;
        public double _itemPrice;

        public ShoppingCartItem(string itemName, double itemPrice) //constructor
        {
            _itemName = itemName;
            _itemPrice = itemPrice;
        }

        public string GetItemName()
        {
            return _itemName;
        }
        public double GetItemPrice()
        {
            return _itemPrice;
        }

        
    }
}
