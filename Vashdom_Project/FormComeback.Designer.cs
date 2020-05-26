namespace Vashdom_Project
{
    partial class FormComeback
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
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.listViewComeback = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(201, 113);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(183, 21);
            this.comboBoxClients.TabIndex = 0;
            // 
            // comboBoxMaterials
            // 
            this.comboBoxMaterials.FormattingEnabled = true;
            this.comboBoxMaterials.Location = new System.Drawing.Point(12, 113);
            this.comboBoxMaterials.Name = "comboBoxMaterials";
            this.comboBoxMaterials.Size = new System.Drawing.Size(183, 21);
            this.comboBoxMaterials.TabIndex = 1;
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(390, 113);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(183, 21);
            this.comboBoxStaff.TabIndex = 2;
            // 
            // listViewComeback
            // 
            this.listViewComeback.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewComeback.FullRowSelect = true;
            this.listViewComeback.GridLines = true;
            this.listViewComeback.HideSelection = false;
            this.listViewComeback.Location = new System.Drawing.Point(12, 140);
            this.listViewComeback.MultiSelect = false;
            this.listViewComeback.Name = "listViewComeback";
            this.listViewComeback.Size = new System.Drawing.Size(561, 259);
            this.listViewComeback.TabIndex = 3;
            this.listViewComeback.UseCompatibleStateImageBehavior = false;
            this.listViewComeback.View = System.Windows.Forms.View.Details;
            this.listViewComeback.SelectedIndexChanged += new System.EventHandler(this.listViewComeback_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование материала";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО клиента";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ФИО сотрудника";
            this.columnHeader3.Width = 181;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(12, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(183, 36);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(201, 405);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(183, 36);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Orange;
            this.buttonDel.Location = new System.Drawing.Point(390, 405);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(183, 36);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(13, 94);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(132, 13);
            this.labelMaterial.TabIndex = 13;
            this.labelMaterial.Text = "Строительный материал";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(201, 93);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 14;
            this.labelClient.Text = "Клиент";
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Location = new System.Drawing.Point(390, 94);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(60, 13);
            this.labelStaff.TabIndex = 15;
            this.labelStaff.Text = "Сотрудник";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vashdom_Project.Properties.Resources.Без_имени_11;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormComeback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(584, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewComeback);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.comboBoxMaterials);
            this.Controls.Add(this.comboBoxClients);
            this.Name = "FormComeback";
            this.Text = "Запросы на возврат средств";
            this.Load += new System.EventHandler(this.FormComeback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxMaterials;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.ListView listViewComeback;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}