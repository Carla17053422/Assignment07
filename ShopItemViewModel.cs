using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_Assignment_07.Views.Shop
{
    public class ShopItemViewModel
    {
        private string mName;
        private string mDescription;
        private double mPrice;
        private int mQuantityAvailable;

        public string Name { get => mName; set => mName = value; }
        public string Description { get => mDescription; set => mDescription = value; }
        public double Price { get => mPrice; set => mPrice = value; }
        public int GuantityAvailable { get => mQuantityAvailable; set => mQuantityAvailable = value; }
        
        //add an empty constructor method
    }
}