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
    public partial class Form2 : Form
    {
        Point current = new Point();
        Point old = new Point();
        Graphics g;
        Graphics graph;
        Pen pen = new Pen(Color.Black, 5);
        Bitmap surface;

        public Form2()
        {
            InitializeComponent();
            g = canvaspanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            surface = new Bitmap(canvaspanel.Width, canvaspanel.Height);
            graph = Graphics.FromImage(surface);
            canvaspanel.BackgroundImage = surface;
            canvaspanel.BackgroundImageLayout = ImageLayout.None;
        }
        private void canvas_mousedown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);
                old = current;
            }
        }
        Point mouseoffesetpos;
        Boolean ismousedown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseoffesetpos = new Point(-e.X, -e.Y);
                ismousedown = true;
            }
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown)
            {
                Point mousepos = Control.MousePosition;
                mousepos.Offset(mouseoffesetpos.X, mouseoffesetpos.Y);
                this.Location = mousepos;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ismousedown = false;
            }
        }
        private void colorbox_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                colorbox.BackColor = cd.Color;
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*  private void eraser_button_Click(object sender, EventArgs e)
          {
              pen.Color = Color.White;
          }*/

        /*  private void paintbrush_button_Click(object sender, EventArgs e)
          {
              pen.Color = colorbox.BackColor;
          }*/

        /* private void clear_button_Click(object sender, EventArgs e)
         {
             graph.Clear(Color.White);
             canvaspanel.Invalidate();
         }*/


        /* private void save_button_Click(object sender, EventArgs e)
         {
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "png Files(*png)|*.png";
             sfd.DefaultExt = "png";
             sfd.AddExtension = true;
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
             }
         }*/



        /*  private void paintbrushsize_changed(object sender, EventArgs e)
          {
              pen.Width = (float)paintbrush_size.Value;
          }*/

        private void eraser_button_Click_1(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void paintbrush_size_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)paintbrush_size.Value;
        }

        private void save_button_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "png Files(*png)|*.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void clear_button_Click_1(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            canvaspanel.Invalidate();
        }

        private void paintbrush_button_Click_1(object sender, EventArgs e)
        {
            pen.Color = colorbox.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
