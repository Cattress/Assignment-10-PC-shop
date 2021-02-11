using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_PC_builder_system
{
    class Item
    {

        private string productName;
        private int quantity;
        private double price;

        public Item(string productName, int quantity, double price)
        {
            string ProductName = productName;
            int Quantity = quantity;
            double Price = price;
        }

        public string GetProductName()
        {
            return productName;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetPrice()
        {
            return price;
        }
    }
}

