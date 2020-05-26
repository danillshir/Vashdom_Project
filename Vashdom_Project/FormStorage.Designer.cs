namespace Vashdom_Project
{
    partial class FormStorage
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
            this.comboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.listViewStorage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMaterials = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMaterials
            // 
            this.comboBoxMaterials.FormattingEnabled = true;
            this.comboBoxMaterials.Location = new System.Drawing.Point(15, 124);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(314, 21);
            this.comboBoxMaterials.TabIndex = 0;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(15, 164);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(314, 20);
            this.textBoxLocation.TabIndex = 1;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            // 
            // listViewStorage
            // 
            this.listViewStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewStorage.FullRowSelect = true;
            this.listViewStorage.GridLines = true;
            this.listViewStorage.HideSelection = false;
            this.listViewStorage.Location = new System.Drawing.Point(335, 84);
            this.listViewStorage.MultiSelect = false;
            this.listViewStorage.Name = "listViewStorage";
            this.listViewStorage.Size = new System.Drawing.Size(491, 142);
            this.listViewStorage.TabIndex = 2;
            this.listViewStorage.UseCompatibleStateImageBehavior = false;
            this.listViewStorage.View = System.Windows.Forms.View.Details;
            this.listViewStorage.SelectedIndexChanged += new System.EventHandler(this.listViewStorage_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование материала";
            this.columnHeader2.Width = 151;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Вес";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Расположение склада";
            this.columnHeader5.Width = 129;
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Location = new System.Drawing.Point(12, 108);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(140, 13);
            this.labelMaterials.TabIndex = 3;
            this.labelMaterials.Text = "Строительные материалы";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 148);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(121, 13);
            this.labelLocation.TabIndex = 4;
            this.labelLocation.Text = "Расположение склада";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(17, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 36);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(229, 190);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 36);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Orange;
            this.buttonDel.Location = new System.Drawing.Point(123, 190);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 36);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vashdom_Project.Properties.Resources.Без_имени_11;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(838, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.listViewStorage);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.comboBoxMaterials);
            this.Name = "FormStorage";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.ListView listViewStorage;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}