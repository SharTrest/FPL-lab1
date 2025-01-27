﻿using System;
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
        private string[] code = new string[32];
        public Classes(string[] code)
        {
            this.code = code;
            InitializeComponent();
            int k = 0;
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 18;
            for (int i = 0; i < 18 && k < code.Length; i++)
            {
                for (int j = 0; j < 4 && k < code.Length; j++)
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


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < 18 && k < code.Length; i++)
            {
                for (int j = 0; j < 4 && k < code.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        if (dataGridView1[j, i].Value != null)
                            code[k] = dataGridView1[j, i].Value.ToString();
                        k++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить классификатор?", "Очистка классификатора", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)

            {
                int k = 0;
                for (int i = 0; i < 18 && k < code.Length; i++)
                {
                    for (int j = 0; j < 4 && k < code.Length; j++)
                    {
                        if (j % 2 == 1)
                        {
                            if (dataGridView1[j, i].Value != null)
                            {
                                code[k] = null;
                                dataGridView1[j, i].Value = null;
                            }
                            k++;
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < 18 && k < code.Length; i++)
            {
                for (int j = 0; j < 4 && k < code.Length; j++)
                {
                    if (j % 2 == 1)
                    {

                        code[k] = Convert.ToString(k + 1072, 2);
                        dataGridView1[j, i].Value = code[k];
                        k++;
                    }
                }
            }
        }
    }
}
