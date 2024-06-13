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
    public partial class Light : Form
    {
        public Light()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            L1 L1Form = new L1();
            L1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            L2 L2Form = new L2();
            L2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L3 L3Form = new L3();
            L3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            L4 L4Form = new L4();
            L4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            L5 L5Form = new L5();
            L5Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            L6 L6Form = new L6();
            L6Form.Show();
        }
    }
}
