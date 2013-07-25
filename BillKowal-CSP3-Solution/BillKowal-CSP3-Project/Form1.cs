//Bill Kowal
//CSP-3
//This program takes user input from list boxes, radio buttons, and text boxes
//and uses this information to calculate the prices of different workshop selections.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP3_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Handles the click of the Calculate Button to generate output
        private void BtnCalc_Click(object sender, EventArgs e)
        {

            //Declation of Variables, starting with a lengthy list of constants
            const Decimal STRESS_FEE = 1000, TIME_FEE = 800, SUPERVISION_FEE = 1500,
                NEGOTIATION_FEE = 1300, INTERVIEW_FEE = 500, LODGE_AUSTIN = 150,
                LODGE_CHICAGO = 225, LODGE_DALLAS = 175, LODGE_ORLANDO = 300,
                LODGE_PHOENIX = 175, LODGE_RALEIGH = 150, INTERNET_FEE = 12,
                VALET_FEE = 15, GYM_FEE = 10;
            const int STRESS_DAYS = 3, TIME_DAYS = 3, SUPERVISION_DAYS = 3,
                NEGOTIATION_DAYS = 5, INTERVIEW_DAYS = 1;
            const double RETURNING_DISC = 0.9, STUDENT_DISC = 0.6, SENIOR_DISC = 0.8;
            int days = 0;
            double discount = 1.0;
            decimal workshopFee = 0, locFee = 0, extraFee = 0, regFee = 0, lodgeFee = 0, totalFee = 0;


            //Determine if the listboxes are checked
            if ((LstBxLocation.SelectedIndex == -1) || (LstBxWorkshop.SelectedIndex == -1))
            {
                MessageBox.Show("Please select a workshop and location before calculating!");
            }
            else
            {
                //Assign variables based on selected options in list boxes
                switch (LstBxWorkshop.SelectedIndex)
                {
                    case 0:
                        workshopFee = STRESS_FEE;
                        days = STRESS_DAYS;
                        break;
                    case 1:
                        workshopFee = TIME_FEE;
                        days = TIME_DAYS;
                        break;
                    case 2:
                        workshopFee = SUPERVISION_FEE;
                        days = SUPERVISION_DAYS;
                        break;
                    case 3:
                        workshopFee = NEGOTIATION_FEE;
                        days = NEGOTIATION_DAYS;
                        break;
                    case 4:
                        workshopFee = INTERVIEW_FEE;
                        days = INTERVIEW_DAYS;
                        break;
                }
                switch (LstBxLocation.SelectedIndex)
                {
                    case 0:
                        locFee = LODGE_AUSTIN;
                        break;
                    case 1:
                        locFee = LODGE_CHICAGO;
                        break;
                    case 2:
                        locFee = LODGE_DALLAS;
                        break;
                    case 3:
                        locFee = LODGE_ORLANDO;
                        break;
                    case 4:
                        locFee = LODGE_PHOENIX;
                        break;
                    case 5:
                        locFee = LODGE_RALEIGH;
                        break;
                }

                //Assign variables based on selected items in OPTIONS group box
                if (RadBuReturn.Checked == true)
                    discount = RETURNING_DISC;
                if (RadBuSenior.Checked == true)
                    discount = SENIOR_DISC;
                if (RadBuStudent.Checked == true)
                    discount = STUDENT_DISC;
                if (ChkBxValet.Checked == true)
                    extraFee = VALET_FEE;
                if (ChkBxInternet.Checked == true)
                    extraFee += INTERNET_FEE;
                if (ChkBxGym.Checked == true)
                    extraFee += GYM_FEE;


                //Do Math (Math is hard)
                regFee = workshopFee * (decimal)discount;
                lodgeFee = locFee * (decimal)days;
                extraFee *= days;
                totalFee = regFee + lodgeFee + extraFee;

                //Display Results
                LblRegis.Text = "Registration: " + regFee.ToString("c");
                LblLodging.Text = "Lodging: " + locFee.ToString("n0") + " x " + days.ToString() +
                    " days = " + lodgeFee.ToString("c");
                LblFees.Text = "Extra fees: " + extraFee.ToString("c");
                LblTotal.Text = "Total: " + totalFee.ToString("c");
            }

        }

        //Handles the clicking of the reset button, resetting the form
        //to as it is at launch
        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblRegis.Text = "";
            LblTotal.Text = "";
            LblLodging.Text = "";
            LblFees.Text = "";
            LstBxWorkshop.ClearSelected();
            LstBxLocation.ClearSelected();
            RadBuReturn.Checked = false;
            RadBuSenior.Checked = false;
            RadBuStudent.Checked = false;
            ChkBxGym.Checked = false;
            ChkBxInternet.Checked = false;
            ChkBxValet.Checked = false;
        }
        //Handles Exit button firing and closes application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show((6 <= 4).ToString());
            this.Close();
        }
    }
}
