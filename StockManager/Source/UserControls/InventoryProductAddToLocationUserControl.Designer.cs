﻿namespace StockManager.Source.UserControls {
  partial class InventoryProductAddToLocationUserControl {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
      this.cbLocations = new System.Windows.Forms.ComboBox();
      this.pnlForm = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lbFormTitle = new System.Windows.Forms.Label();
      this.btnAddLocation = new System.Windows.Forms.Button();
      this.lbErrorMinStock = new System.Windows.Forms.Label();
      this.lbErrorQty = new System.Windows.Forms.Label();
      this.lbErrorLocation = new System.Windows.Forms.Label();
      this.lbMinStock = new System.Windows.Forms.Label();
      this.numMinStock = new System.Windows.Forms.NumericUpDown();
      this.lbQty = new System.Windows.Forms.Label();
      this.numQty = new System.Windows.Forms.NumericUpDown();
      this.lbLocation = new System.Windows.Forms.Label();
      this.dgvProductLocations = new System.Windows.Forms.DataGridView();
      this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnback = new System.Windows.Forms.Button();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.dgvProductStockMovements = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnStockAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbProductStockMovements = new System.Windows.Forms.Label();
      this.pnlForm.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).BeginInit();
      this.SuspendLayout();
      // 
      // cbLocations
      // 
      this.cbLocations.FormattingEnabled = true;
      this.cbLocations.Location = new System.Drawing.Point(53, 48);
      this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
      this.cbLocations.Name = "cbLocations";
      this.cbLocations.Size = new System.Drawing.Size(167, 24);
      this.cbLocations.TabIndex = 0;
      // 
      // pnlForm
      // 
      this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pnlForm.BackColor = System.Drawing.Color.Transparent;
      this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlForm.Controls.Add(this.panel1);
      this.pnlForm.Controls.Add(this.btnAddLocation);
      this.pnlForm.Controls.Add(this.lbErrorMinStock);
      this.pnlForm.Controls.Add(this.lbErrorQty);
      this.pnlForm.Controls.Add(this.lbErrorLocation);
      this.pnlForm.Controls.Add(this.lbMinStock);
      this.pnlForm.Controls.Add(this.numMinStock);
      this.pnlForm.Controls.Add(this.lbQty);
      this.pnlForm.Controls.Add(this.numQty);
      this.pnlForm.Controls.Add(this.cbLocations);
      this.pnlForm.Controls.Add(this.lbLocation);
      this.pnlForm.ForeColor = System.Drawing.Color.Transparent;
      this.pnlForm.Location = new System.Drawing.Point(4, 4);
      this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
      this.pnlForm.Name = "pnlForm";
      this.pnlForm.Size = new System.Drawing.Size(280, 281);
      this.pnlForm.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.lbFormTitle);
      this.panel1.Location = new System.Drawing.Point(-1, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(280, 23);
      this.panel1.TabIndex = 22;
      // 
      // lbFormTitle
      // 
      this.lbFormTitle.AutoSize = true;
      this.lbFormTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbFormTitle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFormTitle.ForeColor = System.Drawing.Color.White;
      this.lbFormTitle.Location = new System.Drawing.Point(4, 3);
      this.lbFormTitle.Name = "lbFormTitle";
      this.lbFormTitle.Size = new System.Drawing.Size(96, 16);
      this.lbFormTitle.TabIndex = 1;
      this.lbFormTitle.Text = "lbFormTitle";
      // 
      // btnAddLocation
      // 
      this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddLocation.ForeColor = System.Drawing.Color.White;
      this.btnAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddLocation.Location = new System.Drawing.Point(87, 243);
      this.btnAddLocation.Name = "btnAddLocation";
      this.btnAddLocation.Size = new System.Drawing.Size(93, 27);
      this.btnAddLocation.TabIndex = 3;
      this.btnAddLocation.Text = "btnAddLocation";
      this.btnAddLocation.UseVisualStyleBackColor = false;
      // 
      // lbErrorMinStock
      // 
      this.lbErrorMinStock.AutoSize = true;
      this.lbErrorMinStock.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorMinStock.ForeColor = System.Drawing.Color.Red;
      this.lbErrorMinStock.Location = new System.Drawing.Point(56, 217);
      this.lbErrorMinStock.Name = "lbErrorMinStock";
      this.lbErrorMinStock.Size = new System.Drawing.Size(113, 16);
      this.lbErrorMinStock.TabIndex = 17;
      this.lbErrorMinStock.Text = "lbErrorMinStock";
      // 
      // lbErrorQty
      // 
      this.lbErrorQty.AutoSize = true;
      this.lbErrorQty.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorQty.ForeColor = System.Drawing.Color.Red;
      this.lbErrorQty.Location = new System.Drawing.Point(56, 144);
      this.lbErrorQty.Name = "lbErrorQty";
      this.lbErrorQty.Size = new System.Drawing.Size(78, 16);
      this.lbErrorQty.TabIndex = 16;
      this.lbErrorQty.Text = "lbErrorQty";
      // 
      // lbErrorLocation
      // 
      this.lbErrorLocation.AutoSize = true;
      this.lbErrorLocation.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorLocation.ForeColor = System.Drawing.Color.Red;
      this.lbErrorLocation.Location = new System.Drawing.Point(56, 76);
      this.lbErrorLocation.Name = "lbErrorLocation";
      this.lbErrorLocation.Size = new System.Drawing.Size(113, 16);
      this.lbErrorLocation.TabIndex = 15;
      this.lbErrorLocation.Text = "lbErrorLocation";
      // 
      // lbMinStock
      // 
      this.lbMinStock.AutoSize = true;
      this.lbMinStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbMinStock.Location = new System.Drawing.Point(55, 171);
      this.lbMinStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbMinStock.Name = "lbMinStock";
      this.lbMinStock.Size = new System.Drawing.Size(88, 16);
      this.lbMinStock.TabIndex = 5;
      this.lbMinStock.Text = "lbMinStock";
      // 
      // numMinStock
      // 
      this.numMinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numMinStock.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numMinStock.ForeColor = System.Drawing.Color.Black;
      this.numMinStock.Location = new System.Drawing.Point(53, 190);
      this.numMinStock.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this.numMinStock.Name = "numMinStock";
      this.numMinStock.Size = new System.Drawing.Size(167, 24);
      this.numMinStock.TabIndex = 2;
      this.numMinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numMinStock.ThousandsSeparator = true;
      // 
      // lbQty
      // 
      this.lbQty.AutoSize = true;
      this.lbQty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbQty.Location = new System.Drawing.Point(56, 99);
      this.lbQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbQty.Name = "lbQty";
      this.lbQty.Size = new System.Drawing.Size(48, 16);
      this.lbQty.TabIndex = 3;
      this.lbQty.Text = "lbQty";
      // 
      // numQty
      // 
      this.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numQty.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numQty.ForeColor = System.Drawing.Color.Black;
      this.numQty.Location = new System.Drawing.Point(53, 117);
      this.numQty.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numQty.Name = "numQty";
      this.numQty.Size = new System.Drawing.Size(167, 24);
      this.numQty.TabIndex = 1;
      this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numQty.ThousandsSeparator = true;
      this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lbLocation
      // 
      this.lbLocation.AutoSize = true;
      this.lbLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbLocation.Location = new System.Drawing.Point(56, 29);
      this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbLocation.Name = "lbLocation";
      this.lbLocation.Size = new System.Drawing.Size(88, 16);
      this.lbLocation.TabIndex = 2;
      this.lbLocation.Text = "lbLocation";
      // 
      // dgvProductLocations
      // 
      this.dgvProductLocations.AllowUserToAddRows = false;
      this.dgvProductLocations.AllowUserToDeleteRows = false;
      this.dgvProductLocations.AllowUserToOrderColumns = true;
      dataGridViewCellStyle41.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle41.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
      this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductLocations.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle42.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle42.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
      this.dgvProductLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock});
      dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle43.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductLocations.DefaultCellStyle = dataGridViewCellStyle43;
      this.dgvProductLocations.EnableHeadersVisualStyles = false;
      this.dgvProductLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductLocations.Location = new System.Drawing.Point(291, 4);
      this.dgvProductLocations.Name = "dgvProductLocations";
      this.dgvProductLocations.ReadOnly = true;
      dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle44.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
      this.dgvProductLocations.RowHeadersWidth = 25;
      dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle45.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle45;
      this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductLocations.Size = new System.Drawing.Size(558, 281);
      this.dgvProductLocations.TabIndex = 4;
      // 
      // columnProductLocationId
      // 
      this.columnProductLocationId.HeaderText = "columnProductLocationId";
      this.columnProductLocationId.Name = "columnProductLocationId";
      this.columnProductLocationId.ReadOnly = true;
      this.columnProductLocationId.Visible = false;
      // 
      // columnLocation
      // 
      this.columnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnLocation.HeaderText = "columnLocation";
      this.columnLocation.Name = "columnLocation";
      this.columnLocation.ReadOnly = true;
      this.columnLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // ColumnStock
      // 
      this.ColumnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnStock.HeaderText = "ColumnStock";
      this.ColumnStock.Name = "ColumnStock";
      this.ColumnStock.ReadOnly = true;
      // 
      // columnMinStock
      // 
      this.columnMinStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnMinStock.HeaderText = "columnMinStock";
      this.columnMinStock.Name = "columnMinStock";
      this.columnMinStock.ReadOnly = true;
      // 
      // btnback
      // 
      this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnback.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnback.ForeColor = System.Drawing.Color.White;
      this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnback.Location = new System.Drawing.Point(8, 12);
      this.btnback.Name = "btnback";
      this.btnback.Size = new System.Drawing.Size(93, 27);
      this.btnback.TabIndex = 6;
      this.btnback.Text = "btnback";
      this.btnback.UseVisualStyleBackColor = false;
      // 
      // pnlTop
      // 
      this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTop.Controls.Add(this.dgvProductLocations);
      this.pnlTop.Controls.Add(this.pnlForm);
      this.pnlTop.Location = new System.Drawing.Point(4, 44);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(849, 289);
      this.pnlTop.TabIndex = 20;
      // 
      // dgvProductStockMovements
      // 
      this.dgvProductStockMovements.AllowUserToAddRows = false;
      this.dgvProductStockMovements.AllowUserToDeleteRows = false;
      this.dgvProductStockMovements.AllowUserToOrderColumns = true;
      dataGridViewCellStyle46.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle46.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductStockMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
      this.dgvProductStockMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductStockMovements.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductStockMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle47.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle47.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
      this.dgvProductStockMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductStockMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.columnDate,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.columnStockAcc,
            this.columnUser});
      dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle48.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle48.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductStockMovements.DefaultCellStyle = dataGridViewCellStyle48;
      this.dgvProductStockMovements.EnableHeadersVisualStyles = false;
      this.dgvProductStockMovements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductStockMovements.Location = new System.Drawing.Point(8, 374);
      this.dgvProductStockMovements.Name = "dgvProductStockMovements";
      this.dgvProductStockMovements.ReadOnly = true;
      dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle49.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
      this.dgvProductStockMovements.RowHeadersWidth = 25;
      dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle50.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductStockMovements.RowsDefaultCellStyle = dataGridViewCellStyle50;
      this.dgvProductStockMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductStockMovements.Size = new System.Drawing.Size(845, 260);
      this.dgvProductStockMovements.TabIndex = 5;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "columnStockMovementId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Visible = false;
      // 
      // columnDate
      // 
      this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnDate.HeaderText = "columnDate";
      this.columnDate.Name = "columnDate";
      this.columnDate.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.HeaderText = "columnFrom";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn3.HeaderText = "columnTo";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn4.HeaderText = "columnQty";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // columnStockAcc
      // 
      this.columnStockAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnStockAcc.HeaderText = "columnStockAcc";
      this.columnStockAcc.Name = "columnStockAcc";
      this.columnStockAcc.ReadOnly = true;
      // 
      // columnUser
      // 
      this.columnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnUser.HeaderText = "columnUser";
      this.columnUser.Name = "columnUser";
      this.columnUser.ReadOnly = true;
      // 
      // lbProductStockMovements
      // 
      this.lbProductStockMovements.AutoSize = true;
      this.lbProductStockMovements.BackColor = System.Drawing.Color.Transparent;
      this.lbProductStockMovements.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProductStockMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbProductStockMovements.Location = new System.Drawing.Point(4, 349);
      this.lbProductStockMovements.Name = "lbProductStockMovements";
      this.lbProductStockMovements.Size = new System.Drawing.Size(263, 22);
      this.lbProductStockMovements.TabIndex = 21;
      this.lbProductStockMovements.Text = "lbProductStockMovements";
      // 
      // InventoryProductAddToLocationUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbProductStockMovements);
      this.Controls.Add(this.dgvProductStockMovements);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.btnback);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductAddToLocationUserControl";
      this.Size = new System.Drawing.Size(860, 643);
      this.pnlForm.ResumeLayout(false);
      this.pnlForm.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
      this.pnlTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lbMinStock;
        private System.Windows.Forms.NumericUpDown numMinStock;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbErrorMinStock;
        private System.Windows.Forms.Label lbErrorQty;
        private System.Windows.Forms.Label lbErrorLocation;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.DataGridView dgvProductStockMovements;
    private System.Windows.Forms.Label lbProductStockMovements;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockAcc;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUser;
  }
}
