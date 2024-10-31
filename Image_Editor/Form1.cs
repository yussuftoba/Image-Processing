using System.IO;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace Image_Editor
{
    

    public partial class Form1 : Form
    {
        bool open = false;
        public Image imageFile;
        OpenFileDialog OFD = new OpenFileDialog();

        Image reloaded_image;

        string imageName;

        public bool is_cropTool_btn_clicked = false;

        int crpX;
        int crpY;
        int rectW;
        int rectH;

        public Pen crpPen = new Pen(Color.White);

        public Form1(Image img, Image imageRecv)
        {
            InitializeComponent();
            if (imageRecv != null)
            {
                imageFile = imageRecv;
                pictureBox1.Image = imageFile;
            }
            imageFile = img;
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            if (img != null)
            {
                pictureBox1.Image = imageFile;
                open = true;
            }
            panel3.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_Read();
        }

        private void button1_Click(object sender, EventArgs e)// open file
        {

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                imageFile = Image.FromFile(OFD.FileName);
                pictureBox1.Image = imageFile;
                reloaded_image = Image.FromFile(OFD.FileName);

                imageName = OFD.FileName;

                open = true;


            }
        }

        private void button2_Click(object sender, EventArgs e) //save image
        {
            if (open)
            {
                SaveFileDialog saveF = new SaveFileDialog();

                saveF.Filter = "Images|*.png;*.jpg;*bmp";

                ImageFormat format = ImageFormat.Png;  // default format that the image will stored

                if (saveF.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveF.FileName);  // Get the extention from the path of the image

                    switch (extension)
                    {
                        case "jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case "bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case "png":
                            format = ImageFormat.Png;
                            break;
                    }

                    pictureBox1.Image.Save(saveF.FileName, format);
                    MessageBox.Show("Image saved successfully", "Saved message");
                }

            }
            else
            {
                MessageBox.Show("The image isn't loaded in the picture box", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)//close Form
        {
            add_to_history();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) //Reload form
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;

            if (open)
            {
                //imageFile = Image.FromFile(OFD.FileName);
                pictureBox1.Image = reloaded_image;
                open = true;
            }
        }

        private void button5_Click(object sender, EventArgs e) //frozen
        {
            button4_Click(null, null);                     // call reload function
            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0f, 0, 0, 0},
                    new float[]{0, 0, 1+5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}

                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA); ;

                g.Dispose();

                pictureBox1.Image = btm;
            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }

        private void button6_Click(object sender, EventArgs e)// redscale
        {
            button4_Click(null, null);

            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA); ;

                g.Dispose();

                pictureBox1.Image = btm;
            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }

        private void button7_Click(object sender, EventArgs e)// smoking
        {
            button4_Click(null, null);

            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA); ;

                g.Dispose();

                pictureBox1.Image = btm;
            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }

        private void button8_Click(object sender, EventArgs e)// flash
        {
            button4_Click(null, null);

            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
                    new float[]{0, 1+1.5f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA); ;

                g.Dispose();

                pictureBox1.Image = btm;

            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }

        private void reloadTrackBar() // this method will be used in trackbar only
        {
            if (open)
            {
                //imageFile = Image.FromFile(OFD.FileName);
                //to do

                pictureBox1.Image = reloaded_image;
                open = true;
            }
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)//red
        {
            float redValue = (float)trackBar1.Value * 0.1f;
            float greenValue = (float)trackBar2.Value * 0.1f;
            float blueValue = (float)trackBar3.Value * 0.1f;

            reloadTrackBar();

            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[] {1+redValue, 0           , 0          , 0, 0},
                    new float[] {0         , 1+greenValue, 0          , 0, 0},
                    new float[] {0         , 0           , 1+blueValue, 0, 0},
                    new float[] {0         , 0           , 0          , 1, 0},
                    new float[] {0         , 0           , 0          , 0, 1}
                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA);

                g.Dispose();

                pictureBox1.Image = btm;
            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)//green
        {
            trackBar1_ValueChanged(null, null);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)//blue
        {
            trackBar1_ValueChanged(null, null);
        }

        private void button9_Click(object sender, EventArgs e)//gray scale
        {
            float redValue = (float)trackBar1.Value * 0.1f;
            float greenValue = (float)trackBar2.Value * 0.1f;
            float blueValue = (float)trackBar3.Value * 0.1f;

            reloadTrackBar();

            if (open)
            {
                Image Img = pictureBox1.Image;
                Bitmap btm = new Bitmap(Img.Width, Img.Height);

                ImageAttributes IA = new ImageAttributes();

                ColorMatrix colormatrix = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                }
                );

                IA.SetColorMatrix(colormatrix);

                Graphics g = Graphics.FromImage(btm);

                g.DrawImage(Img, new Rectangle(0, 0, Img.Width, Img.Height), 0, 0, Img.Width, Img.Height, GraphicsUnit.Pixel, IA);

                g.Dispose();

                pictureBox1.Image = btm;
            }
            else
            {
                MessageBox.Show("Open the image first then change the filter");
            }
        }
        private void button10_Click(object sender, EventArgs e)//crop tool
        {
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();

            panel3.Visible = true;

            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //following code is for crop tool
        //The crop tool will work if you pressed select and click the left mouse
        //click and moved it over the photo to the right direction 
        private void button11_Click(object sender, EventArgs e) // select
        {
            pictureBox2.MouseDown += new MouseEventHandler(pictureBox2_mouseDown);

            pictureBox2.MouseMove += new MouseEventHandler(pictureBox2_mouseMove);

            pictureBox2.MouseEnter += new EventHandler(pictureBox2_mouseEnter);

            panel3.Controls.Add(pictureBox2);
        }

        private void pictureBox2_mouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;

            }
        }

        private void pictureBox2_mouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox2.Refresh();

                rectW = e.X - crpX;
                rectH = e.Y - crpY;

                Graphics g = pictureBox2.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void pictureBox2_mouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }
        private void button12_Click(object sender, EventArgs e) // crop
        {
            Cursor = Cursors.Default;
            Bitmap btm = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(btm, pictureBox2.ClientRectangle);

            Bitmap crpedImg = new Bitmap(rectW, rectH);

            for (int x = 0; x < rectW; x++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlClr = btm.GetPixel(crpX + x, crpY + y);
                    crpedImg.SetPixel(x, y, pxlClr);
                }
            }

            pictureBox3.Image = (Image)crpedImg;
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void button13_Click(object sender, EventArgs e) // ok
        {
            if (pictureBox3.Image == null)
            {
                MessageBox.Show("Please select area first");
            }
            else
            {
                pictureBox1.Image = pictureBox3.Image;
                button11.Hide();
                button12.Hide();
                button13.Hide();
                button14.Hide();
                panel3.Visible = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)//exit
        {
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            panel3.Visible = false;
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //this.Hide();
                //imageFile = pictureBox1.Image;
                //Rotate rotationForm = new Rotate(imageFile);
                //rotationForm.Show();
                Image img;

                img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
            else
            {
                MessageBox.Show("Open Picture First ");
            }
        }

        private void button16_Click(object sender, EventArgs e)  // flip
        {
            if (pictureBox1.Image != null)
            {
                Image img;
                img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Image = img;
            }
        }

        private void button17_Click(object sender, EventArgs e)  //clear
        {
            pictureBox1.Image = null;
            open = false;
        }

        private void add_to_history()
        {
            string date = DateTime.Now.ToString();
            if (File.Exists("history.csv"))
            {
                using (StreamWriter sw = new StreamWriter("history.csv", true))
                {
                    sw.WriteLine(imageName + ',' + date + ',');
                }
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }
        }

        private void listBox_Read()
        {
            if (File.Exists("history.csv"))
            {
                using (StreamReader sr = new StreamReader("history.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == null) continue;
                        string[] val = line.Split(',');
                        if (val[0] == "File Name")
                        {
                            continue;
                        }
                        else
                        {
                            string[] name = val[0].Split(@"\");
                            int index = name.Length - 1;
                            listBox1.Items.Add(name[index]);
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();

                using (StreamReader sr = new StreamReader("history.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == null) continue;
                        string[] val = line.Split(',');
                        string[] str = val[0].Split(@"\");
                        int index = str.Length - 1;
                        if (str[index] == selectedItem)
                        {
                            Image img = Image.FromFile(val[0]);

                            pictureBox1.Image = img;
                        }

                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}