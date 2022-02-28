// Name: Stevenson Suhardy
// Date: January 25, 2022
// App name: Average Units Shipped Calculator
// App description: Calculates the average units shipped for 7 days.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShippedCalculator
{
    public partial class formAverageUnitsShipped : Form
    {
        public formAverageUnitsShipped()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUnitsInput_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Closes the form or application
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Closes the app
            Close();
        }
        /// <summary>
        /// Clears or reset the form to it's original state.
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Clear the form
            textBoxPastEntries.Clear();
            textBoxUnitsInput.Clear();
            labelAverage.Text = string.Empty;
            // Enabling the enter button after pressing reset
            buttonEnter.Enabled = true;
            // Changing the input textbox back to it's original state
            textBoxUnitsInput.ReadOnly = false;
            // Changing the label text back to Day 1
            labelDay.Text = "Day 1";
            // Changing the day value back to 2 or it's original value
            day = 2;
            // Changing the index back to it's original value
            index = 0;
            // Changing the average back to 0
            average = 0;
            // Clearing the array in order to insert another new 7 data inside the array
            Array.Clear(listOfUnits, 0, listOfUnits.Length);
            // Change the focus to the textBoxUnitsInput
            textBoxUnitsInput.Focus();
        }
        // Declaring variables necessary for the application to work
        int unit;
        int day = 2;
        double average;
        int[] listOfUnits = new int[7];
        int index = 0;
        const int totalDays = 7;
        const int maxNumberOfUnits = 5000;
        const int minNumberOfUnits = 0;

        /// <summary>
        /// The user will type a data into the entry box, and first it will validate whether the data that the user inputs is
        /// an integer or not and displays an error if it is not integer. Then, it will validate the data's range and see if it
        /// is between 0 and 5000. If it is, then it will enter the data into a multiline box and after entering the data 7 
        /// times, the enter button will be disabled and the average of the data input will be displayed as a label.
        /// </summary>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Checking if the input is an integer
            if (int.TryParse(textBoxUnitsInput.Text, out unit))
            {
                // Checking if the input is between 0 and 5000
                if (unit >= minNumberOfUnits && unit <= maxNumberOfUnits)
                {
                    // Adding the value to a variable in order to be calculated
                    listOfUnits[index] = unit;
                    // Incrementing index variable to indicate the array index
                    index++;
                    // Clears the input box so, the user can input another data
                    textBoxUnitsInput.Text = string.Empty;
                    // Converting the input into a string again in order to display it in a multiline box
                    textBoxPastEntries.AppendText(Convert.ToString(unit));
                    // Creating a new line
                    textBoxPastEntries.AppendText("\r\n");
                    // Checking if the day is still 7 or below
                    if (day <= totalDays)
                    {
                        // Displaying the day number using the day variable
                        labelDay.Text = String.Format("Day {0}", day);
                        // Incrementing the day by one everytime it is still under 7
                        day++;
                    }
                    // If the day number is more than 7
                    else
                    {
                        // Changing the input textbox to readonly
                        textBoxUnitsInput.ReadOnly = true;
                        // Disabling the enter button
                        buttonEnter.Enabled = false;
                        // Iterating through the array and adding each data inside the array into a variable
                        foreach(var totalUnit in listOfUnits)
                        {
                            average += totalUnit;
                        }
                        // Calculating the average of units shipped or the data entered by the user
                        average /= totalDays;
                        // Rounding the result to 2 decimal places
                        average = Math.Round(average, 2);
                        // Displaying the results in a label
                        labelAverage.Text = String.Format("Average: {0}", average);
                    }
                }
                // If the input is not inside the valid range
                else
                {
                    // Display the following messagebox
                    MessageBox.Show(String.Format("Please enter a number {0} between and {1}", minNumberOfUnits, 
                        maxNumberOfUnits), "INVALID INPUT RANGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Change the focus to the input textbox
                    textBoxUnitsInput.Focus();
                }
            }
            // If the input is not a whole number
            else
            {
                // Display the following messagebox
                MessageBox.Show("Please enter a whole number", "INVALID INPUT DATA TYPE", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                // Change the focus to the input textbox
                textBoxUnitsInput.Focus();
            }
            
        }
    }
}
