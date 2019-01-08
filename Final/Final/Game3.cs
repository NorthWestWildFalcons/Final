using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Game3 : Form
    {
        Random box = new Random();
        List<Point> points = new List<Point>();
        PictureBox PendingImage;
        PictureBox PictureImage1;

        public Game3()
        {
            InitializeComponent();
        }

        private void Game3_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in PictureHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in PictureHolder.Controls)
            {
                int move = box.Next(points.Count);
                Point p = points[move];
                picture.Location = p;
                points.Remove(p);
            }
            timer2.Start();
            timer1.Start();
            pic1.Image = Properties.Resources.picture1;
            pic2.Image = Properties.Resources.picture2;
            pic3.Image = Properties.Resources.picture3;
            pic4.Image = Properties.Resources.picture1;
            foreach (PictureBox picture in PictureHolder.Controls) 
            {
                pic1.Image = Properties.Resources.picback; //Makes it show the picture cover
                pic2.Image = Properties.Resources.picback1;
                pic3.Image = Properties.Resources.picback2;
                pic4.Image = Properties.Resources.picback3;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in PictureHolder.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.picback;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(lblTimer.Text);
            timer = timer-1;
            lblTimer.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }
       //This region of code changes the pictures to gold images
        #region
        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.Image = Properties.Resources.picture1;
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.picture2;
        }
        private void pic3_Click(object sender, EventArgs e)
        {
            pic3.Image = Properties.Resources.picture3;
        }
        private void pic4_Click(object sender, EventArgs e)
        {
            pic4.Image = Properties.Resources.picture1;
        }
        #endregion 
    }
}
