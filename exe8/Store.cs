using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{
    class Store
    {
        Item[] storeItems;

        int itemNum;

        DBConnection storeCon;

        public Store()
        {
            storeItems = new Item[0];

            storeCon = new DBConnection();
        }


        public void AddItem(Item item)
        {
            Item[] arr = (Item[])storeItems.Clone();
            storeItems = new Item[arr.Length + 1];

            for (int i = 0; i < storeItems.Length - 1; i++)
            {
                storeItems[i] = arr[i];
            }

            storeItems[storeItems.Length - 1] = item;

            Console.WriteLine(storeCon.AddItemToDB(item) + " New Item Added.");
        }

        public void DeleteItemFromDb(int code)
        {
            Console.WriteLine(storeCon.DeletItemFromDB(code) + " Item Deleted.");
        }


        public override string ToString()
        {
            return storeCon.ReadItemsTable();
        }
    }
}
