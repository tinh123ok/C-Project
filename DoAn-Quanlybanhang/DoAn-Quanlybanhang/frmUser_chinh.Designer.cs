
namespace DoAn_Quanlybanhang
{
    partial class frmUser_chinh
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
            this.dtgv_sp = new System.Windows.Forms.DataGridView();
            this.pn_chinh = new System.Windows.Forms.Panel();
            this.pn_search_tt = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btnf5 = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xemgio = new System.Windows.Forms.Button();
            this.btn_muan = new System.Windows.Forms.Button();
            this.btn_themgio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sp)).BeginInit();
            this.pn_chinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_sp
            // 
            this.dtgv_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_sp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.tenSP,
            this.gia,
            this.soluong,
            this.loaihang,
            this.NCC,
            this.hsd});
            this.dtgv_sp.Location = new System.Drawing.Point(0, 53);
            this.dtgv_sp.Name = "dtgv_sp";
            this.dtgv_sp.ReadOnly = true;
            this.dtgv_sp.RowHeadersWidth = 51;
            this.dtgv_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_sp.Size = new System.Drawing.Size(577, 397);
            this.dtgv_sp.TabIndex = 0;
            this.dtgv_sp.Click += new System.EventHandler(this.dtgv_sp_Click);
            // 
            // pn_chinh
            // 
            this.pn_chinh.Controls.Add(this.pn_search_tt);
            this.pn_chinh.Controls.Add(this.txttimkiem);
            this.pn_chinh.Controls.Add(this.btn_timkiem);
            this.pn_chinh.Controls.Add(this.btnf5);
            this.pn_chinh.Controls.Add(this.btn_thoat);
            this.pn_chinh.Controls.Add(this.btn_xemgio);
            this.pn_chinh.Controls.Add(this.btn_muan);
            this.pn_chinh.Controls.Add(this.btn_themgio);
            this.pn_chinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_chinh.Location = new System.Drawing.Point(576, 0);
            this.pn_chinh.Name = "pn_chinh";
            this.pn_chinh.Size = new System.Drawing.Size(224, 450);
            this.pn_chinh.TabIndex = 1;
            // 
            // pn_search_tt
            // 
            this.pn_search_tt.Location = new System.Drawing.Point(0, 88);
            this.pn_search_tt.Name = "pn_search_tt";
            this.pn_search_tt.Size = new System.Drawing.Size(224, 267);
            this.pn_search_tt.TabIndex = 7;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(20, 57);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(145, 20);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.Text = "Tìm sản phẩm....";
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(171, 56);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(28, 26);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btnf5
            // 
            this.btnf5.Location = new System.Drawing.Point(20, 12);
            this.btnf5.Name = "btnf5";
            this.btnf5.Size = new System.Drawing.Size(75, 23);
            this.btnf5.TabIndex = 4;
            this.btnf5.Text = "Refresh/ F5";
            this.btnf5.UseVisualStyleBackColor = true;
            this.btnf5.Click += new System.EventHandler(this.btnf5_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(129, 404);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(83, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xemgio
            // 
            this.btn_xemgio.Location = new System.Drawing.Point(20, 404);
            this.btn_xemgio.Name = "btn_xemgio";
            this.btn_xemgio.Size = new System.Drawing.Size(83, 23);
            this.btn_xemgio.TabIndex = 2;
            this.btn_xemgio.Text = "Xem giỏ hàng";
            this.btn_xemgio.UseVisualStyleBackColor = true;
            this.btn_xemgio.Click += new System.EventHandler(this.btn_xemgio_Click);
            // 
            // btn_muan
            // 
            this.btn_muan.Location = new System.Drawing.Point(129, 375);
            this.btn_muan.Name = "btn_muan";
            this.btn_muan.Size = new System.Drawing.Size(83, 23);
            this.btn_muan.TabIndex = 1;
            this.btn_muan.Text = "Mua ngay";
            this.btn_muan.UseVisualStyleBackColor = true;
            this.btn_muan.Click += new System.EventHandler(this.btn_muan_Click);
            // 
            // btn_themgio
            // 
            this.btn_themgio.Location = new System.Drawing.Point(20, 375);
            this.btn_themgio.Name = "btn_themgio";
            this.btn_themgio.Size = new System.Drawing.Size(83, 23);
            this.btn_themgio.TabIndex = 0;
            this.btn_themgio.Text = "Thêm vào giỏ";
            this.btn_themgio.UseVisualStyleBackColor = true;
            this.btn_themgio.Click += new System.EventHandler(this.btn_themgio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hàng Sale Sốc";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaHang";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "TenHang";
            this.tenSP.HeaderText = "Tên Sản Phẩm";
            this.tenSP.MinimumWidth = 6;
            this.tenSP.Name = "tenSP";
            this.tenSP.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "giabanra";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // loaihang
            // 
            this.loaihang.DataPropertyName = "TenLH";
            this.loaihang.HeaderText = "Loại Hạng";
            this.loaihang.MinimumWidth = 6;
            this.loaihang.Name = "loaihang";
            this.loaihang.ReadOnly = true;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "TenCTy";
            this.NCC.HeaderText = "Nhà Cung Cấp";
            this.NCC.MinimumWidth = 6;
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            // 
            // hsd
            // 
            this.hsd.DataPropertyName = "ngayhethang";
            this.hsd.HeaderText = "Hạn Sử Dụng";
            this.hsd.MinimumWidth = 6;
            this.hsd.Name = "hsd";
            this.hsd.ReadOnly = true;
            // 
            // frmUser_chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_sp);
            this.Controls.Add(this.pn_chinh);
            this.Name = "frmUser_chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_chinh_FormClosing);
            this.Load += new System.EventHandler(this.User_chinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sp)).EndInit();
            this.pn_chinh.ResumeLayout(false);
            this.pn_chinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_sp;
        private System.Windows.Forms.Panel pn_chinh;
        private System.Windows.Forms.Panel pn_search_tt;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btnf5;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xemgio;
        private System.Windows.Forms.Button btn_muan;
        private System.Windows.Forms.Button btn_themgio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsd;
    }
}