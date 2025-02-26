﻿namespace ProjectMB
{
    partial class ProductsForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.productsLw = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockRColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeBtn = new System.Windows.Forms.Button();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.leftLbl = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.bottomLbl = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 407);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(121, 45);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(816, 407);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 45);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productsLw
            // 
            this.productsLw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsLw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn,
            this.categoryColumn,
            this.priceColumn,
            this.quantityColumn,
            this.stockRColumn});
            this.productsLw.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsLw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLw.FullRowSelect = true;
            this.productsLw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productsLw.HideSelection = false;
            this.productsLw.Location = new System.Drawing.Point(0, 0);
            this.productsLw.Name = "productsLw";
            this.productsLw.Size = new System.Drawing.Size(949, 350);
            this.productsLw.TabIndex = 3;
            this.productsLw.UseCompatibleStateImageBehavior = false;
            this.productsLw.View = System.Windows.Forms.View.Details;
            this.productsLw.SelectedIndexChanged += new System.EventHandler(this.productsLw_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "id";
            this.idColumn.Width = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 360;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 236;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Price";
            this.priceColumn.Width = 135;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 87;
            // 
            // stockRColumn
            // 
            this.stockRColumn.Text = "Stock Request";
            this.stockRColumn.Width = 151;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(816, 356);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(121, 45);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // categoryCb
            // 
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Items.AddRange(new object[] {
            "Category",
            "IMAGE_SOUND",
            "COMPUTER",
            "PHOTO_VIDEO",
            "TELEPHONY_NAVIGATION",
            "HOUSEHOLD",
            "KITCHEN",
            "SPORT_CARE",
            "GAMING_FILM_MUSIC",
            "SMART_HOME"});
            this.categoryCb.Location = new System.Drawing.Point(392, 373);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(206, 28);
            this.categoryCb.TabIndex = 5;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.Location = new System.Drawing.Point(437, 407);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(121, 45);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // leftLbl
            // 
            this.leftLbl.BackColor = System.Drawing.Color.Black;
            this.leftLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLbl.Location = new System.Drawing.Point(0, 350);
            this.leftLbl.Name = "leftLbl";
            this.leftLbl.Size = new System.Drawing.Size(1, 120);
            this.leftLbl.TabIndex = 7;
            // 
            // rightLbl
            // 
            this.rightLbl.BackColor = System.Drawing.Color.Black;
            this.rightLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightLbl.Location = new System.Drawing.Point(948, 350);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(1, 120);
            this.rightLbl.TabIndex = 8;
            // 
            // bottomLbl
            // 
            this.bottomLbl.BackColor = System.Drawing.Color.Black;
            this.bottomLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLbl.Location = new System.Drawing.Point(1, 469);
            this.bottomLbl.Name = "bottomLbl";
            this.bottomLbl.Size = new System.Drawing.Size(947, 1);
            this.bottomLbl.TabIndex = 9;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(179)))), ((int)(((byte)(245)))));
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Location = new System.Drawing.Point(12, 356);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(121, 45);
            this.exportBtn.TabIndex = 10;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // ProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(949, 470);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.bottomLbl);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.leftLbl);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.productsLw);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView productsLw;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader stockRColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label leftLbl;
        private System.Windows.Forms.Label rightLbl;
        private System.Windows.Forms.Label bottomLbl;
        private System.Windows.Forms.Button exportBtn;
    }
}