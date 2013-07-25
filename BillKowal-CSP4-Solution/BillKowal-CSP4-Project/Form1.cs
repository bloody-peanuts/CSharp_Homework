//Bill Kowal
//CSP-4
//This program takes user input on range and frequency and generates
//a list of random numbers that it saves to a file. It can then open
//those files to display the numbers

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BillKowal_CSP4_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        //Handles a click of the generate and save button to save
        //a list of random numbers to a file
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Declatation of Variables
            int start, end, many, number;

            //Verify that valid integers are entered
            if ((int.TryParse(txtBxStart.Text, out start)) &&
                (int.TryParse(txtBxEnd.Text, out end)) &&
                (int.TryParse(txtBxMany.Text, out many)))
            {
                //Verify that numbers fit the necessary requirements
               if ((many > 0) && (start < end))
               {
                   
                   //Create a StreamWriter
                   StreamWriter outputFile;

                   //Verify that the save button was pushed
                   if (saveFile.ShowDialog() == DialogResult.OK)
                   {
                       //Set up a random number generator
                       Random rand = new Random();
                       try
                       {
                           //Create File
                           outputFile = File.CreateText(saveFile.FileName);

                           //Generate numbers and write them to file
                           for (int i = 0; i < many; i++)
                           {
                               number = rand.Next(end - start + 1) + start;
                               outputFile.WriteLine(number);
                           }

                           //Close File
                           outputFile.Close();

                           //Success Message
                           MessageBox.Show("File Created Successfully!");
                       }
                       catch
                       {
                           MessageBox.Show("Error Creating File");
                       }
                   }
                   else
                   {
                       MessageBox.Show("Please choose a save location");
                   }

               }
               else
               {
                   MessageBox.Show("Start of range must be less than end of range" +
                       " and how many numbers cannot be 0");
               }
            }
            else
            {
                MessageBox.Show("Please enter only whole numbers as input");
            }
            

        }

        //Handles the load button being clicked, displaying the chosen file's output
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Clear out old data from list box
            listbxDisplay.Items.Clear();

            //Declare Variables
            int count = 0, total = 0;
            string current;

            //Create Streamreader
            StreamReader inputFile;

            //Select the file from the openfile dialog
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Open the file
                    inputFile = File.OpenText(openFile.FileName);

                    //Read the file, update the list box, and keep track of count and total
                    while (!inputFile.EndOfStream)
                    {
                        count++;
                        current = inputFile.ReadLine();
                        total += int.Parse(current);
                        listbxDisplay.Items.Add(current);
                    }

                    //close the file
                    inputFile.Close();

                    //Display the count and total at the bottom of the list box
                    listbxDisplay.Items.Add("Total is " + total.ToString());
                    listbxDisplay.Items.Add("Number of random numbers is " + count.ToString());
                }
                catch
                {
                    //Upon error, clear the list box and show a message
                    listbxDisplay.Items.Clear();
                    MessageBox.Show("Error opening file. Please verify that the file contains only integers");
                }
            }
            else
            {
                MessageBox.Show("File Load Cancelled");
            }
        }

        //Handles Clear button, clearing text boxes and list box
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxStart.Clear();
            txtBxEnd.Clear();
            txtBxMany.Clear();
            listbxDisplay.Items.Clear();
        }

        //Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
