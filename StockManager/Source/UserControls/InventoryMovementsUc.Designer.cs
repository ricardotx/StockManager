﻿namespace StockManager.Source.UserControls
{
    partial class InventoryMovementsUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pbSearchIcon;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMovementsUc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMovements = new System.Windows.Forms.DataGridView();
            this.columnStockMovementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStockAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnbSearchBox = new System.Windows.Forms.Panel();
            this.btnClearSearchValue = new System.Windows.Forms.Button();
            this.tbSeachText = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnStockMovement = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lbFilterDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpFilterByDate = new System.Windows.Forms.TableLayoutPanel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.pnFilters = new System.Windows.Forms.Panel();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.lbFilterUser = new System.Windows.Forms.Label();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.lbFilterLocation = new System.Windows.Forms.Label();
            pbSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
            this.pnbSearchBox.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.tlpFilterByDate.SuspendLayout();
            this.pnFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSearchIcon
            // 
            pbSearchIcon.BackColor = System.Drawing.Color.LightGray;
            pbSearchIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            pbSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchIcon.Image")));
            pbSearchIcon.Location = new System.Drawing.Point(5, 6);
            pbSearchIcon.Name = "pbSearchIcon";
            pbSearchIcon.Size = new System.Drawing.Size(24, 22);
            pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pbSearchIcon.TabIndex = 5;
            pbSearchIcon.TabStop = false;
            pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
            // 
            // dgvMovements
            // 
            this.dgvMovements.AllowUserToAddRows = false;
            this.dgvMovements.AllowUserToDeleteRows = false;
            this.dgvMovements.AllowUserToResizeColumns = false;
            this.dgvMovements.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovements.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnStockMovementId,
            this.columnDate,
            this.columnReference,
            this.columnProduct,
            this.columnMovement,
            this.columnQty,
            this.columnStockAcc,
            this.columnUser});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovements.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMovements.EnableHeadersVisualStyles = false;
            this.dgvMovements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvMovements.Location = new System.Drawing.Point(8, 169);
            this.dgvMovements.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovements.Name = "dgvMovements";
            this.dgvMovements.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMovements.RowHeadersVisible = false;
            this.dgvMovements.RowHeadersWidth = 25;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMovements.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMovements.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovements.Size = new System.Drawing.Size(845, 241);
            this.dgvMovements.TabIndex = 17;
            // 
            // columnStockMovementId
            // 
            this.columnStockMovementId.HeaderText = "columnStockMovementId";
            this.columnStockMovementId.Name = "columnStockMovementId";
            this.columnStockMovementId.ReadOnly = true;
            this.columnStockMovementId.Visible = false;
            // 
            // columnDate
            // 
            this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDate.HeaderText = "columnDate";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // columnReference
            // 
            this.columnReference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnReference.HeaderText = "columnReference";
            this.columnReference.Name = "columnReference";
            this.columnReference.ReadOnly = true;
            // 
            // columnProduct
            // 
            this.columnProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProduct.HeaderText = "columnProduct";
            this.columnProduct.Name = "columnProduct";
            this.columnProduct.ReadOnly = true;
            // 
            // columnMovement
            // 
            this.columnMovement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMovement.HeaderText = "columnMovement";
            this.columnMovement.Name = "columnMovement";
            this.columnMovement.ReadOnly = true;
            this.columnMovement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnQty
            // 
            this.columnQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnQty.HeaderText = "columnQty";
            this.columnQty.Name = "columnQty";
            this.columnQty.ReadOnly = true;
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
            // pnbSearchBox
            // 
            this.pnbSearchBox.Controls.Add(pbSearchIcon);
            this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
            this.pnbSearchBox.Controls.Add(this.tbSeachText);
            this.pnbSearchBox.Location = new System.Drawing.Point(3, 7);
            this.pnbSearchBox.Name = "pnbSearchBox";
            this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
            this.pnbSearchBox.TabIndex = 18;
            // 
            // btnClearSearchValue
            // 
            this.btnClearSearchValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearSearchValue.BackColor = System.Drawing.Color.White;
            this.btnClearSearchValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearchValue.ForeColor = System.Drawing.Color.White;
            this.btnClearSearchValue.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearchValue.Image")));
            this.btnClearSearchValue.Location = new System.Drawing.Point(285, 7);
            this.btnClearSearchValue.Name = "btnClearSearchValue";
            this.btnClearSearchValue.Size = new System.Drawing.Size(17, 20);
            this.btnClearSearchValue.TabIndex = 11;
            this.btnClearSearchValue.UseVisualStyleBackColor = false;
            this.btnClearSearchValue.Click += new System.EventHandler(this.btnClearSearchValue_Click);
            // 
            // tbSeachText
            // 
            this.tbSeachText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSeachText.BackColor = System.Drawing.Color.White;
            this.tbSeachText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSeachText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeachText.Location = new System.Drawing.Point(30, 6);
            this.tbSeachText.Name = "tbSeachText";
            this.tbSeachText.Size = new System.Drawing.Size(274, 22);
            this.tbSeachText.TabIndex = 4;
            this.tbSeachText.TextChanged += new System.EventHandler(this.tbSeachText_TextChanged);
            this.tbSeachText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeachText_KeyPress);
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Controls.Add(this.btnStockMovement);
            this.pnlActions.Location = new System.Drawing.Point(654, 6);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(203, 34);
            this.pnlActions.TabIndex = 23;
            // 
            // btnStockMovement
            // 
            this.btnStockMovement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.btnStockMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovement.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMovement.ForeColor = System.Drawing.Color.White;
            this.btnStockMovement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMovement.Location = new System.Drawing.Point(79, 4);
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Size = new System.Drawing.Size(121, 27);
            this.btnStockMovement.TabIndex = 7;
            this.btnStockMovement.Text = "btnStockMovement";
            this.btnStockMovement.UseVisualStyleBackColor = false;
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStart.Checked = false;
            this.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(3, 3);
            this.dtpStart.MaxDate = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(204, 22);
            this.dtpStart.TabIndex = 24;
            this.dtpStart.Value = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dtpStart.CloseUp += new System.EventHandler(this.dtpStart_CloseUp);
            // 
            // lbFilterDate
            // 
            this.lbFilterDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFilterDate.AutoSize = true;
            this.lbFilterDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbFilterDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFilterDate.Location = new System.Drawing.Point(2, 60);
            this.lbFilterDate.Name = "lbFilterDate";
            this.lbFilterDate.Size = new System.Drawing.Size(104, 16);
            this.lbFilterDate.TabIndex = 26;
            this.lbFilterDate.Text = "lbFilterDate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(213, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "-";
            // 
            // tlpFilterByDate
            // 
            this.tlpFilterByDate.ColumnCount = 3;
            this.tlpFilterByDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.41573F));
            this.tlpFilterByDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.820225F));
            this.tlpFilterByDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.98877F));
            this.tlpFilterByDate.Controls.Add(this.dtpEnd, 2, 0);
            this.tlpFilterByDate.Controls.Add(this.label1, 1, 0);
            this.tlpFilterByDate.Controls.Add(this.dtpStart, 0, 0);
            this.tlpFilterByDate.Location = new System.Drawing.Point(3, 80);
            this.tlpFilterByDate.Name = "tlpFilterByDate";
            this.tlpFilterByDate.RowCount = 1;
            this.tlpFilterByDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterByDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFilterByDate.Size = new System.Drawing.Size(445, 28);
            this.tlpFilterByDate.TabIndex = 28;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEnd.Checked = false;
            this.dtpEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(233, 3);
            this.dtpEnd.MaxDate = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 22);
            this.dtpEnd.TabIndex = 25;
            this.dtpEnd.Value = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            this.dtpEnd.CloseUp += new System.EventHandler(this.dtpEnd_CloseUp);
            // 
            // pnFilters
            // 
            this.pnFilters.Controls.Add(this.cbUsers);
            this.pnFilters.Controls.Add(this.lbFilterLocation);
            this.pnFilters.Controls.Add(this.lbFilterUser);
            this.pnFilters.Controls.Add(this.cbLocations);
            this.pnFilters.Controls.Add(this.lbFilterDate);
            this.pnFilters.Controls.Add(this.tlpFilterByDate);
            this.pnFilters.Location = new System.Drawing.Point(4, 46);
            this.pnFilters.Name = "pnFilters";
            this.pnFilters.Size = new System.Drawing.Size(850, 116);
            this.pnFilters.TabIndex = 30;
            // 
            // cbUsers
            // 
            this.cbUsers.BackColor = System.Drawing.Color.White;
            this.cbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.ForeColor = System.Drawing.Color.Black;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(237, 24);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(203, 24);
            this.cbUsers.TabIndex = 35;
            // 
            // lbFilterUser
            // 
            this.lbFilterUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFilterUser.AutoSize = true;
            this.lbFilterUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbFilterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFilterUser.Location = new System.Drawing.Point(234, 5);
            this.lbFilterUser.Name = "lbFilterUser";
            this.lbFilterUser.Size = new System.Drawing.Size(104, 16);
            this.lbFilterUser.TabIndex = 27;
            this.lbFilterUser.Text = "lbFilterUser";
            // 
            // cbLocations
            // 
            this.cbLocations.BackColor = System.Drawing.Color.White;
            this.cbLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.ForeColor = System.Drawing.Color.Black;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.IntegralHeight = false;
            this.cbLocations.Location = new System.Drawing.Point(4, 24);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(206, 24);
            this.cbLocations.TabIndex = 35;
            // 
            // lbFilterLocation
            // 
            this.lbFilterLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFilterLocation.AutoSize = true;
            this.lbFilterLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbFilterLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFilterLocation.Location = new System.Drawing.Point(1, 5);
            this.lbFilterLocation.Name = "lbFilterLocation";
            this.lbFilterLocation.Size = new System.Drawing.Size(136, 16);
            this.lbFilterLocation.TabIndex = 27;
            this.lbFilterLocation.Text = "lbFilterLocation";
            // 
            // InventoryMovementsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFilters);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnbSearchBox);
            this.Controls.Add(this.dgvMovements);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryMovementsUc";
            this.Size = new System.Drawing.Size(860, 420);
            ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
            this.pnbSearchBox.ResumeLayout(false);
            this.pnbSearchBox.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.tlpFilterByDate.ResumeLayout(false);
            this.tlpFilterByDate.PerformLayout();
            this.pnFilters.ResumeLayout(false);
            this.pnFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMovements;
    private System.Windows.Forms.Panel pnbSearchBox;
    private System.Windows.Forms.Button btnClearSearchValue;
    private System.Windows.Forms.TextBox tbSeachText;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStockMovementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStockAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUser;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lbFilterDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpFilterByDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Panel pnFilters;
        private System.Windows.Forms.Label lbFilterUser;
        private System.Windows.Forms.Label lbFilterLocation;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.ComboBox cbLocations;
    }
}
