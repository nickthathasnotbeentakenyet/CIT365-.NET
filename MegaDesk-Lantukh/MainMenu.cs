using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Lantukh
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQ = new AddQuote();
            addQ.Show();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQ = new ViewAllQuotes();
            viewQ.Show();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQ = new SearchQuotes();
            searchQ.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the main Menu
            Application.Exit();
        }
    }
}
