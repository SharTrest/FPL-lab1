namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Lab1 lab1 = new Lab1();
        public string[] code = new string[33];
        public string path;

        public Form1(string path)
        {
            this.path = path;
            code = lab1.codeNames(path, code);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str = textBox1.Text;
            char ch = str[0];
            if (char.IsDigit(ch))
            {
                textBox2.Text = lab1.decoding(str, code);
            }
            else
            {
                textBox2.Text = lab1.coding(str, code);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Path pathForm = new Path();
            pathForm.ShowDialog();
            lab1.path = pathForm.path;
            int a = 1;
        }

        private void èçìåíèòüÔàéëÊëàññèôèêàòîğàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void êëàññèôèêàòîğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(code);
            classes.ShowDialog();
        }

        private void èçìåíèòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Path path = new Path();
            path.ShowDialog();
            this.Close();
        }
    }
}