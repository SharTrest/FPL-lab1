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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.изменитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьКлассификаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКлассификаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстовыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(295, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обработка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(783, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите строку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(327, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обработанная строка";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(781, 27);
            this.textBox2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьФайлToolStripMenuItem,
            this.классификаторToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // изменитьФайлToolStripMenuItem
            // 
            this.изменитьФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьКлассификаторToolStripMenuItem,
            this.сохранитьКлассификаторToolStripMenuItem});
            this.изменитьФайлToolStripMenuItem.Name = "изменитьФайлToolStripMenuItem";
            this.изменитьФайлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.изменитьФайлToolStripMenuItem.Text = "Файл";
            // 
            // изменитьКлассификаторToolStripMenuItem
            // 
            this.изменитьКлассификаторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйToolStripMenuItem,
            this.таблицаExcelToolStripMenuItem});
            this.изменитьКлассификаторToolStripMenuItem.Name = "изменитьКлассификаторToolStripMenuItem";
            this.изменитьКлассификаторToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.изменитьКлассификаторToolStripMenuItem.Text = "Открыть классификатор";
            // 
            // текстовыйToolStripMenuItem
            // 
            this.текстовыйToolStripMenuItem.Name = "текстовыйToolStripMenuItem";
            this.текстовыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.текстовыйToolStripMenuItem.Text = "Текстовый";
            this.текстовыйToolStripMenuItem.Click += new System.EventHandler(this.текстовыйToolStripMenuItem_Click);
            // 
            // таблицаExcelToolStripMenuItem
            // 
            this.таблицаExcelToolStripMenuItem.Name = "таблицаExcelToolStripMenuItem";
            this.таблицаExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.таблицаExcelToolStripMenuItem.Text = "Таблица Excel";
            this.таблицаExcelToolStripMenuItem.Click += new System.EventHandler(this.таблицаExcelToolStripMenuItem_Click);
            // 
            // сохранитьКлассификаторToolStripMenuItem
            // 
            this.сохранитьКлассификаторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текстовыйДокументToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.сохранитьКлассификаторToolStripMenuItem.Name = "сохранитьКлассификаторToolStripMenuItem";
            this.сохранитьКлассификаторToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.сохранитьКлассификаторToolStripMenuItem.Text = "Сохранить классификатор";
            // 
            // текстовыйДокументToolStripMenuItem
            // 
            this.текстовыйДокументToolStripMenuItem.Name = "текстовыйДокументToolStripMenuItem";
            this.текстовыйДокументToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.текстовыйДокументToolStripMenuItem.Text = "Текстовый документ";
            this.текстовыйДокументToolStripMenuItem.Click += new System.EventHandler(this.текстовыйДокументToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.excelToolStripMenuItem.Text = "Таблица Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // классификаторToolStripMenuItem
            // 
            this.классификаторToolStripMenuItem.Name = "классификаторToolStripMenuItem";
            this.классификаторToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.классификаторToolStripMenuItem.Text = "Классификатор";
            this.классификаторToolStripMenuItem.Click += new System.EventHandler(this.классификаторToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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