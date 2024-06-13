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
    public partial class Medium : Form
    {
        public Medium()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M1 M1Form = new M1();
            M1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M2 M2Form = new M2();
            M2Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            M3 M3Form = new M3();
            M3Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            M4 M4Form = new M4();
            M4Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            M5 M5Form = new M5();
            M5Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            M6 M6Form = new M6();
            M6Form.Show();
        }
    }
}
