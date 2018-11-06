using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk4NathanWadsworth
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            CustNameTB.Text = deskQuote.CustomerName;
            var lastLine = File.ReadLines("data.csv").Last();
            string[] stringArray = lastLine.Split(',');
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
