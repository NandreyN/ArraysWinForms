﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class input : Form
    {
        private readonly output _outputForm;
        public input()
        {
            _outputForm = new output();
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            string aText = ArrayA.Text;
            string bText = ArrayB.Text;

            if (string.IsNullOrEmpty(aText) || string.IsNullOrEmpty(bText))
            {
                MessageBox.Show("Fill in the fields");
                return;
            }
            aText = aText.Trim();
            bText = bText.Trim();

            List<string> aValuesStr = aText.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            List<string> bValuesStr = bText.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            List<double> aValues = aValuesStr.Select(x => Double.Parse(x)).ToList();
            List<double> bValues = bValuesStr.Select(x => Double.Parse(x)).ToList();

            if (aValues.Count != bValues.Count)
            {
                MessageBox.Show("Different size");
                return;
            }
            _outputForm.Update(aValues, bValues);
            _outputForm.Show();
        }
    }
}
