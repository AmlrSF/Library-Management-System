using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project
{
    internal class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        // Add a library item to the library
        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        // Remove a library item from the library
        public void RemoveItem(LibraryItem item)
        {
            items.Remove(item);
        }

        public void RemoveAll()
        {
            items.Clear();
        }

        // Get all library items in the library
        public List<LibraryItem> GetAllItems()
        {
            return items;
        }

        // Search for a library item by title
        public LibraryItem SearchItemByTitle(string title)
        {
            return items.FirstOrDefault(item => item.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // Mark an item as a favorite
        public void MarkAsFavorite(LibraryItem item)
        {
            item.IsFavorite = true;
        }

        public void unMarkAsFavorite(LibraryItem item)
        {
            item.IsFavorite = false;
        }

        // Remove an item from favorites
        public void RemoveFromFavorites(LibraryItem item)
        {
            item.IsFavorite = false;
        }

        // Buy a library item
        public void BuyItem(LibraryItem item)
        {
            if (item != null && item.IsAvailable && !item.IsBought)
            {
                // Mark the item as not available and bought
                item.IsAvailable = false;
                item.IsBought = true;
            }
        }

        public void DropItem(LibraryItem item)
        {
            if (item != null && !item.IsAvailable && item.IsBought)
            {
                // Mark the item as available and not bought
                item.IsAvailable = true;
                item.IsBought = false;
            }
        }


    }
}
