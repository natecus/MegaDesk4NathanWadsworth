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
    public partial class NewQuote : Form
    {
        public NewQuote()
        {
            InitializeComponent();
            MatCombo.Items.Add("Laminate");
            MatCombo.Items.Add("Oak");
            MatCombo.Items.Add("Rosewood");
            MatCombo.Items.Add("Veneer");
            MatCombo.Items.Add("Pine");
            RushCombo.Items.Add("None");
            RushCombo.Items.Add("3 Days");
            RushCombo.Items.Add("5 Days");
            RushCombo.Items.Add("7 Days");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void DisplayQuoteBut_Click(object sender, EventArgs e)
        {

            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
        }
    }
}
