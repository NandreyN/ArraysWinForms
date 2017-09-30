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

        private Tuple<List<double>, int> CalculateC()
        {
            int counter = 0;
            var zippedObject = _aData.Zip(_bData, (a, b) => new { AElem = a, BElem = b });
            List<double> c = new List<double>();

            foreach (var zip in zippedObject)
            {
                if (zip.AElem >= zip.BElem)
                {
                    c.Add(zip.AElem);
                    counter++;
                }
                else
                {
                    c.Add(zip.BElem);
                }
            }
            return new Tuple<List<double>, int>(c,counter);
        }

        private string ListToString(List<double> lst)
        {
            return string.Join(" ", lst.ToArray());
        }
        private void UpdateForm(string cText)
        {
            OutA.Text = ListToString(_aData);
            OutB.Text = ListToString(_bData);
            OutC.Text = cText;
        }

        public void Update(List<double> a, List<double> b)
        {
            _aData = a;
            _bData = b;
            var ret = CalculateC();
            UpdateForm(ListToString(ret.Item1) + ", replaced from A = " + ret.Item2.ToString());
        }

        private void OutC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
