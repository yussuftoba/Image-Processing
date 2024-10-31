using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Editor
{
    public partial class Rotate : Form
    {
        Image img;
        Image non_img;
        public Rotate(Image fileImage)
        {
            InitializeComponent();
            pictureBox1.Image = fileImage;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            non_img = pictureBox1.Image;
            this.Hide();
            Form1 f = new Form1(non_img, null);
            f.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1(img, null);
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = img;
        }

        private void Rotate_Load(object sender, EventArgs e)
        {

        }
    }
}
