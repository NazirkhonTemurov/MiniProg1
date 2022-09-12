using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Form12 = this;
        }
        public static Form1 Form12;

        private void ButtonOk_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOk_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new LabsForms.Form_Lab1());

            
        }
        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            //form.AutoScroll = false;
            form.Dock = DockStyle.Fill;
            /*т form.FormBorderStyle = FormBorderStyle.None;*/
            main_Page.Controls.Add(form);
            form.Show();
        }

        private void main_Page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public static void clearPanel()
        {
           Form12.main_Page.Controls.Clear();
        }
    }
}
