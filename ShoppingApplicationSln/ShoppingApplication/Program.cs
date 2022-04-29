using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            cart.AddItemToCart(new ShoppingCartItem("PSP", 3950.99));
            cart.AddItemToCart(new ShoppingCartItem("PS4", 5999.49));
            cart.AddItemToCart(new ShoppingCartItem("Wii", 1499.99));

            foreach (ShoppingCartItem item in cart.GetItems())
            {
                string itemName = item.GetItemName();
                double itemPrice = item.GetItemPrice();

                Console.WriteLine($"{itemName}                     {itemPrice}");
                
            }


            double subtotal = cart.GetSubTotal();
            double subtotalIncludingVat = cart.GetSubTotalIncludingVAT();

            Console.WriteLine($"Subtotal:               {subtotal}");
            Console.WriteLine($"With VAT:               {subtotalIncludingVat}");


        }
    }
}
