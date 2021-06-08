using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();
            Console.WriteLine(s);

            s.AddItem(new Item("milkey", "Milky is popular in Israel", 6));
            s.AddItem(new Item("cottage", "Basic dairy product", 4));
            Console.WriteLine(s);

            s.DeleteItemFromDb(1);
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
}
