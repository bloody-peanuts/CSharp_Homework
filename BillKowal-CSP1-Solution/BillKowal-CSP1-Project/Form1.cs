//Bill Kowal
//CSP-1
//This program generates views of the 4 CCRI campuses. Which campus you are viewing can be toggled buttons.
//While I understand getting us used to commenting, this is a LOT of green for such a simple program =P
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP1_Project
{
    public partial class Form1 : Form
    {
        //Initialization handler. Defaults to Warwick being selected
        public Form1()
        {
            InitializeComponent();

            //Make only the Warwick button red, reset others to black
            warwickBtn.ForeColor = Color.Red;
            providenceBtn.ForeColor = Color.Black;
            lincolnBtn.ForeColor = Color.Black;
            newportBtn.ForeColor = Color.Black;

            //Change the image to display the Warwick campus
            campusPicbox.Image = BillKowal_CSP1_Project.Properties.Resources.campus_warwick;
        }

        //This click handler changes the picture to Warwick and makes the 
        //Warwick button red, while all others turn to black
        private void warwickBtn_Click(object sender, EventArgs e)
        {
            //Make only the Warwick button red, reset others to black
            warwickBtn.ForeColor = Color.Red;
            providenceBtn.ForeColor = Color.Black;
            lincolnBtn.ForeColor = Color.Black;
            newportBtn.ForeColor = Color.Black;

            //Change the image to display the Warwick campus
            campusPicbox.Image = BillKowal_CSP1_Project.Properties.Resources.campus_warwick;
        }

        //This click handler changes the picture to Provicence and makes the 
        //Providence button red, while all others turn to black
        private void providenceBtn_Click(object sender, EventArgs e)
        {
            //Make only the Providence button red, reset others to black
            warwickBtn.ForeColor = Color.Black;
            providenceBtn.ForeColor = Color.Red;
            lincolnBtn.ForeColor = Color.Black;
            newportBtn.ForeColor = Color.Black;

            //Change the image to display the Providence campus
            campusPicbox.Image = BillKowal_CSP1_Project.Properties.Resources.campus_prov;
        }

        //This click handler changes the picture to Lincoln and makes the 
        //Lincoln button red, while all others turn to black
        private void lincolnBtn_Click(object sender, EventArgs e)
        {
            //Make only the Lincoln button red, reset others to black
            warwickBtn.ForeColor = Color.Black;
            providenceBtn.ForeColor = Color.Black;
            lincolnBtn.ForeColor = Color.Red;
            newportBtn.ForeColor = Color.Black;

            //Change the image to display the Lincoln campus
            campusPicbox.Image = BillKowal_CSP1_Project.Properties.Resources.campus_lincoln;
        }

        //This click handler changes the picture to newport and makes the 
        //newport button red, while all others turn to black
        private void newportBtn_Click(object sender, EventArgs e)
        {
            //Make only the Newport button red, reset others to black
            warwickBtn.ForeColor = Color.Black;
            providenceBtn.ForeColor = Color.Black;
            lincolnBtn.ForeColor = Color.Black;
            newportBtn.ForeColor = Color.Red;

            //Change the image to display the Newport campus
            campusPicbox.Image = BillKowal_CSP1_Project.Properties.Resources.Campus_newport;
        }

        /*This click handler for the Exit button closes the program 
        WITHOUT installing any viruses*/
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
