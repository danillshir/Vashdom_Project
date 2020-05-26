namespace Vashdom_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenStaff = new System.Windows.Forms.Button();
            this.buttonOpenOrders = new System.Windows.Forms.Button();
            this.buttonOpenMaterials = new System.Windows.Forms.Button();
            this.buttonOpenStorage = new System.Windows.Forms.Button();
            this.buttonComeback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenClients.Location = new System.Drawing.Point(11, 176);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(256, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenStaff
            // 
            this.buttonOpenStaff.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenStaff.Location = new System.Drawing.Point(12, 230);
            this.buttonOpenStaff.Name = "buttonOpenStaff";
            this.buttonOpenStaff.Size = new System.Drawing.Size(256, 48);
            this.buttonOpenStaff.TabIndex = 2;
            this.buttonOpenStaff.Text = "Сотрудники";
            this.buttonOpenStaff.UseVisualStyleBackColor = false;
            this.buttonOpenStaff.Click += new System.EventHandler(this.buttonOpenStaff_Click);
            // 
            // buttonOpenOrders
            // 
            this.buttonOpenOrders.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenOrders.Location = new System.Drawing.Point(12, 392);
            this.buttonOpenOrders.Name = "buttonOpenOrders";
            this.buttonOpenOrders.Size = new System.Drawing.Size(256, 48);
            this.buttonOpenOrders.TabIndex = 6;
            this.buttonOpenOrders.Text = "Заявки на заказ";
            this.buttonOpenOrders.UseVisualStyleBackColor = false;
            this.buttonOpenOrders.Click += new System.EventHandler(this.buttonOpenOrders_Click);
            // 
            // buttonOpenMaterials
            // 
            this.buttonOpenMaterials.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenMaterials.Location = new System.Drawing.Point(11, 284);
            this.buttonOpenMaterials.Name = "buttonOpenMaterials";
            this.buttonOpenMaterials.Size = new System.Drawing.Size(256, 48);
            this.buttonOpenMaterials.TabIndex = 4;
            this.buttonOpenMaterials.Text = "Строительные материалы";
            this.buttonOpenMaterials.UseVisualStyleBackColor = false;
            this.buttonOpenMaterials.Click += new System.EventHandler(this.buttonOpenMaterials_Click);
            // 
            // buttonOpenStorage
            // 
            this.buttonOpenStorage.BackColor = System.Drawing.Color.Orange;
            this.buttonOpenStorage.Location = new System.Drawing.Point(11, 338);
            this.buttonOpenStorage.Name = "buttonOpenStorage";
            this.buttonOpenStorage.Size = new System.Drawing.Size(256, 48);
            this.buttonOpenStorage.TabIndex = 5;
            this.buttonOpenStorage.Text = "Склад";
            this.buttonOpenStorage.UseVisualStyleBackColor = false;
            this.buttonOpenStorage.Click += new System.EventHandler(this.buttonOpenStorage_Click);
            // 
            // buttonComeback
            // 
            this.buttonComeback.BackColor = System.Drawing.Color.Orange;
            this.buttonComeback.Location = new System.Drawing.Point(11, 446);
            this.buttonComeback.Name = "buttonComeback";
            this.buttonComeback.Size = new System.Drawing.Size(256, 48);
            this.buttonComeback.TabIndex = 7;
            this.buttonComeback.Text = "Запросы на возврат средств";
            this.buttonComeback.UseVisualStyleBackColor = false;
            this.buttonComeback.Click += new System.EventHandler(this.buttonComeback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vashdom_Project.Properties.Resources.Без_имени_11;
            this.pictureBox1.Location = new System.Drawing.Point(11, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(11, 13);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 13);
            this.labelHello.TabIndex = 8;
            this.labelHello.Text = "Привет";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(279, 538);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonComeback);
            this.Controls.Add(this.buttonOpenOrders);
            this.Controls.Add(this.buttonOpenStorage);
            this.Controls.Add(this.buttonOpenMaterials);
            this.Controls.Add(this.buttonOpenStaff);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vashdom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenStaff;
        private System.Windows.Forms.Button buttonOpenOrders;
        private System.Windows.Forms.Button buttonOpenMaterials;
        private System.Windows.Forms.Button buttonOpenStorage;
        private System.Windows.Forms.Button buttonComeback;
        private System.Windows.Forms.Label labelHello;
    }
}

