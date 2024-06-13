using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testlecture
{
    public partial class Hard : Form
    {
        public Hard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            H1 H1Form = new H1();
            H1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            H2 H2Form = new H2();
            H2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            H3 H3Form = new H3();
            H3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            H4 H4Form = new H4();
            H4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            H5 H5Form = new H5();
            H5Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            H6 H6Form = new H6();
            H6Form.Show();
        }
    }
}
