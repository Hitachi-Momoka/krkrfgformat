using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Li.krkrfgformat
{
    //public delegate void MainFormImageChangeValue(Bitmap bitmap);
    public partial class ImageViewForm : Form
    {
        //public event MainFormImageChangeValue MainFormImageChange;
        //
        //移动图片相关
        //
        private bool pictureBoxIsMoving = false;
        private Point pictureBoxMouseFristDownLocation = new Point();
        private int mouseXOffset = 0, mouseYOffset = 0;
        private Point pictureBoxDefultLocation = new Point(0, 0);
        private int panelXStart, panelYStart;
        public Image Picture { set; get; }

        public ImageViewForm()
        { 
            InitializeComponent();
        }

        private void ImageViewBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxIsMoving && imageViewBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseXOffset = Control.MousePosition.X - pictureBoxMouseFristDownLocation.X;
                    mouseYOffset = Control.MousePosition.Y - pictureBoxMouseFristDownLocation.Y;

                    panel1.HorizontalScroll.Value = (panelXStart - mouseXOffset > 0) ? panelXStart - mouseXOffset : 0;
                    panel1.VerticalScroll.Value = (panelYStart - mouseYOffset > 0) ? panelYStart - mouseYOffset : 0;
                    imageViewBox.Refresh();
                }
            }
        }

        private void ImageViewBox_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxIsMoving = false;
            imageViewBox.Cursor = Cursors.Default;
        }

        private void ImageViewBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (imageViewBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBoxIsMoving = true;
                    pictureBoxMouseFristDownLocation = Control.MousePosition;
                    panelXStart = panel1.HorizontalScroll.Value;
                    panelYStart = panel1.VerticalScroll.Value;
                    imageViewBox.Cursor = Cursors.Hand;
                }
            }
        }

        public void PictureChange(Bitmap bitmap)
        {
            //int XScroll = panel1.HorizontalScroll.Value;
            //int YScroll = panel1.VerticalScroll.Value;
            //Size oldPicSize = Picture.Size;
            panel1.AutoScroll = true;
            Picture = bitmap;
            //imageViewBox.BackgroundImage = Li.Drawing.Picture.CreatBackImage(Picture.Width, Picture.Height);
            imageViewBox.Image = Picture;
            PicLocationSet();
            //panel1.HorizontalScroll.Value = (XScroll / oldPicSize.Width) * Picture.Size.Width;
            //panel1.VerticalScroll.Value = (YScroll / oldPicSize.Height) * Picture.Size.Height;

            //PicLocationSet();

        }

        private void ImageViewForm_SizeChanged(object sender, EventArgs e)
        {
            if(imageViewBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                imageViewBox.Size = panel1.Size;
            }
            else
            {
                PicLocationSet();
            }
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = toolStripComboBox1.SelectedIndex;
            switch (selectedItem)
            {
                case 0:
                    panel1.AutoScroll = true;
                    imageViewBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    panel1.AutoScroll = false;
                    imageViewBox.Size = panel1.Size;
                    imageViewBox.Location = new Point(0, 0);
                    imageViewBox.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                default:
                    panel1.AutoScroll = false;
                    imageViewBox.Location = new Point(0, 0);
                    imageViewBox.Size = panel1.Size;
                    imageViewBox.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

            }
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Value = 0;
            panel1.VerticalScroll.Value = 0;
            imageViewBox.Size = Picture.Size;
            imageViewBox.Location = new Point(0, 0);
            //imageViewBox.BackgroundImage = Li.Drawing.Picture.CreatBackImage(Picture.Width, Picture.Height);
            imageViewBox.Image = Picture;
        }
        private void PicLocationSet()
        {
            if (imageViewBox.Image == null)
                return;
            if (imageViewBox.Image.Width > panel1.Size.Width || imageViewBox.Image.Height > panel1.Size.Height)
            {
                
                panel1.AutoScroll = true;
            }
            else 
            {
                imageViewBox.BackColor = System.Drawing.Color.White;
                imageViewBox.Size = imageViewBox.Image.Size;
                Point p = new Point
                {
                    X = panel1.Size.Width / 2 - (imageViewBox.Image.Width / 2),
                    Y = panel1.Size.Height / 2 - (imageViewBox.Image.Height / 2)
                };
                imageViewBox.Location = p;
                panel1.AutoScroll = true;
            }
        }

        public void ClearForm()
        {
            imageViewBox.Image = null;
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Value = 0;
            panel1.VerticalScroll.Value = 0;
            imageViewBox.Size = new Size(0, 0);
            toolStripComboBox1.SelectedIndex = 0;
        }
    }
}
