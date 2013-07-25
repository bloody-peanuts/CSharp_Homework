//Bill Kowal
//CSP 5
//This program computes customer charges for a mechanic using various methods.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP5_Project
{
    public partial class Form1 : Form
    {
        //Declaration of constant values at the top to be changed easily
        private const decimal OILPRC = 26, LUBEPRC = 18, RADPRC = 30, TRANSPRC = 80, INSPPRC = 15,
            MUFFPRC = 100, TIREPRC = 20, LABORPRC = 20;
        private const double TAXRATE = 0.07;

        public Form1()
        {
            InitializeComponent();
            //Ideally, text next to check boxes would be declared here
            //with their prices generated through constants instead of hardcoded
            //but this was not specified
        }

        //Module for calculating oil and lube charges
        private decimal OilLubeCharges(bool oil, bool lube)
        {
            decimal olcharge = 0;
            if (oil)
                olcharge += OILPRC;
            if (lube)
                olcharge += LUBEPRC;
            return olcharge;
        }

        //Module for calculating flush charges
        private decimal FlushCharges(bool rad, bool trans)
        {
            decimal flushcharge = 0;
            if (rad)
                flushcharge += RADPRC;
            if (trans)
                flushcharge += TRANSPRC;
            return flushcharge;
        }

        //Module for calculating misc charges
        private decimal MiscCharges(bool inspec, bool muff, bool tire)
        {
            decimal misc = 0;
            if (inspec)
                misc += INSPPRC;
            if (muff)
                misc += MUFFPRC;
            if (tire)
                misc += TIREPRC;
            return misc;
        }

        //Module for calculating other charges
        private decimal OtherCharges(decimal parts, double hours)
        {
            decimal other = parts;
            other += (decimal) hours * LABORPRC;
            return other;
        }

        //Module for calculating tax charges
        private decimal TaxCharges(decimal parts)
        {
            decimal tax = parts * (decimal)TAXRATE;
            return tax;
        }

        //Module for calculating total charge
        private decimal TotalCharges(decimal oil, decimal flush, decimal misc, decimal other,
            decimal tax)
        {
            decimal total = oil + flush + misc + other + tax;
            return total;
        }

        //Handles the calculate button click to generate an output
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare some variables
            bool oil, lube, radiator, trans, inspection, muffler, tire;
            //it feels like a waste to have all these total variables and a seperate
            //total module instead of just keeping a grand total variable and just 
            //+= it after each module. Is the method used here a better way of doing
            //this or just a way to get us to construct more modules?
            decimal oillubtot = 0, flushtot = 0, misctot = 0, othertot = 0, 
                taxtot = 0, total = 0, parts;
            double hours;

            //generate boolean values from check boxes
            oil = chkbxOil.Checked;
            lube = chkbxLube.Checked;
            radiator = chkbxRadiator.Checked;
            trans = chkbxTrans.Checked;
            inspection = chkbxInspection.Checked;
            muffler = chkbxMuffler.Checked;
            tire = chkbxTire.Checked;

            //Determine if the oil and lube module needs to run, 
            //and run it if so
            if (oil || lube)
                oillubtot = OilLubeCharges(oil, lube);

            //Determine if the flush charges module needs to run, 
            //and run it if so
            if (radiator || trans)
                flushtot = FlushCharges(radiator, trans);

            //Determine if the misc charges module needs to run,
            //and run it if so
            if (inspection || muffler || tire)
                misctot = MiscCharges(inspection, muffler, tire);

            //try to parse the text boxes. If either parses, run the other charges
            //module. 0 out any text box with invalid input
            if (decimal.TryParse(txtbxParts.Text, out parts) && (parts > 0))
            {
                if (double.TryParse(txtbxLabor.Text, out hours) && (hours > 0))
                {
                    othertot = OtherCharges(parts, hours);
                    txtbxParts.Text = parts.ToString("n2");
                }
                else
                {
                    hours = 0;
                    othertot = OtherCharges(parts, 0);
                    txtbxParts.Text = parts.ToString("n2");
                    txtbxLabor.Text = "0";
                }
            }
            else
            {
                parts = 0;
                if (double.TryParse(txtbxLabor.Text, out hours) && (hours > 0))
                {
                    othertot = OtherCharges(0, hours);
                    txtbxParts.Text = 0.ToString("n2");
                }
                else
                {
                    hours = 0;
                    txtbxLabor.Text = "0";
                    txtbxParts.Text = 0.ToString("n2");
                }
            }

            //Determines if a tax needs to be calculated, then does if needed
            if (parts > 0)
                taxtot = TaxCharges(parts);

            //Totals the value of all subtotals
            total = TotalCharges(oillubtot, flushtot, misctot, othertot, taxtot);

            //Display output for end user
            lblSnL.Text = (total - parts - taxtot).ToString("c");
            lblParts.Text = parts.ToString("c");
            lblTax.Text = taxtot.ToString("c");
            lblTotal.Text = total.ToString("c");
        }

        //Clears out the form to it's initial state on press of the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            chkbxInspection.Checked = false;
            chkbxLube.Checked = false;
            chkbxMuffler.Checked = false;
            chkbxOil.Checked = false;
            chkbxRadiator.Checked = false;
            chkbxTire.Checked = false;
            chkbxTrans.Checked = false;
            txtbxLabor.Text = "";
            txtbxParts.Text = "";
            lblParts.Text = "";
            lblSnL.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        //Closes the application on click or Escape Key
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
