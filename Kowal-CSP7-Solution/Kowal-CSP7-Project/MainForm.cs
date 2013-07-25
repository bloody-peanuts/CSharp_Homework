//Bill Kowal
//CSP-7
//This program generates a list of items from a text file and inserts them
//into an interactive list box that can be sorted and items can be selected
//to reveal the price to consumers in another form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kowal_CSP7_Project
{
    public partial class MainForm : Form
    {
        //Create List of Items
        List<Inventory> itemList = new List<Inventory>();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                //Variables to hold read data
                string name, number;
                double markup;
                decimal cost;

                //Declare Streamreader
                StreamReader read;

                read = File.OpenText("InventoryList.txt");

                //Read the text file and create objects with it
                while (!read.EndOfStream)
                {
                    name = read.ReadLine();
                    number = read.ReadLine();
                    cost = decimal.Parse(read.ReadLine());
                    markup = double.Parse(read.ReadLine());

                    Inventory item = new Inventory(name, number, cost, markup);
                    itemList.Add(item);
                }
                //initial filling of list box
                ListBoxFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //fills the list box
        private void ListBoxFill()
        {
            lbxInventory.Items.Clear();
            foreach (Inventory item in itemList)
            {
                lbxInventory.Items.Add(string.Format("{0,-13}{1,-8}{2,-6:p}{3,8:c}", item.PartName, item.PartNumber,
                item.MarkUpPct, item.Cost));
            }
        }

        //Sort by Cost, Largely Borrowed from Book, then Modified
        private void CostSort(List<Inventory> ilist)
        {
            int minIndex; 
            decimal minValue;

            for (int startScan = 0; startScan < ilist.Count - 1; startScan++)
            {
                minIndex = startScan;
                minValue = ilist[startScan].Cost;

                for (int index = startScan + 1; index < ilist.Count; index++)
                {
                    if (ilist[index].Cost < minValue)
                    {
                        minValue = ilist[index].Cost;
                        minIndex = index;
                    }
                }
                Swap(ilist[minIndex], ilist[startScan]);
            }
        }

        //Sort by Name, Largely Borrowed from Book, then Modified
        private void NameSort(List<Inventory> ilist)
        {
            int minIndex;
            string minValue;

            for (int startScan = 0; startScan < ilist.Count - 1; startScan++)
            {
                minIndex = startScan;
                minValue = ilist[startScan].PartName;

                for (int index = startScan + 1; index < ilist.Count; index++)
                {
                    if (string.Compare(ilist[index].PartName, minValue) < 0)
                    {
                        minValue = ilist[index].PartName;
                        minIndex = index;
                    }
                }
                Swap(ilist[minIndex], ilist[startScan]);
            }
        }

        //Swap 2 items in list through a temporary item
        private void Swap(Inventory a, Inventory b)
        {
            Inventory temp = new Inventory(a.PartName, a.PartNumber, a.Cost, a.MarkUpPct);
            a.PartName = b.PartName;
            a.PartNumber = b.PartNumber;
            a.MarkUpPct = b.MarkUpPct;
            a.Cost = b.Cost;
            b.PartName = temp.PartName;
            b.PartNumber = temp.PartNumber;
            b.MarkUpPct = temp.MarkUpPct;
            b.Cost = temp.Cost;
        }

        //Handles the sort by cost button click
        private void btnCost_Click(object sender, EventArgs e)
        {
            CostSort(itemList);
            ListBoxFill();
        }

        //Handles the sort by name button click
        private void btnName_Click(object sender, EventArgs e)
        {
            NameSort(itemList);
            ListBoxFill();
        }

        //On clicking an item in the list box, generates a display of the item name, number, cost, and price
        private void lbxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemForm iform = new ItemForm();
            iform.lblItmCst.Text = itemList[lbxInventory.SelectedIndex].Cost.ToString("c");
            iform.lblItmName.Text = itemList[lbxInventory.SelectedIndex].PartName;
            iform.lblItmNum.Text = itemList[lbxInventory.SelectedIndex].PartNumber;
            iform.lblItmPrc.Text = itemList[lbxInventory.SelectedIndex].Price.ToString("c");
            iform.ShowDialog();
        }
    }
}
