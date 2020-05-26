namespace Vashdom_Project
{
    partial class FormMaterials
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
            this.textBoxNameMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.listViewMaterials = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNameMaterial = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameMaterial
            // 
            this.textBoxNameMaterial.Location = new System.Drawing.Point(34, 135);
            this.textBoxNameMaterial.Name = "textBoxNameMaterial";
            this.textBoxNameMaterial.Size = new System.Drawing.Size(141, 20);
            this.textBoxNameMaterial.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(34, 186);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(141, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(34, 243);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(141, 20);
            this.textBoxCount.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(34, 296);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(141, 20);
            this.textBoxWeight.TabIndex = 3;
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(34, 348);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(141, 20);
            this.textBoxSupplier.TabIndex = 4;
            // 
            // listViewMaterials
            // 
            this.listViewMaterials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMaterials.FullRowSelect = true;
            this.listViewMaterials.GridLines = true;
            this.listViewMaterials.HideSelection = false;
            this.listViewMaterials.Location = new System.Drawing.Point(229, 119);
            this.listViewMaterials.MultiSelect = false;
            this.listViewMaterials.Name = "listViewMaterials";
            this.listViewMaterials.Size = new System.Drawing.Size(527, 249);
            this.listViewMaterials.TabIndex = 5;
            this.listViewMaterials.UseCompatibleStateImageBehavior = false;
            this.listViewMaterials.View = System.Windows.Forms.View.Details;
            this.listViewMaterials.SelectedIndexChanged += new System.EventHandler(this.listViewMaterials_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
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
            this.columnHeader4.Text = "Количество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Вес";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Производитель";
            // 
            // labelNameMaterial
            // 
            this.labelNameMaterial.AutoSize = true;
            this.labelNameMaterial.Location = new System.Drawing.Point(31, 119);
            this.labelNameMaterial.Name = "labelNameMaterial";
            this.labelNameMaterial.Size = new System.Drawing.Size(141, 13);
            this.labelNameMaterial.TabIndex = 6;
            this.labelNameMaterial.Text = "Наименование материала";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(34, 167);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(31, 227);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Количество";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(31, 280);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(26, 13);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(31, 332);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(86, 13);
            this.labelSupplier.TabIndex = 10;
            this.labelSupplier.Text = "Производитель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vashdom_Project.Properties.Resources.Без_имени_11;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Location = new System.Drawing.Point(229, 374);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 36);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(421, 376);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(146, 36);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Orange;
            this.buttonDel.Location = new System.Drawing.Point(610, 376);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(146, 36);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelNameMaterial);
            this.Controls.Add(this.listViewMaterials);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxNameMaterial);
            this.Name = "FormMaterials";
            this.Text = "Строительные материалы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameMaterial;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.ListView listViewMaterials;
        private System.Windows.Forms.Label labelNameMaterial;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}