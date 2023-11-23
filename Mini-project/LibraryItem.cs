using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project
{
    internal class LibraryItem
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public bool IsBought { get; set; } = false; 
        public string ImageUrl { get; set; } // URL or path to the image
        public string Description { get; set; }
        public decimal Price { get; set; } // Price of the item
        public bool IsFavorite { get; set; } // Indicates whether the item is marked as a favorite
    }
}
