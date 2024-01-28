using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class SelectBead
    {
        public void SelectSoldier()
        {
                      
            var pictureBox = ((Form1)Application.OpenForms["Form1"]).Controls.OfType<PictureBox>().Where(p=>p.Name == "p57").FirstOrDefault();
            if (pictureBox.Image != null)
            {
                bool check = false;
                string imageName = pictureBox.Tag.ToString();
                var location = pictureBox.Location;
                if (imageName == "Soldier_W")
                {
                    var items = ((Form1)Application.OpenForms["Form1"]).Controls.OfType<PictureBox>().OrderBy(p => p.Name);
                    foreach (PictureBox item in items)
                    {
                        if (item.Location.Y == location.Y - 81 && item.Location.X == location.X)
                        {
                            if (item.Image == null)
                            {
                                item.BackColor = Color.FromArgb(215, 168, 0, 0);
                                item.BorderStyle = BorderStyle.FixedSingle;
                                check = true;
                            }
                        }
                        if (item.Location.Y == location.Y - 162 && item.Location.X == location.X)
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
    }
}
