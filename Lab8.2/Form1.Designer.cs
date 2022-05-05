namespace Lab8._2
{
    partial class Form1
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
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.левееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вышеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нижеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеПоложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьДанныеToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // очиститьДанныеToolStripMenuItem
            // 
            this.очиститьДанныеToolStripMenuItem.Name = "очиститьДанныеToolStripMenuItem";
            this.очиститьДанныеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.очиститьДанныеToolStripMenuItem.Text = "Очистить данные";
            this.очиститьДанныеToolStripMenuItem.Click += new System.EventHandler(this.очиститьДанныеToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.левееToolStripMenuItem,
            this.правееToolStripMenuItem,
            this.вышеToolStripMenuItem,
            this.нижеToolStripMenuItem,
            this.редактированиеПоложенияToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "label1",
            "label2",
            "textBox1",
            "textBox2",
            "button1",
            "button2"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Элемент";
            // 
            // левееToolStripMenuItem
            // 
            this.левееToolStripMenuItem.Name = "левееToolStripMenuItem";
            this.левееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.левееToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.левееToolStripMenuItem.Text = "Левее";
            this.левееToolStripMenuItem.Click += new System.EventHandler(this.левееToolStripMenuItem_Click);
            // 
            // правееToolStripMenuItem
            // 
            this.правееToolStripMenuItem.Name = "правееToolStripMenuItem";
            this.правееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.правееToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.правееToolStripMenuItem.Text = "Правее";
            this.правееToolStripMenuItem.Click += new System.EventHandler(this.правееToolStripMenuItem_Click);
            // 
            // вышеToolStripMenuItem
            // 
            this.вышеToolStripMenuItem.Name = "вышеToolStripMenuItem";
            this.вышеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.вышеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.вышеToolStripMenuItem.Text = "Выше";
            this.вышеToolStripMenuItem.Click += new System.EventHandler(this.вышеToolStripMenuItem_Click);
            // 
            // нижеToolStripMenuItem
            // 
            this.нижеToolStripMenuItem.Name = "нижеToolStripMenuItem";
            this.нижеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.нижеToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.нижеToolStripMenuItem.Text = "Ниже";
            this.нижеToolStripMenuItem.Click += new System.EventHandler(this.нижеToolStripMenuItem_Click);
            // 
            // редактированиеПоложенияToolStripMenuItem
            // 
            this.редактированиеПоложенияToolStripMenuItem.Checked = true;
            this.редактированиеПоложенияToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.редактированиеПоложенияToolStripMenuItem.Name = "редактированиеПоложенияToolStripMenuItem";
            this.редактированиеПоложенияToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.редактированиеПоложенияToolStripMenuItem.Text = "Редактирование положения";
            this.редактированиеПоложенияToolStripMenuItem.Click += new System.EventHandler(this.редактированиеПоложенияToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Действие 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Действие 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 215);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Задание 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem левееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вышеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нижеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеПоложенияToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

