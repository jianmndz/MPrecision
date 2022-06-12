namespace MPrecision
{
    partial class ManageCashBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ExpensesGV = new System.Windows.Forms.DataGridView();
            this.InventoryGV = new System.Windows.Forms.DataGridView();
            this.SearchExpensesTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CashInTotalTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CashOutTotalTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CashBalanceTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CashOnHandTb = new System.Windows.Forms.TextBox();
            this.SearchInventoryTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "CASH BALANCE";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1668, 26);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 38);
            this.button4.TabIndex = 44;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ExpensesGV
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.ExpensesGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.ExpensesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpensesGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ExpensesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.ExpensesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.ExpensesGV.GridColor = System.Drawing.SystemColors.Control;
            this.ExpensesGV.Location = new System.Drawing.Point(360, 128);
            this.ExpensesGV.Margin = new System.Windows.Forms.Padding(2);
            this.ExpensesGV.Name = "ExpensesGV";
            this.ExpensesGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpensesGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.ExpensesGV.RowHeadersWidth = 50;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExpensesGV.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ExpensesGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ExpensesGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.ExpensesGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExpensesGV.RowTemplate.Height = 50;
            this.ExpensesGV.RowTemplate.ReadOnly = true;
            this.ExpensesGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpensesGV.Size = new System.Drawing.Size(527, 644);
            this.ExpensesGV.TabIndex = 65;
            // 
            // InventoryGV
            // 
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.InventoryGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.InventoryGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.InventoryGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.InventoryGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGV.DefaultCellStyle = dataGridViewCellStyle28;
            this.InventoryGV.GridColor = System.Drawing.SystemColors.Control;
            this.InventoryGV.Location = new System.Drawing.Point(907, 128);
            this.InventoryGV.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryGV.Name = "InventoryGV";
            this.InventoryGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InventoryGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.InventoryGV.RowHeadersWidth = 50;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InventoryGV.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.InventoryGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.InventoryGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.InventoryGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InventoryGV.RowTemplate.Height = 50;
            this.InventoryGV.RowTemplate.ReadOnly = true;
            this.InventoryGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGV.Size = new System.Drawing.Size(843, 644);
            this.InventoryGV.TabIndex = 70;
            // 
            // SearchExpensesTb
            // 
            this.SearchExpensesTb.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.SearchExpensesTb.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchExpensesTb.Location = new System.Drawing.Point(547, 26);
            this.SearchExpensesTb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchExpensesTb.Name = "SearchExpensesTb";
            this.SearchExpensesTb.Size = new System.Drawing.Size(340, 38);
            this.SearchExpensesTb.TabIndex = 71;
            this.SearchExpensesTb.Text = "Filter Expenses by Date";
            this.SearchExpensesTb.TextChanged += new System.EventHandler(this.SearchExpensesTb_TextChanged);
            this.SearchExpensesTb.Enter += new System.EventHandler(this.SearchExpenses_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(12, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 75;
            this.label4.Text = "Cash In";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashInTotalTb
            // 
            this.CashInTotalTb.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInTotalTb.Location = new System.Drawing.Point(140, 409);
            this.CashInTotalTb.Margin = new System.Windows.Forms.Padding(2);
            this.CashInTotalTb.Name = "CashInTotalTb";
            this.CashInTotalTb.Size = new System.Drawing.Size(212, 29);
            this.CashInTotalTb.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Cash Out";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashOutTotalTb
            // 
            this.CashOutTotalTb.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashOutTotalTb.Location = new System.Drawing.Point(140, 307);
            this.CashOutTotalTb.Margin = new System.Windows.Forms.Padding(2);
            this.CashOutTotalTb.Name = "CashOutTotalTb";
            this.CashOutTotalTb.Size = new System.Drawing.Size(212, 29);
            this.CashOutTotalTb.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(12, 516);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 77;
            this.label3.Text = "Cash Balance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashBalanceTb
            // 
            this.CashBalanceTb.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBalanceTb.Location = new System.Drawing.Point(140, 515);
            this.CashBalanceTb.Margin = new System.Windows.Forms.Padding(2);
            this.CashBalanceTb.Name = "CashBalanceTb";
            this.CashBalanceTb.Size = new System.Drawing.Size(212, 29);
            this.CashBalanceTb.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(140, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 38);
            this.button1.TabIndex = 78;
            this.button1.Text = "Calculate Expenses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(140, 442);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 38);
            this.button2.TabIndex = 79;
            this.button2.Text = "Calculate Income";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(140, 548);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 38);
            this.button3.TabIndex = 80;
            this.button3.Text = "Calculate Balance";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "Cash On Hand";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CashOnHandTb
            // 
            this.CashOnHandTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashOnHandTb.Location = new System.Drawing.Point(140, 216);
            this.CashOnHandTb.Name = "CashOnHandTb";
            this.CashOnHandTb.Size = new System.Drawing.Size(212, 29);
            this.CashOnHandTb.TabIndex = 83;
            // 
            // SearchInventoryTb
            // 
            this.SearchInventoryTb.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.SearchInventoryTb.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchInventoryTb.Location = new System.Drawing.Point(1318, 26);
            this.SearchInventoryTb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchInventoryTb.Name = "SearchInventoryTb";
            this.SearchInventoryTb.Size = new System.Drawing.Size(340, 38);
            this.SearchInventoryTb.TabIndex = 84;
            this.SearchInventoryTb.Text = "Filter Inventory by Date";
            this.SearchInventoryTb.TextChanged += new System.EventHandler(this.SearchInventoryTb_TextChanged);
            this.SearchInventoryTb.Enter += new System.EventHandler(this.SearchInventory_Enter);
            // 
            // ManageCashBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.BackgroundImage = global::MPrecision.Properties.Resources.BANNER1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1765, 784);
            this.Controls.Add(this.SearchInventoryTb);
            this.Controls.Add(this.CashOnHandTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashBalanceTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CashInTotalTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashOutTotalTb);
            this.Controls.Add(this.SearchExpensesTb);
            this.Controls.Add(this.InventoryGV);
            this.Controls.Add(this.ExpensesGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "ManageCashBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Cash Balance";
            this.Load += new System.EventHandler(this.ManageCashBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView ExpensesGV;
        private System.Windows.Forms.DataGridView InventoryGV;
        private System.Windows.Forms.TextBox SearchExpensesTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CashInTotalTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CashOutTotalTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CashBalanceTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CashOnHandTb;
        private System.Windows.Forms.TextBox SearchInventoryTb;
    }
}