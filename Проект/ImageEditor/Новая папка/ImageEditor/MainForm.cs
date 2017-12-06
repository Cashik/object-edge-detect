using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        int user_id;
        public MainForm(int _id)
        {
            InitializeComponent();

            user_id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Filter = "PNG|*.png|JPEGs|*.jpg|Bitmaps|*.bmp";
            file_dialog.FilterIndex = 1;
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                // добавляем в таблицу новый рисунок
                Image img = Image.FromFile(file_dialog.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageTableAdapter.InsertQuery(ms.ToArray(), user_id);
                    imageTableAdapter.Fill(contoursDataSet1.Image);
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "contoursDataSet1.Image". При необходимости она может быть перемещена или удалена.
            this.imageTableAdapter.Fill(this.contoursDataSet1.Image);
            this.contoursTableAdapter.Fill(this.contoursDataSet1.Contours);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (images_dgv.SelectedRows.Count == 1)
            {
                int selectedRowIndex = images_dgv.SelectedCells[0].RowIndex;
                var ms = new MemoryStream((byte[])images_dgv.Rows[selectedRowIndex].Cells[3].Value);
                image_pb.Image = Image.FromStream(ms);

                //MakeContourForm mcf = new MakeContourForm(bitmap);
                // mcf.ShowDialog();
                //mcf.Close();
            }
            else
            {
                MessageBox.Show("Выберите изображение для выведения контуров.", "Ошибка");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (images_dgv.SelectedRows.Count == 1)
            {
                int selectedRowIndex = images_dgv.SelectedCells[0].RowIndex;
                var ms = new MemoryStream((byte[])images_dgv.Rows[selectedRowIndex].Cells[3].Value);
                Bitmap image = (Bitmap)Image.FromStream(ms);

                MakeContourForm mcf = new MakeContourForm(image, user_id, (int)images_dgv.Rows[selectedRowIndex].Cells[0].Value, contoursTableAdapter);
                mcf.ShowDialog();
                mcf.Close();
                contoursTableAdapter.Fill(contoursDataSet1.Contours);
            }
            else
            {
                MessageBox.Show("Выберите строку.", "Ошибка");
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (countours_dgv.SelectedRows.Count == 1)
            {
                int selectedRowIndex = countours_dgv.SelectedCells[0].RowIndex;
                var ms = new MemoryStream((byte[])countours_dgv.Rows[selectedRowIndex].Cells[5].Value);
                contour_pb.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Выберите строку.", "Ошибка");
            }
        }

        private void delete_image_Click(object sender, EventArgs e)
        {
            // проверяем, выделена ли хоть одна запись
            if (images_dgv.SelectedRows.Count > 0)
            {

                // спрашиваем пользователя, действительно ли он хочет удалить записи
                if (MessageBox.Show(String.Format("Будет удалено {0} записей, продолжить?", (images_dgv.SelectedRows.Count.ToString())),
                    "Предупреждение",
                    MessageBoxButtons.YesNo, // данный параметр устанавливает, что в окне будут кнопки Да/нет
                    MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    int count = 0;

                    for (int i = 0; i < images_dgv.SelectedRows.Count; i++)
                    {
                        count+= imageTableAdapter.DeleteQuery(0);
                        count += imageTableAdapter.InsertQuery(0);

                    }

                    // если во время выполнения запроса не вылетело исключений,
                    // то товар удален, по эnтому обновляем таблицу
                    imageTableAdapter.Fill(contoursDataSet1.Image);

                }
            }
            else
            {
                // если ничего не выделено, то ошибка и конец
                MessageBox.Show("Выделите изображения для удаления!", "Ошибка");
            };
        }
    }
}
