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
    public partial class output : Form
    {
        private List<double> _aData;
        private List<double> _bData;
        public output()
        {
            _aData = null;
            _bData = null;
            InitializeComponent();
        }

        private void CalculateC(List<double> c)
        {
            int bCounter = 0, aCounter = 0;
            foreach (int i in Enumerable.Range(1, 20))
                c.Add(0);

            _aData.ForEach(a =>
            {
                bCounter = 0;
                _bData.ForEach(b =>
                {
                    if (a == b)
                        c[aCounter] = a;
                    bCounter++;
                });
                aCounter++;
            });
        }

        private string ListToString(List<double> lst)
        {
            return string.Join(" ", lst.ToArray());
        }
        private void UpdateForm(List<double> c)
        {
            OutA.Text = ListToString(_aData);
            OutB.Text = ListToString(_bData);
            OutC.Text = ListToString(c);
        }

        public void Update(List<double> a, List<double> b)
        {
            _aData = a;
            _bData = b;
            var c = new List<double>(20);
            CalculateC(c);
            UpdateForm(c);
        }

        private void OutC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
