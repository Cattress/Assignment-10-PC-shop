using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_10_PC_builder_system
{
    class Order
    {
        private Item[] = new Items[100];
        private int ItemCount;
        private int CustomerID;
        private DateTime OrderDate;

        public Order(int CustomerID)
        {
            ItemCount = 0;
            customerID = CustomerID;
            OrderDate = DateTime.Now;
        }

        public void AddItem(string ProductName, double Price, int Quantity)
        {
            Item[ItemCount] = new Item(ProductName, Quantity, Price);
            ItemCount++;
        }

        public Item GetItem(int index)
        {
            if (index < ItemCount)
            {
                return Item[index];
            }
            else
            {
                return null; // could use " new Item("Nothing TwT"); " lawl but like it no good?? stackoverflow debate type beat

            }
        }

        public double calculateTotal()
        {
            for (int i = 0; i < Item.length; i++)
            {
                if (Item[i] != null)
                {
                    int quantity = Item[i].quantity;
                    double ItemPrices = price * quantity;

                }
            }
        }
    }
}
