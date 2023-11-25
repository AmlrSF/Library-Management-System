using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project
{
    public partial class List_of_documents : Form
    {
        public List_of_documents()
        {
            InitializeComponent();
        }

        DataTable docs = new DataTable("Documents");


        private void List_of_documents_Load(object sender, EventArgs e)
        {
            docs.Columns.Add(new DataColumn("CIN", typeof(string)));

        }
    }
}
