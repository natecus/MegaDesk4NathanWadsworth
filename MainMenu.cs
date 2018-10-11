using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk3NathanWadsworth
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewQuoteBut_Click(object sender, EventArgs e)
        {
            NewQuote addNewQuoteForm = new NewQuote();
            addNewQuoteForm.Tag = this; ;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void ViewQuotesBut_Click(object sender, EventArgs e)
        {
            ViewAllQoutes viewQuotesForm = new ViewAllQoutes();
            viewQuotesForm.Tag = this; ;
            viewQuotesForm.Show(this);
            Hide();
        }

        private void SearchQuotesBut_Click(object sender, EventArgs e)
        {
            SearchAllQuotes searchQuotesForm = new SearchAllQuotes();
            searchQuotesForm.Tag = this; ;
            searchQuotesForm.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
