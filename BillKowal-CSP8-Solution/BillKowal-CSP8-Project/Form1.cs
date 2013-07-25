//Bill Kowal
//CSP 8
//This program takes an alpha-numeric phone number as input and converts
//it to a formatted numeric phone number

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP8_Project
{
    public partial class Form1 : Form
    {

        //constant to make origional length changeable
        const int MINLENGTH = 10;

        public Form1()
        {
            InitializeComponent();
        }

        //set output on invalid input
        private void invalid()
        {
            lblOutput.Text = "INVALID PHONE NUMBER";
        }


        //handles the click of the translate button
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = txtbxInput.Text;
            bool valid = true;
            int letDigct = 0, index = 0, tenct = 1;
            char lowerc;
            char[] letDig = new char[MINLENGTH];

            lblOutput.Text = "";

            //validate origional length before further processing
            if (input.Length < MINLENGTH)
            {
                invalid();
            }
            else
            {

                //set variables up for further validation testing
                foreach (char c in input)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        letDigct++;
                    }
                    else if (c != '-')
                        valid = false;
                }

                //test if all characters are leters, digits, or dashes
                //also good segment for a chuckle.. (if (!valid) then invalid... you don't say!)
                if (!valid)
                {
                    invalid();
                }

                //test if there are anouth letters and digits
                else if (letDigct < MINLENGTH)
                {
                    invalid();
                }
                else
                {
                    //turn the string into an array of digits
                    foreach (char c in input)
                    {
                        if (tenct <= MINLENGTH)
                        {
    
                            if (char.IsDigit(c))
                            {
                                letDig[index] = c;
                                index++;
                                tenct++;
                            }
                            else if (char.IsLetter(c))
                            {
                                lowerc = char.ToLower(c);
                                tenct++;

                                switch (lowerc)
                                {
                                    case 'a':
                                    case 'b':
                                    case 'c':
                                        letDig[index] = '2';
                                        index++;
                                        break;

                                    case 'd':
                                    case 'e':
                                    case 'f':
                                        letDig[index] = '3';
                                        index++;
                                        break;

                                    case 'g':
                                    case 'h':
                                    case 'i':
                                        letDig[index] = '4';
                                        index++;
                                        break;

                                    case 'j':
                                    case 'k':
                                    case 'l':
                                        letDig[index] = '5';
                                        index++;
                                        break;

                                    case 'm':
                                    case 'n':
                                    case 'o':
                                        letDig[index] = '6';
                                        index++;
                                        break;

                                    case 'p':
                                    case 'q':
                                    case 'r':
                                    case 's':
                                        letDig[index] = '7';
                                        index++;
                                        break;

                                    case 't':
                                    case 'u':
                                    case 'v':
                                        letDig[index] = '8';
                                        index++;
                                        break;

                                    case 'w':
                                    case 'x':
                                    case 'y':
                                    case 'z':
                                        letDig[index] = '9';
                                        index++;
                                        break;
                                }
                            }
                        }

                        //generate output label
                        lblOutput.Text = "" + letDig[0] + letDig[1] + letDig[2] + "-" +
                            letDig[3] + letDig[4] + letDig[5] + "-" +
                            letDig[6] + letDig[7] + letDig[8] + letDig[9];
                    }
                }
            }
        }
    }
}
