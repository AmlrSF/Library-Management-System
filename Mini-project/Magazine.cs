using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string MaisonEdition { get; set; } // Publisher
    }
}
