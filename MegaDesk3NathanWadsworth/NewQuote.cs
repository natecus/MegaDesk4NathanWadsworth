using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk4NathanWadsworth
{
    public partial class NewQuote : Form
    {
        public NewQuote()
        {
            InitializeComponent();

            var materials = new List<Desk.DesktopMaterial>();
            materials = Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>().ToList();
            MatCombo.DataSource = materials;
            MatCombo.SelectedIndex = -1;
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
            var depth =Convert.ToInt32(DepthUpDown.Value);
            var width = Convert.ToInt32(WidthUpDown.Value);
            var drawers = Convert.ToInt32(DrawersUpDown.Value);
            var surface = (Desk.DesktopMaterial)Enum.Parse(typeof(Desk.DesktopMaterial)
               , MatCombo.Text);
            var rush = RushCombo.SelectedIndex;

            
            Desk desk = new Desk();
            desk.Height = depth;
            desk.Width = width;
            desk.NumberOfDrawers = drawers;
            desk.Material = surface;
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.RushOrder = rush;
            deskQuote.CustomerName = CustNameTB.Text;

            quoteTB.Text = deskQuote.GetQuote(desk);

          //DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote);
          //displayQuoteForm.Tag = this;
          //displayQuoteForm.Show(this);
          //Hide();
        }

        private void NewQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
