namespace Converter
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.историяToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitApplaction);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьИсториюToolStripMenuItem,
            this.очиститьИсториюToolStripMenuItem});
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // открытьИсториюToolStripMenuItem
            // 
            this.открытьИсториюToolStripMenuItem.Name = "открытьИсториюToolStripMenuItem";
            this.открытьИсториюToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.открытьИсториюToolStripMenuItem.Text = "Открыть историю";
            this.открытьИсториюToolStripMenuItem.Click += new System.EventHandler(this.открытьИсториюToolStripMenuItem_Click);
            // 
            // очиститьИсториюToolStripMenuItem
            // 
            this.очиститьИсториюToolStripMenuItem.Name = "очиститьИсториюToolStripMenuItem";
            this.очиститьИсториюToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.очиститьИсториюToolStripMenuItem.Text = "Очистить историю";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(412, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddDigit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDigit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddDigit);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "D";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddDigit);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddDigit);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(65, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "F";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddDigit);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(114, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 38);
            this.button7.TabIndex = 2;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AddDigit);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(163, 222);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 38);
            this.button8.TabIndex = 2;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AddDigit);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(16, 336);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 38);
            this.button13.TabIndex = 2;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.AddDigit);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(258, 222);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(43, 38);
            this.button18.TabIndex = 2;
            this.button18.Text = "BS";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.DoBackspace);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(258, 169);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 38);
            this.button20.TabIndex = 2;
            this.button20.Text = "CE";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.DoClean);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(65, 336);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(43, 38);
            this.button21.TabIndex = 2;
            this.button21.Text = "8";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.AddDigit);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(114, 336);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(43, 38);
            this.button22.TabIndex = 2;
            this.button22.Text = "9";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.AddDigit);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(258, 279);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(43, 38);
            this.button23.TabIndex = 2;
            this.button23.Text = "+/-";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ChangeSign);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(258, 336);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(43, 38);
            this.button24.TabIndex = 2;
            this.button24.Text = ".";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.AddDigit);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(16, 279);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(43, 38);
            this.button25.TabIndex = 2;
            this.button25.Text = "3";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.AddDigit);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(65, 279);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(43, 38);
            this.button26.TabIndex = 2;
            this.button26.Text = "4";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.AddDigit);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(114, 279);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(43, 38);
            this.button27.TabIndex = 2;
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.AddDigit);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(163, 279);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(43, 38);
            this.button28.TabIndex = 2;
            this.button28.Text = "6";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.AddDigit);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(163, 336);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(43, 38);
            this.button29.TabIndex = 2;
            this.button29.Text = "0";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.AddDigit);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(332, 247);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 70);
            this.button9.TabIndex = 3;
            this.button9.Text = "Перевести";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DoConversion);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(376, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ChangeSourceBasis);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(376, 148);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ChangeDestinBasis);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

