using System;
namespace Items
{
    public class Item
    {   
        public string Name {get; set;}
        public string Description {get;set;}
        public int Quantity {get;set;}
        public int Price {get;set;}

        public Item (string name, string description, int quantity, int price)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}