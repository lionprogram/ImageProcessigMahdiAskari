using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessigMahdiAskari
{
    public partial class Form1 : Form
    {
        int mediane;
        public Form1()
        {
            InitializeComponent();
            counterTrackBar.Text = "128";
        }
        //انتخاب تصویر خاکستری
        private void selectGray_Click(object sender, EventArgs e)
        {
            OpenFileDialog Img_Open = new OpenFileDialog();
            Img_Open.Filter = "Image File(*.Gif; *.jpg)| *.Gif; *.jpg";
            Img_Open.Title = "بارگذاری تصویر";
            GrayPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Img_Open.ShowDialog() == DialogResult.OK)
            {

                GrayPicBox.Image = Image.FromFile(Img_Open.FileName);

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mediane = trackBar1.Value;
            counterTrackBar.Text = mediane.ToString();
        }

        private void ConvertToBinery_Click(object sender, EventArgs e)
        {
            Bitmap GrayPic = new Bitmap(GrayPicBox.Image);
            Bitmap result = new Bitmap(GrayPicBox.Image);
            Color pix1, pix2;
            int temp;
            for (int x = 0; x <= GrayPic.Width - 1; x++)
            {
                for (int y = 0; y <= GrayPic.Height - 1; y++)
                {
                    pix1 = GrayPic.GetPixel(x,y);
                    temp = pix1.R; // *R or G or B in gray scale image has same*
                    if (temp >= mediane)
                    {
                        pix2 = Color.FromArgb(0, 0, 0);
                        result.SetPixel(x, y, pix2);
                    }
                    else {
                        pix2 = Color.FromArgb(255, 255, 255);
                        result.SetPixel(x, y, pix2);
                    }
                }
                BinaryPic.Image = result;
            }
        }

        private void changeRedToBlue_Click(object sender, EventArgs e)
        {
            string method = comboBox1.SelectedItem.ToString();
            Bitmap GrayPic = new Bitmap(GrayPicBox.Image);
            Bitmap result = new Bitmap(GrayPicBox.Image);
            Color pix1, pix2;
            for (int x = 0; x <= GrayPic.Width - 1; x++)
            {
                for (int y = 0; y <= GrayPic.Height - 1; y++)
                {
                    pix1 = GrayPic.GetPixel(x, y);
                    if (method == "RED TO BLUE")
                    {
                        pix2 = Color.FromArgb(pix1.B, pix1.G, pix1.R);
                        result.SetPixel(x, y, pix2);
                    }
                    else if (method == "RED TO GREEN")
                    {
                        pix2 = Color.FromArgb(pix1.G, pix1.R, pix1.R);
                        result.SetPixel(x, y, pix2);
                    }
                    else if (method == "GREEN TO BLUE")
                    {
                        pix2 = Color.FromArgb(pix1.R, pix1.B, pix1.G);
                        result.SetPixel(x, y, pix2);
                    }
                }

            }
            BinaryPic.Image = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap GrayPic = new Bitmap(GrayPicBox.Image);
            Bitmap result = new Bitmap(GrayPicBox.Image);
            Color pix1, pix2;
            int intense,r,g,b;
            for (int x = 0; x <= GrayPic.Width - 1; x++)
            {
                for (int y = 0; y <= GrayPic.Height - 1; y++)
                {
                    pix1 = GrayPic.GetPixel(x, y);
                    r = pix1.R;
                    g = pix1.G;
                    b = pix1.B;
                    intense = (r + g + b) / 3;
                    if ((float)x <= ((float)GrayPicBox.Image.Width / (float)GrayPicBox.Image.Height) * (float)y)
                    {
                        pix2 = Color.FromArgb(intense, intense, intense);
                    }
                    else
                    {
                        pix2 = pix1;
                        
                    }
                    result.SetPixel(x, y, pix2);
                }

            }
            BinaryPic.Image = result;
        }
        //فلیپ افقی
        private void vertFlip_Click(object sender, EventArgs e)
        {
            Bitmap GrayPic = new Bitmap(GrayPicBox.Image);
            Bitmap result = new Bitmap(GrayPicBox.Image);
            Color pix1;
            int intense, r, g, b;
            for (int x = 0; x <= GrayPic.Width - 1; x++)
            {
                for (int y = 0; y <= GrayPic.Height - 1; y++)
                {
                    pix1 = GrayPic.GetPixel(x, y);
                    result.SetPixel(GrayPic.Width-1-x, y, pix1);
                }

            }
            BinaryPic.Image = result;
        }
        //Flip horizontal
        private void horFlip_Click(object sender, EventArgs e)
        {
            Bitmap GrayPic = new Bitmap(GrayPicBox.Image);
            Bitmap result = new Bitmap(GrayPicBox.Image);
            Color pix1;
            int intense, r, g, b;
            for (int x = 0; x <= GrayPic.Width - 1; x++)
            {
                for (int y = 0; y <= GrayPic.Height - 1; y++)
                {
                    pix1 = GrayPic.GetPixel(x, y);
                    result.SetPixel(x, GrayPic.Height-1-y, pix1);
                }

            }
            BinaryPic.Image = result;
        }
    }
}
