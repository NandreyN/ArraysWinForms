using System;
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
        private output _outputForm;
        public input()
        {
            _outputForm = new output();
            InitializeComponent();
        }

        private void Process_Click(object sender, EventArgs e)
        {
            // A : 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
            // B : 7 4 6 9 22 23 45 44 7 8 9 11 10 5 7 80 0 14 16 33
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

            if (aValues.Count != bValues.Count && aValues.Count != 20)
            {
                MessageBox.Show("Check size( == 20)");
                return;
            }

            _outputForm = new output();
            _outputForm.Update(aValues, bValues);
            _outputForm.Show();
        }
    }
}
