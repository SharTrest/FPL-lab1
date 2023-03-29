using System.Text;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Lab1 lab1 = new Lab1();
        public string[] code = new string[32];
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

        }

        private void сохранитьКлассификаторToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void текстовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "текст (txt) |*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Выберите текстовый документ";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lab1.path = openFileDialog.FileName;
                lab1.codeNamesTxt(code);
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void текстовыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileFialog = new SaveFileDialog();
            saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileFialog.Filter = "Текст (txt) |*.txt;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            saveFileFialog.RestoreDirectory = true;
            saveFileFialog.Title = "Сохранение классификатора в формате txt";

            if (saveFileFialog.ShowDialog() == DialogResult.OK)
            {
                if (code != null)
                {
                    using (FileStream newf = new FileStream(saveFileFialog.FileName, FileMode.Create)) { }
                    using (FileStream fileWrite = new FileStream(saveFileFialog.FileName, FileMode.Append))
                    {
                        using (StreamWriter stream = new StreamWriter(fileWrite))
                        {

                            for (int i = 0; i < code.Length; i++)
                            {
                                int ch = i + 1072;


                                if (code[i] != null)
                                {
                                    string str = ((char)ch).ToString() + " = " + code[i].ToString() + "\n";
                                    stream.Write(str);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void таблицаExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "Выберите документ Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lab1.path = ofd.FileName;
            lab1.codeNamesXLS(code);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            sfd.RestoreDirectory = true;
            sfd.Title = "Сохранение классификатора в формате xls";


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (code != null)
                {
                    Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                    Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
                    Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

                    sheet.Name = "Классификатор";
                    int k = 0;
                    for (int i = 1; i <= 2; i++)
                    {
                        for (int j = 1; j <= 32; j++)
                        {
                            if (i == 1)
                            {
                                int ch = j - 1 + 1072;
                                char sym = (char)ch;
                                sheet.Cells[j, i] = sym.ToString(); 
                            }
                            else
                            {
                                if (code[j-1] != null)
                                    sheet.Cells[j, i] = code[j-1].ToString();
                            }
                        }
                    }

                    workBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


                    ex.Quit();

                    workBook = null;
                    sheet = null;
                    ex = null;

                    lab1.CloseProcess();
                }

            }
            
        }

    }
}