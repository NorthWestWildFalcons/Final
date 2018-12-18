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

        List<string> icons = new List<string>()
        {
            "!","!","c","c","i","i","s","s","d","d"
        };
        Label firstClick, secondClicked;
        public Game4()
        {
            InitializeComponent();
            MakeSymbols();
        }

        private void lblSymbol_Click(object sender, EventArgs e)
        {
            Label clickedLabel =
        }

        private void MakeSymbols()
        {
            Label Symbol;
            int randomNumber;

            for ( int i=0; i < tableLayoutPanel1.Controls.Count; i++)
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
