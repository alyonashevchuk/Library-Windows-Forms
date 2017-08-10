namespace Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиКнигуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститиСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рядокСтануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиКнигуToolStripMenuItem,
            this.змінитиКнигуToolStripMenuItem1,
            this.видалитиToolStripMenuItem,
            this.toolStripSeparator3,
            this.очиститиToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 98);
            // 
            // додатиКнигуToolStripMenuItem
            // 
            this.додатиКнигуToolStripMenuItem.Name = "додатиКнигуToolStripMenuItem";
            this.додатиКнигуToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.додатиКнигуToolStripMenuItem.Text = "Додати книгу";
            this.додатиКнигуToolStripMenuItem.Click += new System.EventHandler(this.додатиКнигуToolStripMenuItem_Click);
            // 
            // змінитиКнигуToolStripMenuItem1
            // 
            this.змінитиКнигуToolStripMenuItem1.Name = "змінитиКнигуToolStripMenuItem1";
            this.змінитиКнигуToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.змінитиКнигуToolStripMenuItem1.Text = "Редагувати книгу";
            this.змінитиКнигуToolStripMenuItem1.Click += new System.EventHandler(this.змінитиКнигуToolStripMenuItem1_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити вибране";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // очиститиToolStripMenuItem1
            // 
            this.очиститиToolStripMenuItem1.Name = "очиститиToolStripMenuItem1";
            this.очиститиToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.очиститиToolStripMenuItem1.Text = "Очистити список";
            this.очиститиToolStripMenuItem1.Click += new System.EventHandler(this.очиститиToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редагуванняToolStripMenuItem,
            this.видToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завантажитиЗФайлуToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.toolStripSeparator1,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // завантажитиЗФайлуToolStripMenuItem
            // 
            this.завантажитиЗФайлуToolStripMenuItem.Name = "завантажитиЗФайлуToolStripMenuItem";
            this.завантажитиЗФайлуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.завантажитиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.завантажитиЗФайлуToolStripMenuItem.Text = "Відкрити з файлу";
            this.завантажитиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.завантажитиЗФайлуToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // редагуванняToolStripMenuItem
            // 
            this.редагуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаКнигаToolStripMenuItem,
            this.редагуватиКнигуToolStripMenuItem,
            this.видалитиКнигуToolStripMenuItem,
            this.toolStripSeparator2,
            this.очиститиСписокToolStripMenuItem});
            this.редагуванняToolStripMenuItem.Name = "редагуванняToolStripMenuItem";
            this.редагуванняToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.редагуванняToolStripMenuItem.Text = "Редагування";
            // 
            // новаКнигаToolStripMenuItem
            // 
            this.новаКнигаToolStripMenuItem.Name = "новаКнигаToolStripMenuItem";
            this.новаКнигаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новаКнигаToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.новаКнигаToolStripMenuItem.Text = "Нова книга";
            this.новаКнигаToolStripMenuItem.Click += new System.EventHandler(this.новаКнигаToolStripMenuItem_Click);
            // 
            // редагуватиКнигуToolStripMenuItem
            // 
            this.редагуватиКнигуToolStripMenuItem.Name = "редагуватиКнигуToolStripMenuItem";
            this.редагуватиКнигуToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.редагуватиКнигуToolStripMenuItem.Text = "Редагувати книгу";
            this.редагуватиКнигуToolStripMenuItem.Click += new System.EventHandler(this.редагуватиКнигуToolStripMenuItem_Click);
            // 
            // видалитиКнигуToolStripMenuItem
            // 
            this.видалитиКнигуToolStripMenuItem.Name = "видалитиКнигуToolStripMenuItem";
            this.видалитиКнигуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.видалитиКнигуToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.видалитиКнигуToolStripMenuItem.Text = "Видалити вибране";
            this.видалитиКнигуToolStripMenuItem.Click += new System.EventHandler(this.видалитиКнигуToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // очиститиСписокToolStripMenuItem
            // 
            this.очиститиСписокToolStripMenuItem.Name = "очиститиСписокToolStripMenuItem";
            this.очиститиСписокToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.очиститиСписокToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.очиститиСписокToolStripMenuItem.Text = "Очистити список";
            this.очиститиСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститиСписокToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рядокСтануToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // рядокСтануToolStripMenuItem
            // 
            this.рядокСтануToolStripMenuItem.CheckOnClick = true;
            this.рядокСтануToolStripMenuItem.Name = "рядокСтануToolStripMenuItem";
            this.рядокСтануToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рядокСтануToolStripMenuItem.Text = "Рядок стану";
            this.рядокСтануToolStripMenuItem.CheckedChanged += new System.EventHandler(this.рядокСтануToolStripMenuItem_CheckedChanged);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колірToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // колірToolStripMenuItem
            // 
            this.колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            this.колірToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.колірToolStripMenuItem.Text = "Колір";
            this.колірToolStripMenuItem.Click += new System.EventHandler(this.колірToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідкаToolStripMenuItem1,
            this.проПрограмуToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // довідкаToolStripMenuItem1
            // 
            this.довідкаToolStripMenuItem1.Name = "довідкаToolStripMenuItem1";
            this.довідкаToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.довідкаToolStripMenuItem1.Text = "Довідка";
            this.довідкаToolStripMenuItem1.Click += new System.EventHandler(this.довідкаToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Усього книг";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel2.Text = "Номер поточної книги";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel3.Text = "Годинник";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem очиститиСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рядокСтануToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колірToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem додатиКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиКнигуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem1;
    }
}

