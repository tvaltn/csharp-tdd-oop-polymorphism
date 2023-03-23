using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<Game> games = new List<Game>();
        List<Drink> drinks = new List<Drink>();
        List<Book> books = new List<Book>();

        public void add(Game game)
        {
            this.games.Add(game);
        }

        public void add(Drink drink)
        {
            this.drinks.Add(drink);
        }

        public void add(Book book)
        {
            this.books.Add(book);
        }

        public int getTotal()
        {
            int total = 0;

            foreach (Game game in this.games)
            {
                total += game.getPrice();
            }

            foreach (Drink drink in this.drinks)
            {
                total += drink.getPrice();
            }

            foreach (Book book in this.books)
            {
                total += book.getPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (Game game in this.games)
            {
                if (game.getName().Equals(name))
                {
                    return true;
                }
            }

            foreach (Drink drink in this.drinks)
            {
                if (drink.getName().Equals(name))
                {
                    return true;
                }
            }

            foreach (Book book in this.books)
            {
                if (book.getName().Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
