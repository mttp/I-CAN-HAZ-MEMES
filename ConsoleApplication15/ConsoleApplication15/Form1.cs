using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            string fn = getNewFileName();
            if (!fn.Equals(""))
            {
                pictureBox1.Load(fn);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string overlaycolor = "#ffffff";
            System.Drawing.Image img = System.Drawing.Image.FromFile(pictureBox1.ImageLocation);
            Bitmap outputimage = TextOnImageOverlay.TextOverlayTop(img, textBoxTop.Text, overlaycolor);
            Bitmap outputimage2 = TextOnImageOverlay.TextOverlayBottom(outputimage, textBoxBottom.Text, overlaycolor);
            pictureBox1.Image = outputimage2;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog save1 = new System.Windows.Forms.SaveFileDialog();
            System.Windows.Forms.DialogResult dr1 = save1.ShowDialog();
            if (dr1 == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image.Save(save1.FileName);
            }
        }

        public string getNewFileName()
        {
            System.Windows.Forms.OpenFileDialog open1 = new System.Windows.Forms.OpenFileDialog();
            open1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            System.Windows.Forms.DialogResult dr1 = open1.ShowDialog();
            if (dr1 == System.Windows.Forms.DialogResult.OK)
            {
                return open1.FileName;
            }
            else return "";
        }

    }
}
