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
    public partial class MakeContourForm : Form
    {
        Bitmap bitmap;
        int image_id;
        int algo_id;
        int user_id;
        ContoursDataSet1TableAdapters.ContoursTableAdapter adapter;

        public MakeContourForm(Bitmap img, int _user_id, int _img_id, ContoursDataSet1TableAdapters.ContoursTableAdapter _adapter)
        {
            InitializeComponent();
            bitmap = img;
            StartPicture.Image = img;

            adapter = _adapter;

            image_id = _img_id;
            user_id = _img_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ResultPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show(adapter.InsertQuery(ms.ToArray(), user_id, image_id, algo_id).ToString());
            }

        }

        private void SobelBtn_Click(object sender, EventArgs e)
        {
            algo_id = 1;

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
            algo_id = 2;
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
            algo_id = 5;
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
            algo_id = 6;
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
            algo_id = 3;
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
            algo_id = 4;
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
