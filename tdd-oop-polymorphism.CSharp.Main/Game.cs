using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IProduct
    {
        string name;
        int price;

        public Game(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name => name;
        public int Price => price;
    }
}
