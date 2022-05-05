
namespace DoAn_Quanlybanhang
{
    partial class frmMathang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.cboMalh = new System.Windows.Forms.ComboBox();
            this.cboMancc = new System.Windows.Forms.ComboBox();
            this.dtpHansudung = new System.Windows.Forms.DateTimePicker();
            this.txtGiabanra = new System.Windows.Forms.TextBox();
            this.txtGianhapvao = new System.Windows.Forms.TextBox();
            this.lblGiabanra = new System.Windows.Forms.Label();
            this.lblGianv = new System.Windows.Forms.Label();
            this.lblNgayhethan = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblMalh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMancc = new System.Windows.Forms.Label();
            this.txtTenHanghoa = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.lblMahang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 81;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 193);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(263, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "DANH SÁCH MẶT HÀNG";
            // 
            // grbChucnang
            // 
            this.grbChucnang.BackColor = System.Drawing.Color.Transparent;
            this.grbChucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbChucnang.Controls.Add(this.cboMalh);
            this.grbChucnang.Controls.Add(this.cboMancc);
            this.grbChucnang.Controls.Add(this.dtpHansudung);
            this.grbChucnang.Controls.Add(this.txtGiabanra);
            this.grbChucnang.Controls.Add(this.txtGianhapvao);
            this.grbChucnang.Controls.Add(this.lblGiabanra);
            this.grbChucnang.Controls.Add(this.lblGianv);
            this.grbChucnang.Controls.Add(this.lblNgayhethan);
            this.grbChucnang.Controls.Add(this.btnBack);
            this.grbChucnang.Controls.Add(this.btnTimkiem);
            this.grbChucnang.Controls.Add(this.txtTimkiem);
            this.grbChucnang.Controls.Add(this.lblTimkiem);
            this.grbChucnang.Controls.Add(this.txtSoluong);
            this.grbChucnang.Controls.Add(this.lblSoluong);
            this.grbChucnang.Controls.Add(this.lblMalh);
            this.grbChucnang.Controls.Add(this.btnThoat);
            this.grbChucnang.Controls.Add(this.btnSua);
            this.grbChucnang.Controls.Add(this.btnXoa);
            this.grbChucnang.Controls.Add(this.btnThem);
            this.grbChucnang.Controls.Add(this.lblMancc);
            this.grbChucnang.Controls.Add(this.txtTenHanghoa);
            this.grbChucnang.Controls.Add(this.txtMahang);
            this.grbChucnang.Controls.Add(this.lblTenhang);
            this.grbChucnang.Controls.Add(this.lblMahang);
            this.grbChucnang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbChucnang.Location = new System.Drawing.Point(16, 48);
            this.grbChucnang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucnang.Size = new System.Drawing.Size(800, 231);
            this.grbChucnang.TabIndex = 13;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chức năng";
            // 
            // cboMalh
            // 
            this.cboMalh.FormattingEnabled = true;
            this.cboMalh.Location = new System.Drawing.Point(104, 133);
            this.cboMalh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMalh.Name = "cboMalh";
            this.cboMalh.Size = new System.Drawing.Size(203, 21);
            this.cboMalh.TabIndex = 47;
            // 
            // cboMancc
            // 
            this.cboMancc.FormattingEnabled = true;
            this.cboMancc.Location = new System.Drawing.Point(104, 95);
            this.cboMancc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMancc.Name = "cboMancc";
            this.cboMancc.Size = new System.Drawing.Size(203, 21);
            this.cboMancc.TabIndex = 46;
            this.cboMancc.SelectedIndexChanged += new System.EventHandler(this.cboMancc_SelectedIndexChanged);
            // 
            // dtpHansudung
            // 
            this.dtpHansudung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHansudung.Location = new System.Drawing.Point(494, 25);
            this.dtpHansudung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHansudung.Name = "dtpHansudung";
            this.dtpHansudung.Size = new System.Drawing.Size(203, 20);
            this.dtpHansudung.TabIndex = 45;
            this.dtpHansudung.Value = new System.DateTime(2021, 12, 3, 0, 0, 0, 0);
            // 
            // txtGiabanra
            // 
            this.txtGiabanra.Location = new System.Drawing.Point(494, 87);
            this.txtGiabanra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiabanra.Name = "txtGiabanra";
            this.txtGiabanra.Size = new System.Drawing.Size(203, 20);
            this.txtGiabanra.TabIndex = 44;
            // 
            // txtGianhapvao
            // 
            this.txtGianhapvao.Location = new System.Drawing.Point(494, 56);
            this.txtGianhapvao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGianhapvao.Name = "txtGianhapvao";
            this.txtGianhapvao.Size = new System.Drawing.Size(203, 20);
            this.txtGianhapvao.TabIndex = 43;
            // 
            // lblGiabanra
            // 
            this.lblGiabanra.AutoSize = true;
            this.lblGiabanra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGiabanra.Location = new System.Drawing.Point(397, 89);
            this.lblGiabanra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiabanra.Name = "lblGiabanra";
            this.lblGiabanra.Size = new System.Drawing.Size(58, 13);
            this.lblGiabanra.TabIndex = 42;
            this.lblGiabanra.Text = "Gía bán ra";
            // 
            // lblGianv
            // 
            this.lblGianv.AutoSize = true;
            this.lblGianv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGianv.Location = new System.Drawing.Point(397, 59);
            this.lblGianv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGianv.Name = "lblGianv";
            this.lblGianv.Size = new System.Drawing.Size(73, 13);
            this.lblGianv.TabIndex = 41;
            this.lblGianv.Text = "Gía nhập vào";
            // 
            // lblNgayhethan
            // 
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNgayhethan.Location = new System.Drawing.Point(397, 27);
            this.lblNgayhethan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(68, 13);
            this.lblNgayhethan.TabIndex = 40;
            this.lblNgayhethan.Text = "Hạn sử dụng";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Image = global::DoAn_Quanlybanhang.Properties.Resources.undo;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(692, 183);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 29);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Reset  ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimkiem.Image = global::DoAn_Quanlybanhang.Properties.Resources.job__1_;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(592, 184);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(74, 28);
            this.btnTimkiem.TabIndex = 36;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(474, 188);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(106, 20);
            this.txtTimkiem.TabIndex = 35;
            this.txtTimkiem.Text = "Nhập tên hàng ....";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimkiem.Location = new System.Drawing.Point(396, 188);
            this.lblTimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(64, 17);
            this.lblTimkiem.TabIndex = 34;
            this.lblTimkiem.Text = "Tìm kiếm";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(104, 170);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(203, 20);
            this.txtSoluong.TabIndex = 33;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoluong.Location = new System.Drawing.Point(4, 174);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(49, 13);
            this.lblSoluong.TabIndex = 31;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblMalh
            // 
            this.lblMalh.AutoSize = true;
            this.lblMalh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMalh.Location = new System.Drawing.Point(4, 133);
            this.lblMalh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMalh.Name = "lblMalh";
            this.lblMalh.Size = new System.Drawing.Size(68, 13);
            this.lblMalh.TabIndex = 30;
            this.lblMalh.Text = "Mã loại hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = global::DoAn_Quanlybanhang.Properties.Resources.close__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(692, 127);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 47);
            this.btnThoat.TabIndex = 29;
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
            this.btnSua.Location = new System.Drawing.Point(592, 128);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 49);
            this.btnSua.TabIndex = 28;
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
            this.btnXoa.Location = new System.Drawing.Point(494, 127);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 47);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa   ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Image = global::DoAn_Quanlybanhang.Properties.Resources.add_file__1_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(399, 127);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 47);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm   ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.BackColor = System.Drawing.Color.Transparent;
            this.lblMancc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMancc.Location = new System.Drawing.Point(4, 95);
            this.lblMancc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(91, 13);
            this.lblMancc.TabIndex = 25;
            this.lblMancc.Text = "Mã nhà cung cấp";
            // 
            // txtTenHanghoa
            // 
            this.txtTenHanghoa.Location = new System.Drawing.Point(104, 56);
            this.txtTenHanghoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHanghoa.Name = "txtTenHanghoa";
            this.txtTenHanghoa.Size = new System.Drawing.Size(203, 20);
            this.txtTenHanghoa.TabIndex = 23;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(104, 23);
            this.txtMahang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(203, 20);
            this.txtMahang.TabIndex = 22;
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.BackColor = System.Drawing.Color.Transparent;
            this.lblTenhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenhang.Location = new System.Drawing.Point(4, 58);
            this.lblTenhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(74, 13);
            this.lblTenhang.TabIndex = 21;
            this.lblTenhang.Text = "Tên hàng hóa";
            // 
            // lblMahang
            // 
            this.lblMahang.AutoSize = true;
            this.lblMahang.BackColor = System.Drawing.Color.Transparent;
            this.lblMahang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMahang.Location = new System.Drawing.Point(4, 25);
            this.lblMahang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMahang.Name = "lblMahang";
            this.lblMahang.Size = new System.Drawing.Size(49, 13);
            this.lblMahang.TabIndex = 20;
            this.lblMahang.Text = "Mã hàng";
            // 
            // frmMathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbChucnang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMathang_FormClosing);
            this.Load += new System.EventHandler(this.frmMathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbChucnang.ResumeLayout(false);
            this.grbChucnang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbChucnang;
        private System.Windows.Forms.ComboBox cboMalh;
        private System.Windows.Forms.ComboBox cboMancc;
        private System.Windows.Forms.DateTimePicker dtpHansudung;
        private System.Windows.Forms.TextBox txtGiabanra;
        private System.Windows.Forms.TextBox txtGianhapvao;
        private System.Windows.Forms.Label lblGiabanra;
        private System.Windows.Forms.Label lblGianv;
        private System.Windows.Forms.Label lblNgayhethan;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblMalh;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.TextBox txtTenHanghoa;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.Label lblMahang;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}