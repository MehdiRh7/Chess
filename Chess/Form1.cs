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

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p15_Click(object sender, EventArgs e)
        {
            if (p15.Image != null)
            {
                bool check = false;
                string imageName = p15.Tag.ToString();
                var location = p15.Location;
                if (imageName == "Soldier_B")
                {
                    var items = Controls.OfType<PictureBox>().OrderBy(p=>p.Name);
                    foreach (PictureBox item in items)
                    {
                        if (item.Location.Y == location.Y + 81 && item.Location.X == location.X)
                        {
          
                            if (item.Image == null)
                            {
                                item.BackColor = Color.FromArgb(215, 168, 0, 0);
                                item.BorderStyle = BorderStyle.FixedSingle;
                                check = true;
                            }
                        }
                        if (item.Location.Y == location.Y + 162 && item.Location.X == location.X)
                        {
                            if (item.Image == null && check == true)
                            {
                                item.BackColor = Color.FromArgb(215, 168, 0, 0);
                                item.BorderStyle = BorderStyle.FixedSingle;
                            }
                        }
                    }
                }
            }

        }

        private void p16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p16.Location.ToString());
        }

        private void p2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p2.Location.ToString());
        }

        private void p31_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p23.Location.ToString());
        }

        private void p57_Click(object sender, EventArgs e)
        {
            SelectBead cls = new SelectBead();
            cls.SelectSoldier();
        }
    }
}
