using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project
{
    internal class Book : LibraryItem      
    {
        public string Genre { get; set; }
        public int NbPages { get; set; }
        public string MaisonEdition { get; set; } // Publisher
    }
}
