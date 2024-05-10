using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHL
{
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();

            this.Text = "Search Results";
            searchDGV.AutoGenerateColumns = true;
            searchDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchDGV.ReadOnly = true;
        }
        public DataGridView newsearchDGV => searchDGV;
        private void SearchResult_Load(object sender, EventArgs e)
        {

        }
    }
}
