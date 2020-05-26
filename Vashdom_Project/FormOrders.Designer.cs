namespace Vashdom_Project
{
    partial class FormOrders
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
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMaterials = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
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
            this.comboBoxMaterials.Location = new System.Drawing.Point(12, 82);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterials.TabIndex = 0;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(12, 123);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 1;
            this.comboBoxClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxClients_SelectedIndexChanged);
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(12, 163);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStaff.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(12, 203);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(167, 66);
            this.listViewOrders.MultiSelect = false;
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(525, 157);
            this.listViewOrders.TabIndex = 4;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewOrders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id материала";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id клиента";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО клиента";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id сотрудника";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО сотрудника";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дата";
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Location = new System.Drawing.Point(10, 66);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(65, 13);
            this.labelMaterials.TabIndex = 5;
            this.labelMaterials.Text = "Материалы";
            this.labelMaterials.Click += new System.EventHandler(this.labelMaterials_Click);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Location = new System.Drawing.Point(10, 106);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(51, 13);
            this.labelClients.TabIndex = 6;
            this.labelClients.Text = "Клиенты";
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Location = new System.Drawing.Point(10, 147);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(66, 13);
            this.labelStaff.TabIndex = 7;
            this.labelStaff.Text = "Сотрудники";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 187);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(72, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата заказа";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(167, 229);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(171, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(344, 229);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(171, 36);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Orange;
            this.buttonDel.Location = new System.Drawing.Point(521, 229);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(171, 36);
            this.buttonDel.TabIndex = 11;
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
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(773, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.labelMaterials);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxMaterials);
            this.Name = "FormOrders";
            this.Text = "Заявки на заказ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}