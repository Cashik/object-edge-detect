using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageEditor;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        private Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "All files|*.*|PNG|*.png|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            file_dialog.FilterIndex = 1;
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(file_dialog.FileName);
                try
                {
                    bitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                    streamReader.Close();

                    StartPicture.Image = bitmap;

                    ChooseFileBtn.Text = file_dialog.FileName;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Вы выбрали неверный документ!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        private void SobelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.Sobel3x3Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        private void Sobel5x5Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.Sobel5x5Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Kirsch_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.KirschFilter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.PrewittFilter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Laplacian3x3Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.Laplacian3x3Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Laplacian5x5Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultPicture.Image = bitmap.Laplacian5x5Filter(GaussianCB.Checked, BlackWhiteCB.Checked);
            }
            catch (ImageNotFoundException ex)
            {
                MessageBox.Show("Вы не выбрали изображение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void ResultPicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }
                ResultPicture.Image.Save(sfd.FileName, format);
            }
        }
    }
}
