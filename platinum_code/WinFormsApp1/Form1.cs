namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.MdiParent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 sobre = new Form2();
            sobre.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 sobre = new Form2();
            sobre.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 sobre = new Form2();
            sobre.Show();
        }
    }
}
