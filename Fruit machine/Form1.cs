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

        // all the possible results
        string[] fruitoptions = { "Cherry", "Bell", "Lemon", "Orange", "Star", "skull" };

        public double balance = 1;

        double costforgo = 0.20;

       
        // if the player does not have enough money then they can't play
        private void NomoneyLeft(object sender, EventArgs e)
        {
            if (balance < 0.2)
            {
                MessageBox.Show("You have insufficient funds to play");
            }



        }


private void btnGo_Click(object sender, EventArgs e)
        {
            lblBalance.Text = $"£{balance = balance - costforgo}";


            // once this butoon is pressed initiate a random choosing of an item from the array to all 3 labels
            // doesnt seem to be random at the moment


            { // randomiser for result 1
                Random a = new Random();
                string randomFruit1 = fruitoptions[a.Next(fruitoptions.Length)]; // chooses a random item from the array 

                lblresult1.Text = randomFruit1;
            }

            { // randomiser for result 2
                Random b = new Random();
                string randomFruit2 = fruitoptions[b.Next(fruitoptions.Length)]; // chooses a random item from the array 

                lblresult2.Text = randomFruit2;
            }

            { // randomiser for result 3
                Random c = new Random();
                string randomFruit3 = fruitoptions[c.Next(fruitoptions.Length)]; // chooses a random item from the array 

                lblresult3.Text = randomFruit3;
            }

            if (lblresult1.Text == lblresult2.Text & lblresult2.Text == lblresult3.Text & lblresult1.Text == lblresult3.Text)
            {
                MessageBox.Show("WINNER!!, you matched all 3 symbols!"); // if all 3 symbols are the same then display this
                balance = balance + 5.0; // adds £5 to the balance
            }

           
            lblBalance.Text = $"£{balance}"; // updates balance 
           
        }


        // you can withdaw the money in your balance 
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have withdrawn a balance off £{balance - 0.2}, CONGRADULATIONS!!");
            balance = 0.2;
            lblBalance.Text = $"£{balance}";
        }











        // not needed
        private void lblresult1_Click(object sender, EventArgs e)
        {

        }

        // not needed
        private void lblresult3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
