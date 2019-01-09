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
            var Game1 = new Game1();
            Game1.Show();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            var Game2 = new Game2();
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
