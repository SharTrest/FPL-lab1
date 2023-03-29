namespace WinFormsApp1
{
    partial class Classes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Save = new Button();
            Clean = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(799, 449);
            dataGridView1.TabIndex = 0;
            // 
            // Save
            // 
            Save.Location = new Point(806, 387);
            Save.Margin = new Padding(3, 2, 3, 2);
            Save.Name = "Save";
            Save.Size = new Size(106, 22);
            Save.TabIndex = 1;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Clean
            // 
            Clean.Location = new Point(806, 329);
            Clean.Margin = new Padding(3, 2, 3, 2);
            Clean.Name = "Clean";
            Clean.Size = new Size(106, 22);
            Clean.TabIndex = 2;
            Clean.Text = "Очистить";
            Clean.UseVisualStyleBackColor = true;
            Clean.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(806, 25);
            button1.Name = "button1";
            button1.Size = new Size(106, 27);
            button1.TabIndex = 3;
            button1.Text = "Автозаполнение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 450);
            Controls.Add(button1);
            Controls.Add(Clean);
            Controls.Add(Save);
            Controls.Add(dataGridView1);
            Name = "Classes";
            Text = "Classes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Save;
        private Button Clean;
        private Button button1;
    }
}