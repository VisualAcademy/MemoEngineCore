using System;
using System.Windows.Forms;

namespace DevWindowsForms
{
    public partial class FrmWindowsForms : Form
    {
        public FrmWindowsForms()
        {
            InitializeComponent();
        }

        private void FrmWindowsForms_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Millisecond.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = $"{textBox1.Text} - {DateTime.Now.Millisecond}";
        }
    }
}
