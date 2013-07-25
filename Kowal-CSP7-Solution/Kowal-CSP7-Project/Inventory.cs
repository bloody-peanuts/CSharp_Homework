using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kowal_CSP7_Project
{
    class Inventory
    {
        //Fields
        private string _partName, _partNumber;
        private double _markUpPct;
        private decimal _cost;

        //Constructor
        public Inventory(string partName, string partNumber, decimal cost, double markUpPct)
        {
            //Pass parameters though to fields via properties
            PartNumber = partNumber;
            PartName = partName;
            MarkUpPct = markUpPct;
            Cost = cost;
        }


        //Part Name Property
        public string PartName
        {
            get
            {
                return _partName;
            }
            set
            {
                _partName = value;
            }
        }

        //Part Number Property
        public string PartNumber
        {
            get
            {
                return _partNumber;
            }
            set
            {
                _partNumber = value;
            }
        }

        //Cost Property
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
                else
                {
                    MessageBox.Show("Bad _cost vale: " + value);
                    _cost = (value * -1);
                }
            }
        }

        //Mark Up Percent Property
        public double MarkUpPct
        {
            get
            {
                return _markUpPct;
            }
            set
            {
                if (value >= 0)
                {
                    _markUpPct = value;
                }
                else
                {
                    MessageBox.Show("Bad _markUpPct vale: " + value);
                    _markUpPct = (value * -1);
                }
            }
        }

        //Price Property
        public decimal Price
        {
            get
            {
                return (_cost + (_cost * (decimal) _markUpPct));
            }
        }
    }
}
