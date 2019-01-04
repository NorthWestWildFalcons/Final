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
        int blockcolor = 0; // determines the color of the block
        int i; //changes the player color
        int speed = 5; // speed of the blocks
        
        bool fail = false;

        public Game1()
        {
            InitializeComponent();
        }

        private void Game(object sender, EventArgs e)
        {
            block1.Top += speed;
            block2.Top += speed;
        }

        
    }
}
