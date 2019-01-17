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

      
        bool allowclick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 5;
        Timer timer = new Timer { Interval = 1000 };


        public Game3() //start game
        {
            InitializeComponent();
            allowclick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            

        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    
                    Properties.Resources.picture2,
                    Properties.Resources.picture3,
                    
                };
            }
        }
        private void startGameTimer()
        {
           
            timer.Start();
            timer.Tick += delegate

            {
                time = time - 1;
                if (time < 0)
                {
                    timer.Stop();
                    Win.Start();
                    MessageBox.Show("You lose");
                    this.Close();
                    var Score = new Score();
                    Score.Show();

                }
               
                
                lblTimer.Text = time.ToString();
            };
        }
        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 5;
            timer.Start();
        }
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
            pic.Image = Properties.Resources.picback;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void setRandomImages()
        {
            foreach(var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();

            allowclick = true;
            clickTimer.Stop();

        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowclick) return;
            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowclick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            {
                timer.Stop();
                Win.Start();
                MessageBox.Show("You Win");
                Random rnd = new Random(); // // randomly chooses a minigame
                int gamePicker = rnd.Next(1, 3);

                if (gamePicker == 1)
                {
                    var Game4 = new Game4();
                    Game4.Show();
                }
                
                else
                {
                    var Game1 = new Game1();
                    Game1.Show();


                }
            }



        }

        private void Win_Tick(object sender, EventArgs e)
        {
            Win.Stop();
            this.Close();
        }
    }

}
