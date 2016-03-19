/*
Paul Adams
2/14/16
P04VendingMachine
File VendingItemClass.cs
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04VendingMachine
{
    class VendingItemClass
    {
        private string item;
        private string location;
        private double price;
        private int quantity;
        
        public VendingItemClass(string _item, double _price, string _location, int _quantity)
        {
            item = _item;
            location = _location;
            price = _price;
            quantity = _quantity;
        }

        public string Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public void reduceInventory()
        {
            quantity--;
        }
    }
}
