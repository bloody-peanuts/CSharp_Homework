//Bill Kowal
//CSP 6
//This program uses arrays to generate
//powerball quick picks.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillKowal_CSP6_Project
{
    public partial class Form1 : Form
    {
        const int SIZE = 5;

        public Form1()
        {
            InitializeComponent();
        }

        //Sequential seach method, borrowed from book
        private int SequentialSearch(int[] numbers, int value, int count)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < count)
            {
                if (numbers[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            return position;
        }

        //Selection Sort method from book
        private void SelectionSort(int[] iArray)
        {
            int minIndex, minValue;

            for (int startScan = 0; startScan < iArray.Length - 1; startScan++)
            {
                minIndex = startScan;
                minValue = iArray[startScan];

                for (int index = startScan + 1; index < iArray.Length; index++)
                {
                    if (iArray[index] < minValue)
                    {
                        minValue = iArray[index];
                        minIndex = index;
                    }
                }
                Swap(ref iArray[minIndex], ref iArray[startScan]);
            }
        }

        //swap method to help with selection sort
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void buPlay_Click(object sender, EventArgs e)
        {
            //declare variables
            Random rand = new Random();
            int x, arrCnt = 0;
            int[] quickPick = new int[5];

            //Populate the array with unique integers in the given range
            while (arrCnt < SIZE)
            {
                x = rand.Next(56);
                if (SequentialSearch(quickPick, x, arrCnt) == -1)
                {
                    quickPick[arrCnt] = x;
                    arrCnt++;
                }
            }

            //Sort the array into ascending order
            SelectionSort(quickPick);

            //Append the list box with a correctly formatted string
            lstbxShow.Items.Add(quickPick[0].ToString("d2") + "  " + quickPick[1].ToString("d2") +
                "  " + quickPick[2].ToString("d2") + "  " + quickPick[3].ToString("d2") + "  " + 
                quickPick[4].ToString("d2") + "    PowerBall: " + (rand.Next(42)+1).ToString("d2"));

            lstbxShow.SelectedIndex = lstbxShow.Items.Count - 1;
            lstbxShow.SelectedIndex = -1;
            
        }

        //Closes the program
        private void buExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
