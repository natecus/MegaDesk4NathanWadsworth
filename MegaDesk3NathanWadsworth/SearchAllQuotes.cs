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
    public partial class SearchAllQuotes : Form
    {
        const int MAT = 5;
        
        public SearchAllQuotes()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchAllQuotes_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("data.csv"))
            {
                while (reader.EndOfStream == false)
                {
                    string[] line = new string[1];
                    line = reader.ReadLine().Split(',');
                    dataGridView1.Rows.Add(line);
                }
            }
            List<Desk.DesktopMaterial> enumList = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList() ;
            comboBox1.DataSource = enumList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (StreamReader reader = new StreamReader("data.csv"))
            {
                while (reader.EndOfStream == false)
                {
                    string[] line = new string[1];
                    line = reader.ReadLine().Split(',');
                    if (line[MAT].Trim(' ') == comboBox1.SelectedValue.ToString())
                    {
                        dataGridView1.Rows.Add(line);
                    }
                }
            }
        }


        //List<SurfaceMaterial> enumList = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList(); ;
        // comboBox1.DataSource = enumList;
    }
}
