namespace task3_DataGrid_v1NailWarehouse.Forms
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureNail = new System.Windows.Forms.PictureBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.lengthNUD = new System.Windows.Forms.NumericUpDown();
            this.materialCB = new System.Windows.Forms.ComboBox();
            this.minCountNUD = new System.Windows.Forms.NumericUpDown();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.countNUD = new System.Windows.Forms.NumericUpDown();
            this.LengthLb = new System.Windows.Forms.Label();
            this.MaterialLb = new System.Windows.Forms.Label();
            this.CountLb = new System.Windows.Forms.Label();
            this.minCountLb = new System.Windows.Forms.Label();
            this.priceLb = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.CancelBt = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LightGreen;
            this.panelInfo.Controls.Add(this.TextLabel);
            this.panelInfo.Controls.Add(this.titleLabel);
            this.panelInfo.Controls.Add(this.pictureNail);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(484, 105);
            this.panelInfo.TabIndex = 0;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(113, 50);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(357, 25);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Добавьте товар в реестр склада гвоздей";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(112, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(241, 35);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Добавление товара";
            // 
            // pictureNail
            // 
            this.pictureNail.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.nailPng;
            this.pictureNail.Location = new System.Drawing.Point(12, 12);
            this.pictureNail.Name = "pictureNail";
            this.pictureNail.Size = new System.Drawing.Size(80, 80);
            this.pictureNail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNail.TabIndex = 0;
            this.pictureNail.TabStop = false;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Location = new System.Drawing.Point(19, 131);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(96, 25);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "Название:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(191, 128);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(273, 33);
            this.nameTb.TabIndex = 2;
            // 
            // lengthNUD
            // 
            this.lengthNUD.DecimalPlaces = 1;
            this.lengthNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.lengthNUD.Location = new System.Drawing.Point(191, 167);
            this.lengthNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lengthNUD.Name = "lengthNUD";
            this.lengthNUD.Size = new System.Drawing.Size(273, 33);
            this.lengthNUD.TabIndex = 3;
            this.lengthNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // materialCB
            // 
            this.materialCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.materialCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialCB.FormattingEnabled = true;
            this.materialCB.Location = new System.Drawing.Point(191, 206);
            this.materialCB.Name = "materialCB";
            this.materialCB.Size = new System.Drawing.Size(273, 34);
            this.materialCB.TabIndex = 4;
            this.materialCB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.materialCB_DrawItem);
            // 
            // minCountNUD
            // 
            this.minCountNUD.Location = new System.Drawing.Point(191, 286);
            this.minCountNUD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.minCountNUD.Name = "minCountNUD";
            this.minCountNUD.Size = new System.Drawing.Size(273, 33);
            this.minCountNUD.TabIndex = 6;
            // 
            // priceNUD
            // 
            this.priceNUD.DecimalPlaces = 2;
            this.priceNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNUD.Location = new System.Drawing.Point(191, 325);
            this.priceNUD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(273, 33);
            this.priceNUD.TabIndex = 7;
            // 
            // countNUD
            // 
            this.countNUD.Location = new System.Drawing.Point(191, 247);
            this.countNUD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.countNUD.Name = "countNUD";
            this.countNUD.Size = new System.Drawing.Size(273, 33);
            this.countNUD.TabIndex = 8;
            // 
            // LengthLb
            // 
            this.LengthLb.AutoSize = true;
            this.LengthLb.Location = new System.Drawing.Point(19, 169);
            this.LengthLb.Name = "LengthLb";
            this.LengthLb.Size = new System.Drawing.Size(100, 25);
            this.LengthLb.TabIndex = 9;
            this.LengthLb.Text = "Длина, мм:";
            // 
            // MaterialLb
            // 
            this.MaterialLb.AutoSize = true;
            this.MaterialLb.Location = new System.Drawing.Point(19, 209);
            this.MaterialLb.Name = "MaterialLb";
            this.MaterialLb.Size = new System.Drawing.Size(97, 25);
            this.MaterialLb.TabIndex = 10;
            this.MaterialLb.Text = "Материал:";
            // 
            // CountLb
            // 
            this.CountLb.AutoSize = true;
            this.CountLb.Location = new System.Drawing.Point(19, 249);
            this.CountLb.Name = "CountLb";
            this.CountLb.Size = new System.Drawing.Size(164, 25);
            this.CountLb.TabIndex = 11;
            this.CountLb.Text = "Кол-во на складе:";
            // 
            // minCountLb
            // 
            this.minCountLb.AutoSize = true;
            this.minCountLb.Location = new System.Drawing.Point(19, 288);
            this.minCountLb.Name = "minCountLb";
            this.minCountLb.Size = new System.Drawing.Size(118, 25);
            this.minCountLb.TabIndex = 12;
            this.minCountLb.Text = "Мин. Кол-во:";
            // 
            // priceLb
            // 
            this.priceLb.AutoSize = true;
            this.priceLb.Location = new System.Drawing.Point(19, 327);
            this.priceLb.Name = "priceLb";
            this.priceLb.Size = new System.Drawing.Size(169, 25);
            this.priceLb.TabIndex = 13;
            this.priceLb.Text = "Цена без НДС, руб:";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.LightGreen;
            this.panelBottom.Controls.Add(this.CancelBt);
            this.panelBottom.Controls.Add(this.OkButton);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 395);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(484, 66);
            this.panelBottom.TabIndex = 3;
            // 
            // CancelBt
            // 
            this.CancelBt.BackColor = System.Drawing.Color.MintCream;
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Location = new System.Drawing.Point(366, 14);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(104, 40);
            this.CancelBt.TabIndex = 1;
            this.CancelBt.Text = "Отмена";
            this.CancelBt.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.MintCream;
            this.OkButton.Location = new System.Drawing.Point(255, 14);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(105, 40);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.priceLb);
            this.Controls.Add(this.minCountLb);
            this.Controls.Add(this.CountLb);
            this.Controls.Add(this.MaterialLb);
            this.Controls.Add(this.LengthLb);
            this.Controls.Add(this.countNUD);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.minCountNUD);
            this.Controls.Add(this.materialCB);
            this.Controls.Add(this.lengthNUD);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавить товар в реестр";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureNail;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.NumericUpDown lengthNUD;
        private System.Windows.Forms.ComboBox materialCB;
        private System.Windows.Forms.NumericUpDown minCountNUD;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown countNUD;
        private System.Windows.Forms.Label LengthLb;
        private System.Windows.Forms.Label MaterialLb;
        private System.Windows.Forms.Label CountLb;
        private System.Windows.Forms.Label minCountLb;
        private System.Windows.Forms.Label priceLb;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button OkButton;
    }
}
