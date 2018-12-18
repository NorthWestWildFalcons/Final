using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Final
{
    public partial class Game1 : Form
    {
        public Game1()
        {
            int max = 6;
            int min = 1;
            

            Random colorGenerator = new Random();
            int color;
            color = colorGenerator.Next(min, max);

            if (color == 1)
            {
                WriteLine("Red");
            }
            else if (color == 2)
            {
                WriteLine("Blue");
            }
            else if (color == 3)
            {
                WriteLine("Green");
            }
            else if (color == 4)
            {
                WriteLine("Yellow");
            }
            else if (color == 5) 
            {

            }

        }
    }
}

        