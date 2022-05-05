
namespace DoAn_Quanlybanhang
{
    partial class frmChitietdonhang
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
            this.dtgv_CTDH = new System.Windows.Forms.DataGridView();
            this.lblMadonhang = new System.Windows.Forms.Label();
            this.lblMaKhachhang = new System.Windows.Forms.Label();
            this.lblTenKhachhang = new System.Windows.Forms.Label();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTenHanghoa = new System.Windows.Forms.TextBox();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.nbsoluong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaDH = new System.Windows.Forms.TextBox();
            this.txttonghang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_CTDH
            // 
            this.dtgv_CTDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_CTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CTDH.Location = new System.Drawing.Point(9, 19);
            this.dtgv_CTDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_CTDH.Name = "dtgv_CTDH";
            this.dtgv_CTDH.RowHeadersWidth = 51;
            this.dtgv_CTDH.RowTemplate.Height = 24;
            this.dtgv_CTDH.Size = new System.Drawing.Size(577, 450);
            this.dtgv_CTDH.TabIndex = 0;
            this.dtgv_CTDH.Click += new System.EventHandler(this.dtgv_CTDH_Click);
            // 
            // lblMadonhang
            // 
            this.lblMadonhang.AutoSize = true;
            this.lblMadonhang.BackColor = System.Drawing.Color.Transparent;
            this.lblMadonhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMadonhang.Location = new System.Drawing.Point(606, 266);
            this.lblMadonhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMadonhang.Name = "lblMadonhang";
            this.lblMadonhang.Size = new System.Drawing.Size(23, 13);
            this.lblMadonhang.TabIndex = 52;
            this.lblMadonhang.Text = "Giá";
            // 
            // lblMaKhachhang
            // 
            this.lblMaKhachhang.AutoSize = true;
            this.lblMaKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKhachhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaKhachhang.Location = new System.Drawing.Point(606, 195);
            this.lblMaKhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhachhang.Name = "lblMaKhachhang";
            this.lblMaKhachhang.Size = new System.Drawing.Size(49, 13);
            this.lblMaKhachhang.TabIndex = 48;
            this.lblMaKhachhang.Text = "Mã hàng";
            // 
            // lblTenKhachhang
            // 
            this.lblTenKhachhang.AutoSize = true;
            this.lblTenKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKhachhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenKhachhang.Location = new System.Drawing.Point(606, 227);
            this.lblTenKhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhachhang.Name = "lblTenKhachhang";
            this.lblTenKhachhang.Size = new System.Drawing.Size(53, 13);
            this.lblTenKhachhang.TabIndex = 49;
            this.lblTenKhachhang.Text = "Tên hàng";
            // 
            // txtMahang
            // 
            this.txtMahang.Enabled = false;
            this.txtMahang.Location = new System.Drawing.Point(706, 191);
            this.txtMahang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(203, 20);
            this.txtMahang.TabIndex = 50;
            // 
            // txtTenHanghoa
            // 
            this.txtTenHanghoa.Enabled = false;
            this.txtTenHanghoa.Location = new System.Drawing.Point(706, 224);
            this.txtTenHanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHanghoa.Name = "txtTenHanghoa";
            this.txtTenHanghoa.Size = new System.Drawing.Size(203, 20);
            this.txtTenHanghoa.TabIndex = 51;
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanpham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSanpham.Location = new System.Drawing.Point(606, 306);
            this.lblSanpham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(49, 13);
            this.lblSanpham.TabIndex = 73;
            this.lblSanpham.Text = "Số lượng";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = global::DoAn_Quanlybanhang.Properties.Resources.close__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(829, 389);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 47);
            this.btnThoat.TabIndex = 78;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Image = global::DoAn_Quanlybanhang.Properties.Resources.repair_tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(723, 389);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 49);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sữa  ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Image = global::DoAn_Quanlybanhang.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(621, 389);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 47);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa   ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // nbsoluong
            // 
            this.nbsoluong.Location = new System.Drawing.Point(706, 306);
            this.nbsoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nbsoluong.Name = "nbsoluong";
            this.nbsoluong.Size = new System.Drawing.Size(67, 20);
            this.nbsoluong.TabIndex = 79;
            this.nbsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(606, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // txtmaDH
            // 
            this.txtmaDH.Enabled = false;
            this.txtmaDH.Location = new System.Drawing.Point(706, 19);
            this.txtmaDH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaDH.Name = "txtmaDH";
            this.txtmaDH.Size = new System.Drawing.Size(203, 20);
            this.txtmaDH.TabIndex = 81;
            // 
            // txttonghang
            // 
            this.txttonghang.Enabled = false;
            this.txttonghang.Location = new System.Drawing.Point(706, 81);
            this.txttonghang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttonghang.Name = "txttonghang";
            this.txttonghang.Size = new System.Drawing.Size(203, 20);
            this.txttonghang.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(606, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tổng hàng";
            // 
            // txtvc
            // 
            this.txtvc.Enabled = false;
            this.txtvc.Location = new System.Drawing.Point(706, 49);
            this.txtvc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtvc.Name = "txtvc";
            this.txtvc.Size = new System.Drawing.Size(203, 20);
            this.txtvc.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(606, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Giảm";
            // 
            // txttongtien
            // 
            this.txttongtien.Enabled = false;
            this.txttongtien.Location = new System.Drawing.Point(706, 112);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(203, 20);
            this.txttongtien.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(606, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(670, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 88;
            this.label5.Text = "Thông tin hàng";
            // 
            // txtgia
            // 
            this.txtgia.Enabled = false;
            this.txtgia.Location = new System.Drawing.Point(706, 263);
            this.txtgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(203, 20);
            this.txtgia.TabIndex = 89;
            // 
            // frmChitietdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 479);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttonghang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbsoluong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.lblMadonhang);
            this.Controls.Add(this.txtTenHanghoa);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.lblTenKhachhang);
            this.Controls.Add(this.lblMaKhachhang);
            this.Controls.Add(this.dtgv_CTDH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChitietdonhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết đơn hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChitietdonhang_FormClosing);
            this.Load += new System.EventHandler(this.frmChitietdonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbsoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_CTDH;
        private System.Windows.Forms.Label lblMadonhang;
        private System.Windows.Forms.Label lblMaKhachhang;
        private System.Windows.Forms.Label lblTenKhachhang;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTenHanghoa;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.NumericUpDown nbsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaDH;
        private System.Windows.Forms.TextBox txttonghang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
    }
}