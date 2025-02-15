namespace Maytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            kq = a + b;
        txtketqua.Text = kq.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
