namespace task3_DataGrid_v1NailWarehouse.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныйТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбранныйТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddRemoveEdit = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.removeButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.statusAddInfo = new System.Windows.Forms.StatusStrip();
            this.lbCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSumWTax = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSumNoTax = new System.Windows.Forms.ToolStripStatusLabel();
            this.nailsDGV = new System.Windows.Forms.DataGridView();
            this.mainMenu.SuspendLayout();
            this.toolAddRemoveEdit.SuspendLayout();
            this.statusAddInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nailsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(806, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem,
            this.удалитьВыбранныйТоварToolStripMenuItem,
            this.редактироватьВыбранныйТоварToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.addButton_Click);
            // 
            // удалитьВыбранныйТоварToolStripMenuItem
            // 
            this.удалитьВыбранныйТоварToolStripMenuItem.Name = "удалитьВыбранныйТоварToolStripMenuItem";
            this.удалитьВыбранныйТоварToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.удалитьВыбранныйТоварToolStripMenuItem.Text = "Удалить выбранный товар";
            this.удалитьВыбранныйТоварToolStripMenuItem.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // редактироватьВыбранныйТоварToolStripMenuItem
            // 
            this.редактироватьВыбранныйТоварToolStripMenuItem.Name = "редактироватьВыбранныйТоварToolStripMenuItem";
            this.редактироватьВыбранныйТоварToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.редактироватьВыбранныйТоварToolStripMenuItem.Text = "Редактировать выбранный товар";
            this.редактироватьВыбранныйТоварToolStripMenuItem.Click += new System.EventHandler(this.editButton_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // toolAddRemoveEdit
            // 
            this.toolAddRemoveEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.removeButton,
            this.editButton});
            this.toolAddRemoveEdit.Location = new System.Drawing.Point(0, 28);
            this.toolAddRemoveEdit.Name = "toolAddRemoveEdit";
            this.toolAddRemoveEdit.Size = new System.Drawing.Size(806, 25);
            this.toolAddRemoveEdit.TabIndex = 1;
            this.toolAddRemoveEdit.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.addIco;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 22);
            this.addButton.Text = "Добавить товар";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeButton.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.removeIco;
            this.removeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(23, 22);
            this.removeButton.Text = "Удалить выбранный товар";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.editIco;
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(23, 22);
            this.editButton.Text = "Редактировать выбранный товар";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // statusAddInfo
            // 
            this.statusAddInfo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAddInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCount,
            this.lbSumWTax,
            this.lbSumNoTax});
            this.statusAddInfo.Location = new System.Drawing.Point(0, 515);
            this.statusAddInfo.Name = "statusAddInfo";
            this.statusAddInfo.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusAddInfo.Size = new System.Drawing.Size(806, 30);
            this.statusAddInfo.TabIndex = 2;
            this.statusAddInfo.Text = "statusStrip1";
            // 
            // lbCount
            // 
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(87, 25);
            this.lbCount.Text = "Позиций:";
            // 
            // lbSumWTax
            // 
            this.lbSumWTax.Name = "lbSumWTax";
            this.lbSumWTax.Size = new System.Drawing.Size(184, 25);
            this.lbSumWTax.Text = "Общ. сумма без НДС:";
            // 
            // lbSumNoTax
            // 
            this.lbSumNoTax.Name = "lbSumNoTax";
            this.lbSumNoTax.Size = new System.Drawing.Size(165, 25);
            this.lbSumNoTax.Text = "Общ. сумма с НДС:";
            // 
            // nailsDGV
            // 
            this.nailsDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.nailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nailsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nailsDGV.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.nailsDGV.Location = new System.Drawing.Point(0, 53);
            this.nailsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.nailsDGV.Name = "nailsDGV";
            this.nailsDGV.ReadOnly = true;
            this.nailsDGV.Size = new System.Drawing.Size(806, 462);
            this.nailsDGV.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 545);
            this.Controls.Add(this.nailsDGV);
            this.Controls.Add(this.statusAddInfo);
            this.Controls.Add(this.toolAddRemoveEdit);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Склад Гвоздей";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolAddRemoveEdit.ResumeLayout(false);
            this.toolAddRemoveEdit.PerformLayout();
            this.statusAddInfo.ResumeLayout(false);
            this.statusAddInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nailsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolAddRemoveEdit;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton removeButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.StatusStrip statusAddInfo;
        private System.Windows.Forms.DataGridView nailsDGV;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбранныйТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbCount;
        private System.Windows.Forms.ToolStripStatusLabel lbSumWTax;
        private System.Windows.Forms.ToolStripStatusLabel lbSumNoTax;
    }
}
