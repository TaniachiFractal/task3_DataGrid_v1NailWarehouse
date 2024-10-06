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
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAddRemoveEdit = new System.Windows.Forms.ToolStrip();
            this.addBt = new System.Windows.Forms.ToolStripButton();
            this.removeBt = new System.Windows.Forms.ToolStripButton();
            this.editBt = new System.Windows.Forms.ToolStripButton();
            this.statusAddInfo = new System.Windows.Forms.StatusStrip();
            this.nailsDGV = new System.Windows.Forms.DataGridView();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГвоздьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбранныйТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныйТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolAddRemoveEdit.SuspendLayout();
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
            this.mainMenu.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mainMenu.Size = new System.Drawing.Size(520, 30);
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
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьГвоздьToolStripMenuItem,
            this.редактироватьВыбранныйТоварToolStripMenuItem,
            this.удалитьВыбранныйТоварToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.правкаToolStripMenuItem.Text = "Правка";
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
            this.addBt,
            this.removeBt,
            this.editBt});
            this.toolAddRemoveEdit.Location = new System.Drawing.Point(0, 30);
            this.toolAddRemoveEdit.Name = "toolAddRemoveEdit";
            this.toolAddRemoveEdit.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolAddRemoveEdit.Size = new System.Drawing.Size(520, 25);
            this.toolAddRemoveEdit.TabIndex = 1;
            this.toolAddRemoveEdit.Text = "toolStrip1";
            // 
            // addBt
            // 
            this.addBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBt.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources._;
            this.addBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(23, 22);
            this.addBt.Text = "toolStripButton1";
            // 
            // removeBt
            // 
            this.removeBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeBt.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.x;
            this.removeBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(23, 22);
            this.removeBt.Text = "toolStripButton2";
            // 
            // editBt
            // 
            this.editBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editBt.Image = global::task3_DataGrid_v1NailWarehouse.Properties.Resources.edit;
            this.editBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(23, 22);
            this.editBt.Text = "toolStripButton3";
            // 
            // statusAddInfo
            // 
            this.statusAddInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusAddInfo.Location = new System.Drawing.Point(0, 409);
            this.statusAddInfo.Name = "statusAddInfo";
            this.statusAddInfo.Size = new System.Drawing.Size(520, 22);
            this.statusAddInfo.TabIndex = 2;
            this.statusAddInfo.Text = "statusStrip1";
            // 
            // nailsDGV
            // 
            this.nailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nailsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nailsDGV.Location = new System.Drawing.Point(0, 55);
            this.nailsDGV.Name = "nailsDGV";
            this.nailsDGV.Size = new System.Drawing.Size(520, 354);
            this.nailsDGV.TabIndex = 3;
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // добавитьГвоздьToolStripMenuItem
            // 
            this.добавитьГвоздьToolStripMenuItem.Name = "добавитьГвоздьToolStripMenuItem";
            this.добавитьГвоздьToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.добавитьГвоздьToolStripMenuItem.Text = "Добавить гвоздь";
            // 
            // редактироватьВыбранныйТоварToolStripMenuItem
            // 
            this.редактироватьВыбранныйТоварToolStripMenuItem.Name = "редактироватьВыбранныйТоварToolStripMenuItem";
            this.редактироватьВыбранныйТоварToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.редактироватьВыбранныйТоварToolStripMenuItem.Text = "Редактировать выбранный товар";
            // 
            // удалитьВыбранныйТоварToolStripMenuItem
            // 
            this.удалитьВыбранныйТоварToolStripMenuItem.Name = "удалитьВыбранныйТоварToolStripMenuItem";
            this.удалитьВыбранныйТоварToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.удалитьВыбранныйТоварToolStripMenuItem.Text = "Удалить выбранный товар";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 431);
            this.Controls.Add(this.nailsDGV);
            this.Controls.Add(this.statusAddInfo);
            this.Controls.Add(this.toolAddRemoveEdit);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Склад Гвоздей";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolAddRemoveEdit.ResumeLayout(false);
            this.toolAddRemoveEdit.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton addBt;
        private System.Windows.Forms.ToolStripButton removeBt;
        private System.Windows.Forms.ToolStripButton editBt;
        private System.Windows.Forms.StatusStrip statusAddInfo;
        private System.Windows.Forms.DataGridView nailsDGV;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьГвоздьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбранныйТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйТоварToolStripMenuItem;
    }
}
