using System.Text;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Lab1 lab1 = new Lab1();
        public string[] code = new string[33];
        public string path;

        public Form1()
        {
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

        private void классификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes(code);
            classes.ShowDialog();
        }

        private void изменитьФайлToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void изменитьКлассификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "текст (txt) |*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lab1.path = openFileDialog.FileName;
                lab1.codeNames(code);
            }
        }

        private void сохранитьКлассификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileFialog = new SaveFileDialog();
            saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileFialog.Filter = "Текст (txt) |*.txt;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            saveFileFialog.RestoreDirectory = true;

            if (saveFileFialog.ShowDialog() == DialogResult.OK)
            {
                if (code != null)
                {
                    using (FileStream newf = new FileStream(saveFileFialog.FileName, FileMode.Create)) { }
                    using (FileStream fileWrite = new FileStream(saveFileFialog.FileName, FileMode.Append))
                    {
                        using (StreamWriter stream = new StreamWriter(fileWrite))
                        {
                           
                            for (int i =0; i < 33; i++)
                            {
                                int ch = i + 1072;


                                if (code[i] != null)
                                {
                                    string str = ((char)ch).ToString() + " = " + code[i].ToString()+"\n";
                                    stream.Write(str);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void классификаторToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Classes classes = new Classes(code);
            classes.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}