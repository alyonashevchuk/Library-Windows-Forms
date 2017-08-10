using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        Book b;
        bool addnew;
        public Form2(Book B, bool add)
        {
            InitializeComponent();
            addnew = add;
            b = B;
            if (!addnew)
            {
                textBox1.Text = b.Title;
                textBox2.Text = b.Author;
                textBox3.Text = b.Subject;
                textBox4.Text = b.Publish;
                textBox5.Text = b.Descrip;
                numericUpDown1.Value = b.Year;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(b.address);
                this.Text = "Редагування книги";
            }
            else
            {
                this.Text = "Нова книга";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files(*.*)|*.*|JPEG|*.jpg|PNG|*.png|BMP|*.bmp||";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == String.Empty || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Некоректне поле", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (b == null) b = new Book();
            b.Title = textBox1.Text;
            b.Author = textBox2.Text;
            b.Subject = textBox3.Text;
            b.Publish = textBox4.Text;
            b.Descrip = textBox5.Text;
            b.Year = (int)numericUpDown1.Value;
            b.address = openFileDialog1.FileName;
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
