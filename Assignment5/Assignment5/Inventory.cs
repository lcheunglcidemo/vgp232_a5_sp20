using System;
using System.Text;

namespace Assignment5
{
    public class Inventory
    {
        // the max number of slots available
        int slots;
        Item[] items;
        
        public int Slot
        {
            get 
            {
                return slots;
            }
        }

        public Inventory(int slots)
        {
            this.slots = slots;
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            // TODO: add implementation.
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            // TODO: add implementation.
            throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            // TODO: add implementation. Should print out what items are available.
            throw new NotImplementedException();
        }
        
        public Item GetItem(int index)
        {
            // TODO: add implementation.
            throw new NotImplementedException();
        }

    }
}
