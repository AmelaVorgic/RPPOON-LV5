﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5RPPOON
{
    class Product : IShipable
    {
        private double price;
        private double weight;
        private string description;
        public Product(string description, double weight, double price)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
        public double Weight { get { return this.weight; } }
    }
}
