
namespace QLDSV_TC
{
    partial class FormDangNhap
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
            this.CmbKhoa = new System.Windows.Forms.ComboBox();
            this.TxbTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbMatKhau = new System.Windows.Forms.TextBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.CbSinhVien = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CmbKhoa
            // 
            this.CmbKhoa.BackColor = System.Drawing.Color.White;
            this.CmbKhoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbKhoa.FormattingEnabled = true;
            this.CmbKhoa.Location = new System.Drawing.Point(42, 72);
            this.CmbKhoa.Name = "CmbKhoa";
            this.CmbKhoa.Size = new System.Drawing.Size(320, 33);
            this.CmbKhoa.TabIndex = 0;
            this.CmbKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbKhoa_SelectedIndexChanged);
            // 
            // TxbTaiKhoan
            // 
            this.TxbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxbTaiKhoan.Location = new System.Drawing.Point(42, 168);
            this.TxbTaiKhoan.Name = "TxbTaiKhoan";
            this.TxbTaiKhoan.Size = new System.Drawing.Size(320, 30);
            this.TxbTaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khoa/ Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(43, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // TxbMatKhau
            // 
            this.TxbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxbMatKhau.Location = new System.Drawing.Point(42, 256);
            this.TxbMatKhau.Name = "TxbMatKhau";
            this.TxbMatKhau.PasswordChar = '*';
            this.TxbMatKhau.Size = new System.Drawing.Size(320, 30);
            this.TxbMatKhau.TabIndex = 6;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnDangNhap.Location = new System.Drawing.Point(42, 329);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(320, 36);
            this.BtnDangNhap.TabIndex = 7;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // CbSinhVien
            // 
            this.CbSinhVien.AutoSize = true;
            this.CbSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CbSinhVien.Location = new System.Drawing.Point(247, 136);
            this.CbSinhVien.Name = "CbSinhVien";
            this.CbSinhVien.Size = new System.Drawing.Size(115, 29);
            this.CbSinhVien.TabIndex = 9;
            this.CbSinhVien.Text = "Sinh viên";
            this.CbSinhVien.UseVisualStyleBackColor = true;
            this.CbSinhVien.CheckedChanged += new System.EventHandler(this.CbSinhVien_CheckedChanged);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.CbSinhVien);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.TxbMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbTaiKhoan);
            this.Controls.Add(this.CmbKhoa);
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKhoa;
        private System.Windows.Forms.TextBox TxbTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbMatKhau;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.CheckBox CbSinhVien;
    }
}