﻿namespace UpdateProduct
{
    partial class FRMMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TXTSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGetUserPass = new System.Windows.Forms.Button();
            this.TXTPass = new System.Windows.Forms.TextBox();
            this.TXTUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.backGUpdateGoods = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pBarDo = new System.Windows.Forms.ProgressBar();
            this.MYdataGrid = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerDot = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MYdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1042, 150);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(106, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "نمايش كالاهاي بدون عمليات ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TXTSearch);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(276, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 120);
            this.panel4.TabIndex = 1;
            // 
            // TXTSearch
            // 
            this.TXTSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTSearch.Location = new System.Drawing.Point(16, 55);
            this.TXTSearch.Name = "TXTSearch";
            this.TXTSearch.Size = new System.Drawing.Size(410, 27);
            this.TXTSearch.TabIndex = 1;
            this.TXTSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TXTSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "گروه كالا :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "نام كالا :";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(17, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "نمايش";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGetUserPass);
            this.panel3.Controls.Add(this.TXTPass);
            this.panel3.Controls.Add(this.TXTUserName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(807, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 120);
            this.panel3.TabIndex = 0;
            // 
            // btnGetUserPass
            // 
            this.btnGetUserPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetUserPass.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnGetUserPass.Location = new System.Drawing.Point(45, 85);
            this.btnGetUserPass.Name = "btnGetUserPass";
            this.btnGetUserPass.Size = new System.Drawing.Size(72, 32);
            this.btnGetUserPass.TabIndex = 2;
            this.btnGetUserPass.Text = "ورود";
            this.btnGetUserPass.UseVisualStyleBackColor = true;
            this.btnGetUserPass.Click += new System.EventHandler(this.btnGetUserPass_Click);
            this.btnGetUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // TXTPass
            // 
            this.TXTPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTPass.Location = new System.Drawing.Point(3, 47);
            this.TXTPass.Name = "TXTPass";
            this.TXTPass.Size = new System.Drawing.Size(150, 27);
            this.TXTPass.TabIndex = 1;
            this.TXTPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // TXTUserName
            // 
            this.TXTUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTUserName.Location = new System.Drawing.Point(3, 9);
            this.TXTUserName.Name = "TXTUserName";
            this.TXTUserName.Size = new System.Drawing.Size(150, 27);
            this.TXTUserName.TabIndex = 0;
            this.TXTUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام كاربر :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمه عبور :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Location = new System.Drawing.Point(107, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 51);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(5, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDone.Location = new System.Drawing.Point(83, 7);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(72, 32);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "ثبت";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            this.btnDone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDone_KeyDown);
            // 
            // backGUpdateGoods
            // 
            this.backGUpdateGoods.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backGUpdateGoods_DoWork);
            this.backGUpdateGoods.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backGUpdateGoods_ProgressChanged);
            this.backGUpdateGoods.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backGUpdateGoods_RunWorkerCompleted);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pBarDo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 585);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 33);
            this.panel5.TabIndex = 1;
            // 
            // pBarDo
            // 
            this.pBarDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBarDo.Location = new System.Drawing.Point(0, 0);
            this.pBarDo.Name = "pBarDo";
            this.pBarDo.Size = new System.Drawing.Size(1042, 33);
            this.pBarDo.TabIndex = 0;
            // 
            // MYdataGrid
            // 
            this.MYdataGrid.AllowUserToAddRows = false;
            this.MYdataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MYdataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MYdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MYdataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MYdataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.MYdataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MYdataGrid.Location = new System.Drawing.Point(0, 150);
            this.MYdataGrid.Name = "MYdataGrid";
            this.MYdataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MYdataGrid.Size = new System.Drawing.Size(1042, 435);
            this.MYdataGrid.TabIndex = 2;
            this.MYdataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MYdataGrid_CellEndEdit);
            this.MYdataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MYdataGrid_CellEnter);
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "shka";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 11.25F);
            this.Col1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col1.HeaderText = "رديف";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 50;
            // 
            // Col2
            // 
            this.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col2.DataPropertyName = "naka";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Col2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col2.HeaderText = "نام كالا";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.DataPropertyName = "vahsanj";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 11.25F);
            this.Col3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col3.HeaderText = "واحد";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 60;
            // 
            // Col4
            // 
            this.Col4.DataPropertyName = "mohvah";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Yekan", 11.25F);
            this.Col4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col4.HeaderText = "جزء در واحد";
            this.Col4.Name = "Col4";
            this.Col4.Width = 50;
            // 
            // Col5
            // 
            this.Col5.DataPropertyName = "mojkavah";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Yekan", 11.25F);
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Col5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col5.HeaderText = "موجودي واحد";
            this.Col5.Name = "Col5";
            this.Col5.Width = 70;
            // 
            // Col6
            // 
            this.Col6.DataPropertyName = "mojkajoz";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Yekan", 11.25F);
            this.Col6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col6.HeaderText = "موجودي جزء";
            this.Col6.Name = "Col6";
            this.Col6.Width = 60;
            // 
            // Col7
            // 
            this.Col7.DataPropertyName = "buyjoz";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Yekan", 11.25F);
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.Col7.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col7.HeaderText = "قيمت خريد";
            this.Col7.Name = "Col7";
            this.Col7.Width = 130;
            // 
            // Col8
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.Format = "N0";
            this.Col8.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col8.HeaderText = "موجودي ريالي انبار";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            this.Col8.Width = 250;
            // 
            // timerDot
            // 
            this.timerDot.Interval = 1;
            this.timerDot.Tick += new System.EventHandler(this.timerDot_Tick);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 618);
            this.Controls.Add(this.MYdataGrid);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آپديت كردن كالا";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MYdataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTPass;
        private System.Windows.Forms.TextBox TXTUserName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGetUserPass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TXTSearch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backGUpdateGoods;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView MYdataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.ProgressBar pBarDo;
        private System.Windows.Forms.Timer timerDot;
    }
}

