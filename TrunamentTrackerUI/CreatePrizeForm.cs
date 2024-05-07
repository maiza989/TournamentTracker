using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentTrackerLibaray;
using TournamentTrackerLibaray.DatabaseConnectors;
using TournamentTrackerLibaray.Models;

namespace TrunamentTrackerUI
{
    /// <summary>
    /// Represent prize creation window
    /// </summary>
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A method connected to the create prize button in CreatePrizeForm. This button create a model of prize and add it to the database. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (VailidateForm())
            {
                PrizeModel model = new PrizeModel(                                                                              // Creating the prize model based on the vaild info entered.  
                    placeNameTextBox.Text, 
                    placeNumberTextBox.Text, 
                    prizeAmountTextBox.Text, 
                    prizePercentageTextBox.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);                                                                                      // Add the model to the databases
                }
                placeNameTextBox.Text = "";
                placeNumberTextBox.Text = "";
                prizeAmountTextBox.Text = "0";
                prizePercentageTextBox.Text = "0";
                MessageBox.Show("Prize model has been created seccussfully");
            }
            else
            {
                MessageBox.Show("Invaild form. Please check and try again");
            }
        }

        /// <summary>
        /// A private method to vaildate the information being entered is vaild
        /// </summary>
        /// <returns></returns>
        private bool VailidateForm() 
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberVaild = int.TryParse(placeNumberTextBox.Text, out placeNumber);

            if (!placeNumberVaild)                                                                                              // if place number is not vaild notify user of the error. Place number needs to be an integer.
            {
                output = false;
                MessageBox.Show("Invaild Place Number!");
            }
            if (placeNumber < 1)                                                                                                // if place number is samller than 1 notify user of the error. This to make sure there is no prize number set to 0 or -1...
            {
                output = false;
                MessageBox.Show("Place number has to be bigger than 1!");
            }
            if(placeNameTextBox.Text.Length == 0)                                                                               // if place name is empty notify user of the error. Cannot have a prize place name empty.
            {
                MessageBox.Show("Place name cannot be empty!");
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountVaild = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageVaild = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (!prizeAmountVaild || !prizePercentageVaild)                                                                     // if place number is not faild notify user of the error. Prize amount has to be a deceimal, and prize percentage has to be a double.
            {
                MessageBox.Show("Invaild prize ammount or prize percentage.");
                output = false;
            }
            if(prizeAmount <= 0 && prizePercentage <= 0)                                                                        // if prizeAmount and prize percentage are less or equal to zero notify the user of the error. You cannot have both set to 0. 
            {
                MessageBox.Show("Please enter a prize amount or percentage.");
                output = false;
            }
            if(prizePercentage < 0 || prizePercentage > 100)                                                                    // Prize percentage has to be between 0 and 100 
            {
                MessageBox.Show("Prize percentage has to be between 0 and 100");
                output = false;
            }
            return output; 
        }

    }
}
