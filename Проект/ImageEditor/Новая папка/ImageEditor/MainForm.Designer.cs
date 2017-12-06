namespace ImageEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.images_dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagedataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contoursDataSet1 = new ImageEditor.ContoursDataSet1();
            this.countours_dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processed_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_data = new System.Windows.Forms.DataGridViewImageColumn();
            this.contoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.image_pb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contour_pb = new System.Windows.Forms.PictureBox();
            this.contoursTableAdapter = new ImageEditor.ContoursDataSet1TableAdapters.ContoursTableAdapter();
            this.imageTableAdapter = new ImageEditor.ContoursDataSet1TableAdapters.ImageTableAdapter();
            this.delete_image = new System.Windows.Forms.Button();
            this.del_contour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.images_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countours_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contour_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // images_dgv
            // 
            this.images_dgv.AllowUserToAddRows = false;
            this.images_dgv.AllowUserToDeleteRows = false;
            this.images_dgv.AllowUserToResizeRows = false;
            this.images_dgv.AutoGenerateColumns = false;
            this.images_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.images_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.user_login,
            this.create_date,
            this.imagedataDataGridViewImageColumn});
            this.images_dgv.DataSource = this.imageBindingSource;
            this.images_dgv.Location = new System.Drawing.Point(13, 41);
            this.images_dgv.MultiSelect = false;
            this.images_dgv.Name = "images_dgv";
            this.images_dgv.ReadOnly = true;
            this.images_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.images_dgv.Size = new System.Drawing.Size(436, 203);
            this.images_dgv.TabIndex = 0;
            this.images_dgv.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // user_login
            // 
            this.user_login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_login.DataPropertyName = "user_login";
            this.user_login.HeaderText = "Добавил";
            this.user_login.Name = "user_login";
            this.user_login.ReadOnly = true;
            // 
            // create_date
            // 
            this.create_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "Дата";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            // 
            // imagedataDataGridViewImageColumn
            // 
            this.imagedataDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagedataDataGridViewImageColumn.DataPropertyName = "image_data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagedataDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.imagedataDataGridViewImageColumn.HeaderText = "Предпросмотр";
            this.imagedataDataGridViewImageColumn.Name = "imagedataDataGridViewImageColumn";
            this.imagedataDataGridViewImageColumn.ReadOnly = true;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "Image";
            this.imageBindingSource.DataSource = this.contoursDataSet1;
            // 
            // contoursDataSet1
            // 
            this.contoursDataSet1.DataSetName = "ContoursDataSet1";
            this.contoursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countours_dgv
            // 
            this.countours_dgv.AllowUserToAddRows = false;
            this.countours_dgv.AllowUserToDeleteRows = false;
            this.countours_dgv.AllowUserToResizeRows = false;
            this.countours_dgv.AutoGenerateColumns = false;
            this.countours_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countours_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.processed_date,
            this.algorithm_id,
            this.dataGridViewTextBoxColumn1,
            this.algorithm_name,
            this.image_data});
            this.countours_dgv.DataSource = this.contoursBindingSource;
            this.countours_dgv.Location = new System.Drawing.Point(455, 41);
            this.countours_dgv.MultiSelect = false;
            this.countours_dgv.Name = "countours_dgv";
            this.countours_dgv.ReadOnly = true;
            this.countours_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.countours_dgv.Size = new System.Drawing.Size(445, 203);
            this.countours_dgv.TabIndex = 1;
            this.countours_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.countours_dgv.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // processed_date
            // 
            this.processed_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processed_date.DataPropertyName = "processed_date";
            this.processed_date.HeaderText = "Добавлен";
            this.processed_date.Name = "processed_date";
            this.processed_date.ReadOnly = true;
            // 
            // algorithm_id
            // 
            this.algorithm_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.algorithm_id.DataPropertyName = "algorithm_id";
            this.algorithm_id.HeaderText = "algorithm_id";
            this.algorithm_id.Name = "algorithm_id";
            this.algorithm_id.ReadOnly = true;
            this.algorithm_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Добавил";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // algorithm_name
            // 
            this.algorithm_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.algorithm_name.DataPropertyName = "algorithm_name";
            this.algorithm_name.HeaderText = "Алгоритм";
            this.algorithm_name.Name = "algorithm_name";
            this.algorithm_name.ReadOnly = true;
            // 
            // image_data
            // 
            this.image_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image_data.DataPropertyName = "image_data";
            this.image_data.HeaderText = "Миниатюра";
            this.image_data.Name = "image_data";
            this.image_data.ReadOnly = true;
            // 
            // contoursBindingSource
            // 
            this.contoursBindingSource.DataMember = "Contours";
            this.contoursBindingSource.DataSource = this.contoursDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить контур изображения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // image_pb
            // 
            this.image_pb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.image_pb.Location = new System.Drawing.Point(15, 267);
            this.image_pb.Name = "image_pb";
            this.image_pb.Size = new System.Drawing.Size(434, 252);
            this.image_pb.TabIndex = 4;
            this.image_pb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Предпросмотр изображения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Предпросмотр контуров изображения";
            // 
            // contour_pb
            // 
            this.contour_pb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contour_pb.Location = new System.Drawing.Point(455, 267);
            this.contour_pb.Name = "contour_pb";
            this.contour_pb.Size = new System.Drawing.Size(445, 252);
            this.contour_pb.TabIndex = 6;
            this.contour_pb.TabStop = false;
            // 
            // contoursTableAdapter
            // 
            this.contoursTableAdapter.ClearBeforeFill = true;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // delete_image
            // 
            this.delete_image.Location = new System.Drawing.Point(313, 12);
            this.delete_image.Name = "delete_image";
            this.delete_image.Size = new System.Drawing.Size(136, 23);
            this.delete_image.TabIndex = 8;
            this.delete_image.Text = "Удалить";
            this.delete_image.UseVisualStyleBackColor = true;
            this.delete_image.Click += new System.EventHandler(this.delete_image_Click);
            // 
            // del_contour
            // 
            this.del_contour.Location = new System.Drawing.Point(764, 12);
            this.del_contour.Name = "del_contour";
            this.del_contour.Size = new System.Drawing.Size(136, 23);
            this.del_contour.TabIndex = 9;
            this.del_contour.Text = "Удалить";
            this.del_contour.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 531);
            this.Controls.Add(this.del_contour);
            this.Controls.Add(this.delete_image);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contour_pb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image_pb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countours_dgv);
            this.Controls.Add(this.images_dgv);
            this.Name = "MainForm";
            this.Text = "Редактор базы контуров изображения";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.images_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countours_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contour_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView images_dgv;
        private System.Windows.Forms.DataGridView countours_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox image_pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox contour_pb;
        private ContoursDataSet1 contoursDataSet1;
        private System.Windows.Forms.BindingSource contoursBindingSource;
        private ContoursDataSet1TableAdapters.ContoursTableAdapter contoursTableAdapter;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private ContoursDataSet1TableAdapters.ImageTableAdapter imageTableAdapter;
        private System.Windows.Forms.Button delete_image;
        private System.Windows.Forms.Button del_contour;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewImageColumn imagedataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn processed_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn algorithm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn algorithm_name;
        private System.Windows.Forms.DataGridViewImageColumn image_data;
    }
}