namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            изменитьФайлToolStripMenuItem = new ToolStripMenuItem();
            изменитьКлассификаторToolStripMenuItem = new ToolStripMenuItem();
            текстовыйToolStripMenuItem = new ToolStripMenuItem();
            таблицаExcelToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКлассификаторToolStripMenuItem = new ToolStripMenuItem();
            текстовыйДокументToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            классификаторToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(258, 296);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(210, 31);
            button1.TabIndex = 0;
            button1.Text = "Обработка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 78);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(686, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 46);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 2;
            label1.Text = "Введите строку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(286, 119);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 3;
            label2.Text = "Обработанная строка";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 152);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(684, 23);
            textBox2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { изменитьФайлToolStripMenuItem, классификаторToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(700, 24);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // изменитьФайлToolStripMenuItem
            // 
            изменитьФайлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { изменитьКлассификаторToolStripMenuItem, сохранитьКлассификаторToolStripMenuItem });
            изменитьФайлToolStripMenuItem.Name = "изменитьФайлToolStripMenuItem";
            изменитьФайлToolStripMenuItem.Size = new Size(48, 20);
            изменитьФайлToolStripMenuItem.Text = "Файл";
            изменитьФайлToolStripMenuItem.Click += изменитьФайлToolStripMenuItem_Click_1;
            // 
            // изменитьКлассификаторToolStripMenuItem
            // 
            изменитьКлассификаторToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстовыйToolStripMenuItem, таблицаExcelToolStripMenuItem });
            изменитьКлассификаторToolStripMenuItem.Name = "изменитьКлассификаторToolStripMenuItem";
            изменитьКлассификаторToolStripMenuItem.Size = new Size(221, 22);
            изменитьКлассификаторToolStripMenuItem.Text = "Открыть классификатор";
            изменитьКлассификаторToolStripMenuItem.Click += изменитьКлассификаторToolStripMenuItem_Click;
            // 
            // текстовыйToolStripMenuItem
            // 
            текстовыйToolStripMenuItem.Name = "текстовыйToolStripMenuItem";
            текстовыйToolStripMenuItem.Size = new Size(150, 22);
            текстовыйToolStripMenuItem.Text = "Текстовый";
            текстовыйToolStripMenuItem.Click += текстовыйToolStripMenuItem_Click;
            // 
            // таблицаExcelToolStripMenuItem
            // 
            таблицаExcelToolStripMenuItem.Name = "таблицаExcelToolStripMenuItem";
            таблицаExcelToolStripMenuItem.Size = new Size(150, 22);
            таблицаExcelToolStripMenuItem.Text = "Таблица Excel";
            таблицаExcelToolStripMenuItem.Click += таблицаExcelToolStripMenuItem_Click;
            // 
            // сохранитьКлассификаторToolStripMenuItem
            // 
            сохранитьКлассификаторToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { текстовыйДокументToolStripMenuItem, excelToolStripMenuItem });
            сохранитьКлассификаторToolStripMenuItem.Name = "сохранитьКлассификаторToolStripMenuItem";
            сохранитьКлассификаторToolStripMenuItem.Size = new Size(221, 22);
            сохранитьКлассификаторToolStripMenuItem.Text = "Сохранить классификатор";
            сохранитьКлассификаторToolStripMenuItem.Click += сохранитьКлассификаторToolStripMenuItem_Click;
            // 
            // текстовыйДокументToolStripMenuItem
            // 
            текстовыйДокументToolStripMenuItem.Name = "текстовыйДокументToolStripMenuItem";
            текстовыйДокументToolStripMenuItem.Size = new Size(187, 22);
            текстовыйДокументToolStripMenuItem.Text = "Текстовый документ";
            текстовыйДокументToolStripMenuItem.Click += текстовыйДокументToolStripMenuItem_Click;
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(187, 22);
            excelToolStripMenuItem.Text = "Таблица Excel";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // классификаторToolStripMenuItem
            // 
            классификаторToolStripMenuItem.Name = "классификаторToolStripMenuItem";
            классификаторToolStripMenuItem.Size = new Size(105, 20);
            классификаторToolStripMenuItem.Text = "Классификатор";
            классификаторToolStripMenuItem.Click += классификаторToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem изменитьФайлКлассификатораToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem изменитьФайлToolStripMenuItem;
        private ToolStripMenuItem классификаторToolStripMenuItem;
        private ToolStripMenuItem изменитьКлассификаторToolStripMenuItem;
        private ToolStripMenuItem сохранитьКлассификаторToolStripMenuItem;
        private ToolStripMenuItem текстовыйToolStripMenuItem;
        private ToolStripMenuItem таблицаExcelToolStripMenuItem;
        private ToolStripMenuItem текстовыйДокументToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
    }
}