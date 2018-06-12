namespace InstallmentProject
{
    partial class Form1
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
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.msmPanel1 = new MSMControls.MSMPanel();
            this.msmPanel3 = new MSMControls.MSMPanel();
            this.msmPanel4 = new MSMControls.MSMPanel();
            this.msmPanel2 = new MSMControls.MSMPanel();
            this.msmButton1 = new MSMControls.MSMButton();
            this.lblName = new MSMControls.MSMLabel();
            this.myTextBox1 = new MSMControls.MyTextBox();
            this.msmLabel1 = new MSMControls.MSMLabel();
            this.myTextBox2 = new MSMControls.MyTextBox();
            this.msmLabel2 = new MSMControls.MSMLabel();
            this.myTextBox3 = new MSMControls.MyTextBox();
            this.msmPanel1.SuspendLayout();
            this.msmPanel3.SuspendLayout();
            this.msmPanel4.SuspendLayout();
            this.msmPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = null;
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.Name = "ribbonComboBox1";
            this.ribbonComboBox1.TextBoxText = "";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = null;
            // 
            // msmPanel1
            // 
            this.msmPanel1.Controls.Add(this.msmPanel3);
            this.msmPanel1.Controls.Add(this.msmPanel2);
            this.msmPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msmPanel1.Location = new System.Drawing.Point(0, 0);
            this.msmPanel1.Name = "msmPanel1";
            this.msmPanel1.Size = new System.Drawing.Size(913, 588);
            this.msmPanel1.TabIndex = 1;
            // 
            // msmPanel3
            // 
            this.msmPanel3.Controls.Add(this.msmPanel4);
            this.msmPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msmPanel3.Location = new System.Drawing.Point(0, 0);
            this.msmPanel3.Name = "msmPanel3";
            this.msmPanel3.Size = new System.Drawing.Size(913, 512);
            this.msmPanel3.TabIndex = 3;
            // 
            // msmPanel4
            // 
            this.msmPanel4.Controls.Add(this.myTextBox3);
            this.msmPanel4.Controls.Add(this.msmLabel2);
            this.msmPanel4.Controls.Add(this.myTextBox2);
            this.msmPanel4.Controls.Add(this.msmLabel1);
            this.msmPanel4.Controls.Add(this.myTextBox1);
            this.msmPanel4.Controls.Add(this.lblName);
            this.msmPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.msmPanel4.Location = new System.Drawing.Point(0, 0);
            this.msmPanel4.Name = "msmPanel4";
            this.msmPanel4.Size = new System.Drawing.Size(913, 76);
            this.msmPanel4.TabIndex = 0;
            // 
            // msmPanel2
            // 
            this.msmPanel2.Controls.Add(this.msmButton1);
            this.msmPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msmPanel2.Location = new System.Drawing.Point(0, 512);
            this.msmPanel2.Name = "msmPanel2";
            this.msmPanel2.Size = new System.Drawing.Size(913, 76);
            this.msmPanel2.TabIndex = 2;
            // 
            // msmButton1
            // 
            this.msmButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msmButton1.AutoSize = true;
            this.msmButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.msmButton1.ForeColor = System.Drawing.Color.White;
            this.msmButton1.Location = new System.Drawing.Point(788, 32);
            this.msmButton1.Name = "msmButton1";
            this.msmButton1.OnMouseHoverBackcolor = System.Drawing.Color.DarkOrchid;
            this.msmButton1.Size = new System.Drawing.Size(75, 23);
            this.msmButton1.TabIndex = 1;
            this.msmButton1.Text = "بستن";
            this.msmButton1.UseVisualStyleBackColor = false;
            this.msmButton1.Click += new System.EventHandler(this.msmButton1_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(785, 31);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(106, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام و نام خانوادگي :";
            // 
            // myTextBox1
            // 
            this.myTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox1.DisBeepEnter = false;
            this.myTextBox1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myTextBox1.ForeColor = System.Drawing.Color.Black;
            this.myTextBox1.Location = new System.Drawing.Point(574, 30);
            this.myTextBox1.Mouseclick = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.myTextBox1.MouseClickLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.OnlyDigit = false;
            this.myTextBox1.OnlyLetter = false;
            this.myTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myTextBox1.SendTab = true;
            this.myTextBox1.Size = new System.Drawing.Size(208, 26);
            this.myTextBox1.TabIndex = 1;
            // 
            // msmLabel1
            // 
            this.msmLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msmLabel1.AutoSize = true;
            this.msmLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msmLabel1.Location = new System.Drawing.Point(403, 31);
            this.msmLabel1.Name = "msmLabel1";
            this.msmLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msmLabel1.Size = new System.Drawing.Size(82, 18);
            this.msmLabel1.TabIndex = 2;
            this.msmLabel1.Text = "شماره فاكتور :";
            // 
            // myTextBox2
            // 
            this.myTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox2.DisBeepEnter = false;
            this.myTextBox2.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myTextBox2.ForeColor = System.Drawing.Color.Black;
            this.myTextBox2.Location = new System.Drawing.Point(314, 31);
            this.myTextBox2.Mouseclick = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.myTextBox2.MouseClickLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.OnlyDigit = false;
            this.myTextBox2.OnlyLetter = false;
            this.myTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myTextBox2.SendTab = true;
            this.myTextBox2.Size = new System.Drawing.Size(83, 26);
            this.myTextBox2.TabIndex = 3;
            // 
            // msmLabel2
            // 
            this.msmLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msmLabel2.AutoSize = true;
            this.msmLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.msmLabel2.Location = new System.Drawing.Point(148, 30);
            this.msmLabel2.Name = "msmLabel2";
            this.msmLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.msmLabel2.Size = new System.Drawing.Size(43, 18);
            this.msmLabel2.TabIndex = 4;
            this.msmLabel2.Text = "تاريخ :";
            // 
            // myTextBox3
            // 
            this.myTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox3.DisBeepEnter = false;
            this.myTextBox3.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.myTextBox3.ForeColor = System.Drawing.Color.Black;
            this.myTextBox3.Location = new System.Drawing.Point(29, 30);
            this.myTextBox3.Mouseclick = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.myTextBox3.MouseClickLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.OnlyDigit = false;
            this.myTextBox3.OnlyLetter = false;
            this.myTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myTextBox3.SendTab = true;
            this.myTextBox3.Size = new System.Drawing.Size(113, 26);
            this.myTextBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 588);
            this.Controls.Add(this.msmPanel1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.msmPanel1.ResumeLayout(false);
            this.msmPanel3.ResumeLayout(false);
            this.msmPanel4.ResumeLayout(false);
            this.msmPanel4.PerformLayout();
            this.msmPanel2.ResumeLayout(false);
            this.msmPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private MSMControls.MSMPanel msmPanel1;
        private MSMControls.MSMButton msmButton1;
        private MSMControls.MSMPanel msmPanel2;
        private MSMControls.MSMPanel msmPanel3;
        private MSMControls.MSMPanel msmPanel4;
        private MSMControls.MSMLabel lblName;
        private MSMControls.MSMLabel msmLabel2;
        private MSMControls.MyTextBox myTextBox2;
        private MSMControls.MSMLabel msmLabel1;
        private MSMControls.MyTextBox myTextBox1;
        private MSMControls.MyTextBox myTextBox3;
    }
}