using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_machine
{
    public partial class Form1 : Form
    {
        //  Write a program to simulate a Fruit Machine that displays three symbols at random from Cherry, Bell, Lemon, Orange, Star, Skull.

        // The player starts with Â£1 credit, with each go costing 20p.If the Fruit Machine rolls two of the same symbol, the user wins 50p.The player wins £1 for three of the same and £5 for 3 Bells.
        // The player loses £1 if two skulls are rolled and all of his/her money if three skulls are rolled.The player can choose to quit with the winnings after each roll or keep playing until there is no money left.
        public Form1()
        {
            InitializeComponent(); 
        }




        // not needed
        private void lblresult3_Click(object sender, EventArgs e)
        {

        }
    }
}
