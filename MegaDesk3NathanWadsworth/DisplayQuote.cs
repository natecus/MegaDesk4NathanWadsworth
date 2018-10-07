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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            var newQuote = (NewQuote)Tag;
            newQuote.Show();
            Close();
        }
    }
}
