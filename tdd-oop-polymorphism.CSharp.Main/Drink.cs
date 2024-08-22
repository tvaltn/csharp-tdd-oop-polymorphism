using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IProduct
    {
        string name;
        int price;

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name => name;
        public int Price => price;
    }
}
