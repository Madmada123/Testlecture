using static System.Windows.Forms.DataFormats;

namespace Testlecture
{
    public partial class Form1 : Form
    {
        public object SSForm { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void IKT_Click(object sender, EventArgs e)
        {
            IKT IKTForm = new IKT(); // Создаем новый экземпляр формы FormIKT
            IKTForm.Show();
        }

        private void EII_Click(object sender, EventArgs e)
        {
            EII EIIForm = new EII(); // Создаем новый экземпляр формы FormIKT
            EIIForm.Show();
        }

        private void KOMP_Click(object sender, EventArgs e)
        {
            KOMP KOMPForm = new KOMP();
            KOMPForm.Show();
        }

        private void SS_Click(object sender, EventArgs e)
        {
            SYSS SYSSForm = new SYSS();
            SYSSForm.Show();
        }

        private void GRAF_Click(object sender, EventArgs e)
        {
            GRAF GRAFForm = new GRAF();
            GRAFForm.Show();
        }

        private void DATAPRO_Click(object sender, EventArgs e)
        {
            DATA DATAForm = new DATA();
            DATAForm.Show();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            Form2 Form2Form = new Form2();
            Form2Form.Show();
        }
    }
}