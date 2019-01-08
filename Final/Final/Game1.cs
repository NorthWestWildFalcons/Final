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
    public partial class Game1 : Form
    {
        List<Color> colors; //list of colours for this game
        Random random = new Random(); // instance of the random class called random
        Random position = new Random(); // instance of the random class called position
        int rectangleColor = 0; // determines the color of the block
        int i; //changes the player color
        int speed = 5; // speed of the blocks
        
        bool fail = false; //If player messes up overriding in the boolean

        public Game1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //play game event
        {
            rectangle1.Top += speed; //bring rectangle 1 towards the bottom of this form
            rectangle2.Top += speed; //bring rectangle 2 towards the bottom of the form

            if (rectangle1.Top > 500) //if rectangle1 reaches the bottom of the form
            {
                rectangleColor = random.Next(colors.Count); //choose a random color
                rectangle1.BackColor = colors[rectangleColor]; //apply this color to rectangle 1
                rectangle1.Top = position.Next(200, 300) * -1; //randomly position block at the top of the form
            }
            if (rectangle2.Top > 500) //if rectangle2 reaches the bottom of the form
            {
                if (rectangle1.Top > 100) //rectangle1 is heading down the form passed 200 pixels
                {
                    rectangleColor = random.Next(colors.Count); //choose a random color from the list
                    rectangle2.BackColor = colors[rectangleColor]; //apply the color to rectangle2
                    rectangle2.Top = (rectangle1.Top * 8) * -1; //randomly postiion the block on top of the form
                }
            }
            if (player.Bounds.IntersectsWith(rectangle1.Bounds)) //when the player collides with rectangle1
            {
                if (player.BackColor != rectangle1.BackColor) //if the color of the player and rectangle 1 are different
                {
                    timer.Stop(); //timer stops
                    fail = true; //player lost the game
                }
            }
            if (player.Bounds.IntersectsWith(rectangle2.Bounds)) //when the player collides with rectangle2
            {
                if (player.BackColor != rectangle1.BackColor) //if the color of the player and rectangle 2 are different
                {
                    timer.Stop(); //timer stops
                    fail = true; //player lost the game
                }
            }
            /* if (score > 5)
             {
             speed = 6;
             }
             if (score > 10)
             {
             speed = 10;
             }
             rectangle1.Refresh;
             retangle2.Refresh;
             */
        }

        private void KeyisDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space) //when the space key is pressed
            {
                i++; //increase the i integer by 1
                if (i > colors.Count - 1) //if the i integer is greater than the amount of colours on the list
                {
                    i = 0;
                }
                player.BackColor = colors[i]; //apply the color
            }

        }

    }
}
