using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_machine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
//  Write a program to simulate a Fruit Machine that displays three symbols at random from Cherry, Bell, Lemon, Orange, Star, Skull.

// The player starts with Â£1 credit, with each go costing 20p.If the Fruit Machine rolls two of the same symbol, the user wins 50p.The player wins £1 for three of the same and £5 for 3 Bells.
// The player loses £1 if two skulls are rolled and all of his/her money if three skulls are rolled.The player can choose to quit with the winnings after each roll or keep playing until there is no money left.






    }
}
