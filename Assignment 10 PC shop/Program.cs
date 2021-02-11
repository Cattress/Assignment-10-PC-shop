using System;

namespace Assignment_10_PC_builder_system
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            fillOrder();

        }



        static void PrintMenu(Item[] ShopItems)
        {

            Console.WriteLine("{0,3} {1,15} {2,8:c2}", "#", "Product: ", "Price: ");
            for (int i = 0; i < ShopItems.Length; i++)
            {
                if (ShopItems != null)
                {
                    Console.WriteLine("{0,3} {1,15} {2,8:c2}", i, ShopItems[i].GetProductName(), ShopItems[i].GetPrice());

                }


            }



            static Order fillShop(Item[] Shopitems)
            {
                Order[] ShopItems = new Order[5];
                ShopItems[0] = new Item("CPU", 0, 9.99);
                ShopItems[1] = new Item("RAM", 0, 19.99);
                ShopItems[2] = new Item("GTX", 0, 9.99);
                ShopItems[3] = new Item("CPU", 0, 9.99);
                ShopItems[4] = new Item("CPU", 0, 9.99);
            }

            static Order fillOrder(Item[] Shopitems)
            {
                Order NouveauOrder = new Order(0);
                string userInput = "";
                while (userInput != "ew")
                {
                    Console.WriteLine("Input a number");
                    userInput = Console.ReadLine();
                    if (userInput == "ew") break;

                    int i = Convert.ToInt32(userInput);
                    Console.WriteLine("How many ", ShopItems[i].GetProductName, "would you like?");
                    userInput = Console.ReadLine();

                    int quantity = Convert.ToInt32(userInput);

                    NouveauOrder.additem();

                }

                return NouveauOrder
            }

        }
    }