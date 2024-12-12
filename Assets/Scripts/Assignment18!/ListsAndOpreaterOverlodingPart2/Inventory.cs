using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class Inventory
    {
        private List<string> items;

        public Inventory()
        {
            items = new List<string>();
        }
        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in items)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            Inventory combinedInventory = new Inventory();
            foreach (string item in inventory1.items)
            {
                combinedInventory.AddItem(item);
            }

            foreach (var item in inventory2.items)
            {
                combinedInventory.AddItem(item);
            }

            return combinedInventory;

        }

    }
}