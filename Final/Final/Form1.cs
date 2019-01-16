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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGame1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // randomly chooses one of the other two minigames
            int gamePicker = rnd.Next(1, 3);

            if (gamePicker == 1)
            {
                var Game1 = new Game1();
                Game1.Show();
            }

            else if (gamePicker == 2)
            {
                var Game3 = new Game3();
                Game3.Show();
            }
            else
            {
                var Game4 = new Game4();
                Game4.Show();
            }

        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            var Score = new Score();
            Score.Show();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            var Game3 = new Game3();
            Game3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
