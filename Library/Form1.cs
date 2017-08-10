using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library
{
    public partial class Form1 : Form
    {
        Book b = null;
        BinaryFormatter formatter = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void завантажитиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text|*.txt||";
            openFileDialog1.FilterIndex = 1;
            Program.mylst.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var fStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Program.mylst = (List<Book>)formatter.Deserialize(fStream);
                }
            }
            foreach (Book b in Program.mylst)
                listBox1.Items.Add(b);
            toolStripStatusLabel1.Text = "Усього книг: " + listBox1.Items.Count;
            toolStripStatusLabel2.Text = "Номер поточної книги: " + (listBox1.SelectedIndex + 1).ToString();
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files|*.*|Text|*.txt|Document|*.doc||";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var fStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, Program.mylst);
                }
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Q = MessageBox.Show("Бажаєте зберегти зміни?", "Закриття програми", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (Q == DialogResult.Yes)
            {
                зберегтиЯкToolStripMenuItem_Click(sender, e);
                this.Close();
            }
            if (Q == DialogResult.No)
                this.Close();
            if (Q == DialogResult.Cancel)
                return;
        }

        private void новаКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = new Book();
            Form2 f = new Form2(b, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Program.mylst.Add(b);
                listBox1.Items.Add(b);
            }
            toolStripStatusLabel1.Text = "Усього книг: " + listBox1.Items.Count;
        }

        private void редагуватиКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = (Book)listBox1.SelectedItem;
            Form2 f = new Form2(b, false);
            if (f.ShowDialog() == DialogResult.OK)
            {
                int index = listBox1.SelectedIndex;
                Program.mylst.RemoveAt(index);
                Program.mylst.Insert(index, b);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, b);
            }
        }

        private void видалитиКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    Program.mylst.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            toolStripStatusLabel1.Text = "Усього книг: " + listBox1.Items.Count;
        }

        private void очиститиСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.mylst.Clear();
            listBox1.Items.Clear();
            toolStripStatusLabel1.Text = "Усього книг: " + listBox1.Items.Count;
        }

        private void рядокСтануToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (рядокСтануToolStripMenuItem.Checked)
                statusStrip1.Visible = true;
            else statusStrip1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusStrip1.Visible = false;
            timer1.Start();
            toolStripStatusLabel1.Text = "Усього книг: " + listBox1.Items.Count;
            toolStripStatusLabel2.Text = "Номер поточної книги: " + (listBox1.SelectedIndex + 1).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = String.Format(DateTime.Now.ToString("dd.MM.yyyy - HH:mm"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Номер поточної книги: " + (listBox1.SelectedIndex + 1).ToString();
        }

        private void колірToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            DialogResult Q = MessageBox.Show("Бажаєте змінити колір фону?", "Редагування кольору", MessageBoxButtons.YesNoCancel);
            if (Q == DialogResult.Yes)
            {
                color.ShowDialog();
                listBox1.BackColor = color.Color;
                DialogResult R = MessageBox.Show("Бажаєте змінити колір тексту?", "Редагування кольору", MessageBoxButtons.YesNoCancel);
                if (R == DialogResult.Yes)
                {
                    color.ShowDialog();
                    listBox1.ForeColor = color.Color;
                }
                if (R == DialogResult.No)
                    return;
                if (R == DialogResult.Cancel)
                    return;
            }
            if (Q == DialogResult.No)
            {
                DialogResult R = MessageBox.Show("Бажаєте змінити колір тексту?", "Редагування кольору", MessageBoxButtons.YesNoCancel);
                if (R == DialogResult.Yes)
                {
                    color.ShowDialog();
                    listBox1.ForeColor = color.Color;
                }
                if (R == DialogResult.No)
                    return;
                if (R == DialogResult.Cancel)
                    return;
            }
            if (Q == DialogResult.Cancel)
                return;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            DialogResult Q = MessageBox.Show("Бажаєте змінити шрифт тексту?", "Редагування тексту", MessageBoxButtons.YesNoCancel);
            if (Q == DialogResult.Yes)
            {
                font.ShowDialog();
                listBox1.Font = font.Font;
            }
            if (Q == DialogResult.No)
                return;
            if (Q == DialogResult.Cancel)
                return;
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Інформаційна система Бібліотека\n© 2016 Шевчук Альона ВПВм-11\nУсі права захищені.", "Про розробника", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розроблена інформаційна система проводить опрацювання списку книг і його відображення, організовує відповідне зберігання інформації", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void додатиКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            новаКнигаToolStripMenuItem_Click(sender, e);
        }

        private void змінитиКнигуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            редагуватиКнигуToolStripMenuItem_Click(sender, e);
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            видалитиКнигуToolStripMenuItem_Click(sender, e);
        }

        private void очиститиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            очиститиСписокToolStripMenuItem_Click(sender, e);
        }
        
    }
}
