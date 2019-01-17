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
    public partial class Game4 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()// list of what symbols show
        {
            "!","!","c","c","i","i",
        };
        Label firstClick, secondClick;
        public Game4()
        {
            
            InitializeComponent();
            MakeSymbols();
        }
        


                private void Symbol_Click(object sender, EventArgs e)
        {
            if (firstClick != null && secondClick != null)
                return;

                Label clickedLabel = sender as Label;

            if (clickedLabel == null)
            return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if(firstClick == null)
            {
                firstClick = clickedLabel;
                firstClick.ForeColor = Color.Black;
                return;
            }
            secondClick = clickedLabel;
            secondClick.ForeColor = Color.Black;
            if (firstClick.Text == secondClick.Text)
            {
                firstClick = null;
                secondClick = null;

                Win.Start();
                MessageBox.Show("You Win");

                Random rnd = new Random(); // randomly chooses a minigame
                int gamePicker = rnd.Next(1, 3);

                if (gamePicker == 1)
                {
                    var Game1 = new Game1();
                    Game1.Show();
                }
                else  
                {
                    var Game3 = new Game3();
                    Game3.Show();
                }
                

            }

            else
             
            Reset.Start();
           


        }

        private void Reset_Tick(object sender, EventArgs e)
        {
            Reset.Stop();

            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;

            firstClick = null;
            secondClick = null;
        }

        private void Win_Tick(object sender, EventArgs e)
        {
            Win.Stop();

            this.Close();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            int score = 0;
            int playerScore;
            int timer = Convert.ToInt32(lblTimer.Text);
            timer = timer - 1;
            playerScore = score - 1;
            lblTimer.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                Win.Start();// Same for win and losing
                MessageBox.Show("You lose");
                GameTimer.Stop();
                this.Close();
                var Score = new Score();
                Score.Show();
            }
           
               



        }

        private void Game4_Load(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        private void MakeSymbols()
        {
            Label Symbol;
            int randomNumber;

            for ( int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    Symbol = (Label)tableLayoutPanel1.Controls[i];

                else

                    continue;
                randomNumber = random.Next(0, icons.Count);
                Symbol.Text = icons[randomNumber];

                icons.RemoveAt(randomNumber);
            }
        }

       
    }
}
