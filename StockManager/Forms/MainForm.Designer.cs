﻿namespace StockManager.Forms
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
      this.leftPanel = new System.Windows.Forms.Panel();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnUsers = new System.Windows.Forms.Button();
      this.labelUsername = new System.Windows.Forms.Label();
      this.btnStocks = new System.Windows.Forms.Button();
      this.btnDashboard = new System.Windows.Forms.Button();
      this.sideMarker = new System.Windows.Forms.Panel();
      this.pbAvatar = new System.Windows.Forms.PictureBox();
      this.panelStocksSubMenu = new System.Windows.Forms.Panel();
      this.btnStockCategories = new System.Windows.Forms.Button();
      this.btnStockList = new System.Windows.Forms.Button();
      this.leftPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
      this.panelStocksSubMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // leftPanel
      // 
      this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.leftPanel.Controls.Add(this.panelStocksSubMenu);
      this.leftPanel.Controls.Add(this.pbAvatar);
      this.leftPanel.Controls.Add(this.btnExit);
      this.leftPanel.Controls.Add(this.labelUsername);
      this.leftPanel.Controls.Add(this.btnSettings);
      this.leftPanel.Controls.Add(this.btnUsers);
      this.leftPanel.Controls.Add(this.btnStocks);
      this.leftPanel.Controls.Add(this.btnDashboard);
      this.leftPanel.Controls.Add(this.sideMarker);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 0);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(203, 644);
      this.leftPanel.TabIndex = 2;
      // 
      // btnExit
      // 
      this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
      this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnExit.Location = new System.Drawing.Point(10, 602);
      this.btnExit.Name = "btnExit";
      this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnExit.Size = new System.Drawing.Size(190, 31);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = " Exit";
      this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnExit.UseVisualStyleBackColor = false;
      // 
      // btnSettings
      // 
      this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnSettings.FlatAppearance.BorderSize = 0;
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSettings.ForeColor = System.Drawing.Color.White;
      this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
      this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.Location = new System.Drawing.Point(10, 299);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnSettings.Size = new System.Drawing.Size(190, 31);
      this.btnSettings.TabIndex = 8;
      this.btnSettings.Text = " Settings";
      this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSettings.UseVisualStyleBackColor = false;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnUsers
      // 
      this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnUsers.FlatAppearance.BorderSize = 0;
      this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUsers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUsers.ForeColor = System.Drawing.Color.White;
      this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
      this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUsers.Location = new System.Drawing.Point(10, 262);
      this.btnUsers.Name = "btnUsers";
      this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnUsers.Size = new System.Drawing.Size(190, 31);
      this.btnUsers.TabIndex = 7;
      this.btnUsers.Text = " Users";
      this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnUsers.UseVisualStyleBackColor = false;
      this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
      // 
      // labelUsername
      // 
      this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelUsername.Location = new System.Drawing.Point(3, 75);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(197, 17);
      this.labelUsername.TabIndex = 5;
      this.labelUsername.Text = "Ricardo Teixeira";
      this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnStocks
      // 
      this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStocks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStocks.FlatAppearance.BorderSize = 0;
      this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStocks.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStocks.ForeColor = System.Drawing.Color.White;
      this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
      this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.Location = new System.Drawing.Point(10, 148);
      this.btnStocks.Name = "btnStocks";
      this.btnStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStocks.Size = new System.Drawing.Size(190, 31);
      this.btnStocks.TabIndex = 4;
      this.btnStocks.Text = " Stocks";
      this.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStocks.UseVisualStyleBackColor = false;
      this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
      // 
      // btnDashboard
      // 
      this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDashboard.FlatAppearance.BorderSize = 0;
      this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDashboard.ForeColor = System.Drawing.Color.White;
      this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
      this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.Location = new System.Drawing.Point(10, 111);
      this.btnDashboard.Name = "btnDashboard";
      this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnDashboard.Size = new System.Drawing.Size(190, 31);
      this.btnDashboard.TabIndex = 3;
      this.btnDashboard.Text = " Dashboard";
      this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDashboard.UseVisualStyleBackColor = false;
      this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
      // 
      // sideMarker
      // 
      this.sideMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.sideMarker.Location = new System.Drawing.Point(0, 110);
      this.sideMarker.Name = "sideMarker";
      this.sideMarker.Size = new System.Drawing.Size(6, 32);
      this.sideMarker.TabIndex = 3;
      // 
      // pbAvatar
      // 
      this.pbAvatar.ErrorImage = null;
      this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
      this.pbAvatar.Location = new System.Drawing.Point(76, 12);
      this.pbAvatar.Name = "pbAvatar";
      this.pbAvatar.Size = new System.Drawing.Size(50, 50);
      this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pbAvatar.TabIndex = 3;
      this.pbAvatar.TabStop = false;
      // 
      // panelStocksSubMenu
      // 
      this.panelStocksSubMenu.Controls.Add(this.btnStockList);
      this.panelStocksSubMenu.Controls.Add(this.btnStockCategories);
      this.panelStocksSubMenu.Location = new System.Drawing.Point(39, 185);
      this.panelStocksSubMenu.Name = "panelStocksSubMenu";
      this.panelStocksSubMenu.Size = new System.Drawing.Size(161, 71);
      this.panelStocksSubMenu.TabIndex = 0;
      // 
      // btnStockCategories
      // 
      this.btnStockCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStockCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStockCategories.FlatAppearance.BorderSize = 0;
      this.btnStockCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStockCategories.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStockCategories.ForeColor = System.Drawing.Color.White;
      this.btnStockCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockCategories.Location = new System.Drawing.Point(3, 3);
      this.btnStockCategories.Name = "btnStockCategories";
      this.btnStockCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStockCategories.Size = new System.Drawing.Size(155, 27);
      this.btnStockCategories.TabIndex = 10;
      this.btnStockCategories.Text = "Categories";
      this.btnStockCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStockCategories.UseVisualStyleBackColor = false;
      // 
      // btnStockList
      // 
      this.btnStockList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStockList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStockList.FlatAppearance.BorderSize = 0;
      this.btnStockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStockList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStockList.ForeColor = System.Drawing.Color.White;
      this.btnStockList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockList.Location = new System.Drawing.Point(3, 36);
      this.btnStockList.Name = "btnStockList";
      this.btnStockList.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStockList.Size = new System.Drawing.Size(155, 27);
      this.btnStockList.TabIndex = 11;
      this.btnStockList.Text = "List";
      this.btnStockList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStockList.UseVisualStyleBackColor = false;
      // 
      // MainForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ClientSize = new System.Drawing.Size(1242, 644);
      this.Controls.Add(this.leftPanel);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stock Manager";
      this.leftPanel.ResumeLayout(false);
      this.leftPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
      this.panelStocksSubMenu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel sideMarker;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel panelStocksSubMenu;
        private System.Windows.Forms.Button btnStockList;
        private System.Windows.Forms.Button btnStockCategories;
    }
}