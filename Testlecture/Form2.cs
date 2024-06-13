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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 Form1Form = new Form1();
            Form1Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Form3Form = new Form3();
            Form3Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Light LightForm = new Light();
            LightForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medium MediumForm = new Medium();
            MediumForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hard HardForm = new Hard();
            HardForm.Show();
        }
    }
}
