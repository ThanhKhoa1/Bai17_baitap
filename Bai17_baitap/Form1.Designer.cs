namespace Bai17_baitap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLT = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.CheckedListBox();
            this.ckID = new System.Windows.Forms.CheckBox();
            this.ckIN = new System.Windows.Forms.CheckBox();
            this.ckGT = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.ListBox();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(134, 30);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(139, 20);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lập trình bởi";
            // 
            // lblLT
            // 
            this.lblLT.AutoSize = true;
            this.lblLT.Location = new System.Drawing.Point(148, 327);
            this.lblLT.Name = "lblLT";
            this.lblLT.Size = new System.Drawing.Size(0, 13);
            this.lblLT.TabIndex = 2;
            // 
            // font
            // 
            this.font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.font.FormattingEnabled = true;
            this.font.Location = new System.Drawing.Point(273, 92);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(120, 154);
            this.font.TabIndex = 3;
            this.font.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // ckID
            // 
            this.ckID.AutoSize = true;
            this.ckID.BackColor = System.Drawing.Color.White;
            this.ckID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckID.Location = new System.Drawing.Point(283, 117);
            this.ckID.Name = "ckID";
            this.ckID.Size = new System.Drawing.Size(66, 17);
            this.ckID.TabIndex = 4;
            this.ckID.Text = "In Đậm";
            this.ckID.UseVisualStyleBackColor = false;
            this.ckID.CheckedChanged += new System.EventHandler(this.ckID_CheckedChanged);
            // 
            // ckIN
            // 
            this.ckIN.AutoSize = true;
            this.ckIN.BackColor = System.Drawing.Color.White;
            this.ckIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckIN.Location = new System.Drawing.Point(282, 147);
            this.ckIN.Name = "ckIN";
            this.ckIN.Size = new System.Drawing.Size(79, 17);
            this.ckIN.TabIndex = 4;
            this.ckIN.Text = "In ngiêng";
            this.ckIN.UseVisualStyleBackColor = false;
            this.ckIN.CheckedChanged += new System.EventHandler(this.ckIN_CheckedChanged);
            // 
            // ckGT
            // 
            this.ckGT.AutoSize = true;
            this.ckGT.BackColor = System.Drawing.Color.White;
            this.ckGT.Location = new System.Drawing.Point(282, 175);
            this.ckGT.Name = "ckGT";
            this.ckGT.Size = new System.Drawing.Size(70, 17);
            this.ckGT.TabIndex = 4;
            this.ckGT.Text = "Gạch tên";
            this.ckGT.UseVisualStyleBackColor = false;
            this.ckGT.CheckedChanged += new System.EventHandler(this.ckGT_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.color.FormattingEnabled = true;
            this.color.Location = new System.Drawing.Point(63, 92);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(139, 160);
            this.color.TabIndex = 9;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.BackColor = System.Drawing.Color.White;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(69, 147);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 10;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = false;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.BackColor = System.Drawing.Color.White;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(69, 175);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 10;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = false;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.BackColor = System.Drawing.Color.White;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(69, 211);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 17);
            this.radBlack.TabIndex = 10;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = false;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.BackColor = System.Drawing.Color.White;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(69, 114);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 10;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = false;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(502, 398);
            this.Controls.Add(this.radBlack);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(this.radRed);
            this.Controls.Add(this.color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckGT);
            this.Controls.Add(this.ckIN);
            this.Controls.Add(this.ckID);
            this.Controls.Add(this.font);
            this.Controls.Add(this.lblLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLT;
        private System.Windows.Forms.CheckedListBox font;
        private System.Windows.Forms.CheckBox ckID;
        private System.Windows.Forms.CheckBox ckIN;
        private System.Windows.Forms.CheckBox ckGT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox color;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radRed;
    }
}

