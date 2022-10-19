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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            // How to pass objects between two forms. Google it

            DisplayQuote OrdersForm = new DisplayQuote();
            OrdersForm.Show();
        }
    }
}
