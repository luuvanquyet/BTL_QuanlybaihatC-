namespace BTL
{
    partial class frmCapnhat_Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapnhat_Album));
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnThoatCapnhat = new System.Windows.Forms.Button();
            this.txtTenalbum = new System.Windows.Forms.TextBox();
            this.txtMaalbum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamphathanh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDongy
            // 
            this.btnDongy.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDongy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDongy.Location = new System.Drawing.Point(49, 196);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(97, 38);
            this.btnDongy.TabIndex = 15;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = false;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhaplai.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaplai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNhaplai.Location = new System.Drawing.Point(175, 196);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(125, 38);
            this.btnNhaplai.TabIndex = 14;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = false;
            this.btnNhaplai.Click += new System.EventHandler(this.btnNhaplai_Click);
            // 
            // btnThoatCapnhat
            // 
            this.btnThoatCapnhat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoatCapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapnhat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThoatCapnhat.Location = new System.Drawing.Point(329, 196);
            this.btnThoatCapnhat.Name = "btnThoatCapnhat";
            this.btnThoatCapnhat.Size = new System.Drawing.Size(75, 38);
            this.btnThoatCapnhat.TabIndex = 13;
            this.btnThoatCapnhat.Text = "Thoát";
            this.btnThoatCapnhat.UseVisualStyleBackColor = false;
            this.btnThoatCapnhat.Click += new System.EventHandler(this.btnThoatCapnhat_Click);
            // 
            // txtTenalbum
            // 
            this.txtTenalbum.Location = new System.Drawing.Point(188, 112);
            this.txtTenalbum.Name = "txtTenalbum";
            this.txtTenalbum.Size = new System.Drawing.Size(180, 20);
            this.txtTenalbum.TabIndex = 12;
            // 
            // txtMaalbum
            // 
            this.txtMaalbum.Enabled = false;
            this.txtMaalbum.Location = new System.Drawing.Point(188, 76);
            this.txtMaalbum.Name = "txtMaalbum";
            this.txtMaalbum.Size = new System.Drawing.Size(180, 20);
            this.txtMaalbum.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(46, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Album (50 ký tự)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Album (100 ký tự)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(159, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "CẬP NHẬT ALBUM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Năm phát hành (4 ký tự)";
            // 
            // txtNamphathanh
            // 
            this.txtNamphathanh.Location = new System.Drawing.Point(188, 153);
            this.txtNamphathanh.Name = "txtNamphathanh";
            this.txtNamphathanh.Size = new System.Drawing.Size(180, 20);
            this.txtNamphathanh.TabIndex = 17;
            // 
            // frmCapnhat_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.txtNamphathanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.btnThoatCapnhat);
            this.Controls.Add(this.txtTenalbum);
            this.Controls.Add(this.txtMaalbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCapnhat_Album";
            this.Text = "frmCapnhat_Album";
            this.Load += new System.EventHandler(this.frmCapnhat_Album_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnThoatCapnhat;
        private System.Windows.Forms.TextBox txtTenalbum;
        private System.Windows.Forms.TextBox txtMaalbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamphathanh;

    }
}