//Bill Kowal
//CSP-2
//This program calculates costs of a pain job
//based on user input of square footage and 
//paint price.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP2_Project
{
    public partial class Form1 : Form
    {
        //Initializes the Form
        public Form1()
        {
            InitializeComponent();
        }
        //Calculates values for the calculator box on Calculate button click
        //and assigns those values to output labels
        private void calcButton_Click(object sender, EventArgs e)
        {
            //try-catch to handle exceptions
            try
            {
                //Declaration of variables
                const int ftPerGallon = 115;
                const int hoursPerGallon = 8;
                const int costPerHour = 20;
                int sqFeet;
                decimal priceGal, galReq, hourReq, costPaint, labCharge, totCost;

                //Extract values from text boxes
                sqFeet = int.Parse(sqFeetTxtBox.Text);
                priceGal = decimal.Parse(paintPriceTxtBox.Text);

                //Arithmetic Operations
                galReq = (decimal)sqFeet / (decimal)ftPerGallon;
                hourReq = galReq * hoursPerGallon;
                costPaint = priceGal * galReq;
                labCharge = hourReq * costPerHour;
                totCost = costPaint + labCharge;

                //Update Output Labels
                galReqLbl.Text = galReq.ToString("n2");
                hoursReqLbl.Text = hourReq.ToString("n2");
                paintCostLbl.Text = costPaint.ToString("c");
                labCharLbl.Text = labCharge.ToString("c");
                totCostLbl.Text = totCost.ToString("c");
            }
            //Error message if there's a problem.
            catch
            {
                MessageBox.Show("Invalid Data Entered");
            }
        }
        //Handles a Clear button press, Clearing the form
        private void clearButton_Click(object sender, EventArgs e)
        {
            sqFeetTxtBox.Text = "";
            paintPriceTxtBox.Text = "";
            galReqLbl.Text = "";
            hoursReqLbl.Text = "";
            paintCostLbl.Text = "";
            labCharLbl.Text = "";
            totCostLbl.Text = "";
            sqFeetTxtBox.Focus();
        }
        //Handles an Exit button press, closing the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
