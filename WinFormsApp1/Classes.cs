using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Classes : Form
    {
        public Classes(string[] code)
        {
            InitializeComponent();
            int k = 0;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 18;
            for (int i = 0; i < 18 && k < 33; i++)
            {
                for (int j = 0; j < 4 && k < 33; j++)
                {
                    if (j % 2 == 1)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = code[k];
                        k++;
                    }
                    else
                    {
                        int val = k + 1072;
                        dataGridView1.Rows[i].Cells[j].Value = (char)val;
                    }
                }
            }
        }

        public void Classes_Load()
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
