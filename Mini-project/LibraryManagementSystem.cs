using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project
{
    internal class LibraryManagementSystem
    {
        private Library library = new Library();

        // Add a book to the library
        public void AddBookToLibrary(string title, string author, string genre, int nbPages, string maisonEdition, string imageUrl, string description, decimal price)
        {
            Book book = new Book
            {
                Title = title,
                Author = author,
                Genre = genre,
                NbPages = nbPages,
                MaisonEdition = maisonEdition,
                ImageUrl = imageUrl,
                Description = description,
                Price = price
            };
            library.AddItem(book);
        }

        // Add a magazine to the library
        public void AddMagazineToLibrary(string title, string author, int issueNumber, string maisonEdition, string imageUrl, string description, decimal price)
        {
            Magazine magazine = new Magazine
            {
                Title = title,
                Author = author,
                IssueNumber = issueNumber,
                MaisonEdition = maisonEdition,
                ImageUrl = imageUrl,
                Description = description,
                Price = price
            };
            library.AddItem(magazine);
        }

        // Remove a library item from the library
        public void RemoveItemFromLibrary(string title)
        {
            LibraryItem itemToRemove = library.SearchItemByTitle(title);
            if (itemToRemove != null)
            {
                library.RemoveItem(itemToRemove);
            }
        }

        // Get all library items in the library
        public List<LibraryItem> GetAllItemsInLibrary()
        {
            return library.GetAllItems();
        }

        // Mark an item as a favorite
        public void MarkItemAsFavorite(string title)
        {
            LibraryItem item = library.SearchItemByTitle(title);
            if (item != null)
            {
                library.MarkAsFavorite(item);
            }
        }

        // Remove an item from favorites
        public void RemoveItemFromFavorites(string title)
        {
            LibraryItem item = library.SearchItemByTitle(title);
            if (item != null)
            {
                library.RemoveFromFavorites(item);
            }
        }

        // Buy an item
        public void BuyItem(string title)
        {
            LibraryItem item = library.SearchItemByTitle(title);
            if (item != null)
            {
                library.BuyItem(item);
            }
        }
    }
}
