﻿using System;
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
            Random rnd = new Random(); // randomly chooses one of the 4 minigames
            int gamePicker = rnd.Next(1, 4);

            if (gamePicker == 1)
            {
                var Game1 = new Game1();
                Game1.Show();
            }
            else if(gamePicker == 2)
            {
                var Game2 = new Score();
                Game2.Show();
            }
            else if (gamePicker == 3)
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
            var Game2 = new Score();
            Game2.Show();
        }

        private void btnGame3_Click(object sender, EventArgs e)
        {
            var Game3 = new Game3();
            Game3.Show();
        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            var Game4 = new Game4();
            Game4.Show();
        }
    }
}
