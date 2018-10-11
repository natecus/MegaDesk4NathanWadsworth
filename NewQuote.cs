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

            var materials = new List<Desk.DesktopMaterial>();
            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>().ToList();

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
            var depth = DepthUpDown;
            var width = WidthUpDown;
            var drawers = DrawersUpDown;
            var surface = MatCombo;

            //Desk desk = new Desk(width,depth,drawers,surface);

            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
        }

        private void NewQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeComponent();
        }
    }
}
