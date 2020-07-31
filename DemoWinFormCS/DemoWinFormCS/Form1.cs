using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinFormCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtN1.Text);
            b = Convert.ToInt32(txtN2.Text);
            c = a + b;
            txtResult.Text = c.ToString();
        }
    }
}
