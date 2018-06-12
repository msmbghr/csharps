namespace MSMControls
{
    partial class MyTXTDate
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
            this.TXTDay = new System.Windows.Forms.TextBox();
            this.TXTMonth = new System.Windows.Forms.TextBox();
            this.TXTYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTDay
            // 
            this.TXTDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXTDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTDay.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTDay.Location = new System.Drawing.Point(78, 5);
            this.TXTDay.Name = "TXTDay";
            this.TXTDay.Size = new System.Drawing.Size(21, 23);
            this.TXTDay.TabIndex = 0;
            this.TXTDay.Text = "        ";
            this.TXTDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTDay.TextChanged += new System.EventHandler(this.TXTDay_TextChanged);
            this.TXTDay.Enter += new System.EventHandler(this.TXTDay_Enter);
            this.TXTDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTDay_KeyDown);
            this.TXTDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTDay_KeyPress);
            this.TXTDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTDay_KeyUp);
            this.TXTDay.Leave += new System.EventHandler(this.TXTDay_Leave);
            // 
            // TXTMonth
            // 
            this.TXTMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXTMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTMonth.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTMonth.Location = new System.Drawing.Point(50, 5);
            this.TXTMonth.Name = "TXTMonth";
            this.TXTMonth.Size = new System.Drawing.Size(20, 23);
            this.TXTMonth.TabIndex = 1;
            this.TXTMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTMonth.TextChanged += new System.EventHandler(this.TXTMonth_TextChanged);
            this.TXTMonth.Enter += new System.EventHandler(this.TXTMonth_Enter);
            this.TXTMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTMonth_KeyDown);
            this.TXTMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMonth_KeyPress);
            this.TXTMonth.Leave += new System.EventHandler(this.TXTMonth_Leave);
            // 
            // TXTYear
            // 
            this.TXTYear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TXTYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTYear.Font = new System.Drawing.Font("B Yekan", 11.25F);
            this.TXTYear.Location = new System.Drawing.Point(2, 5);
            this.TXTYear.Name = "TXTYear";
            this.TXTYear.Size = new System.Drawing.Size(35, 23);
            this.TXTYear.TabIndex = 2;
            this.TXTYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTYear.TextChanged += new System.EventHandler(this.TXTYear_TextChanged);
            this.TXTYear.Enter += new System.EventHandler(this.TXTYear_Enter);
            this.TXTYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTYear_KeyDown);
            this.TXTYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTYear_KeyPress);
            this.TXTYear.Leave += new System.EventHandler(this.TXTYear_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyTXTDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.TXTDay);
            this.Controls.Add(this.TXTMonth);
            this.Controls.Add(this.TXTYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyTXTDate";
            this.Size = new System.Drawing.Size(103, 30);
            this.Load += new System.EventHandler(this.MyTXTDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTDay;
        private System.Windows.Forms.TextBox TXTMonth;
        private System.Windows.Forms.TextBox TXTYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
