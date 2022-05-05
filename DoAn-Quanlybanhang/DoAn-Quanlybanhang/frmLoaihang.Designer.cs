
namespace DoAn_Quanlybanhang
{
    partial class frmLoaihang
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
            this.cboMaNhacungcap = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtTenloaihang = new System.Windows.Forms.TextBox();
            this.txtMalh = new System.Windows.Forms.TextBox();
            this.lblTenNcc = new System.Windows.Forms.Label();
            this.lblMancc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 273);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 81;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 192);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(264, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại hàng hóa";
            // 
            // grbChucnang
            // 
            this.grbChucnang.BackColor = System.Drawing.Color.Transparent;
            this.grbChucnang.Controls.Add(this.cboMaNhacungcap);
            this.grbChucnang.Controls.Add(this.btnBack);
            this.grbChucnang.Controls.Add(this.btnTimkiem);
            this.grbChucnang.Controls.Add(this.txtTimkiem);
            this.grbChucnang.Controls.Add(this.btnThoat);
            this.grbChucnang.Controls.Add(this.btnSua);
            this.grbChucnang.Controls.Add(this.btnXoa);
            this.grbChucnang.Controls.Add(this.btnThem);
            this.grbChucnang.Controls.Add(this.lblDiachi);
            this.grbChucnang.Controls.Add(this.txtTenloaihang);
            this.grbChucnang.Controls.Add(this.txtMalh);
            this.grbChucnang.Controls.Add(this.lblTenNcc);
            this.grbChucnang.Controls.Add(this.lblMancc);
            this.grbChucnang.ForeColor = System.Drawing.Color.White;
            this.grbChucnang.Location = new System.Drawing.Point(9, 69);
            this.grbChucnang.Margin = new System.Windows.Forms.Padding(2);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Padding = new System.Windows.Forms.Padding(2);
            this.grbChucnang.Size = new System.Drawing.Size(676, 199);
            this.grbChucnang.TabIndex = 13;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chức năng";
            // 
            // cboMaNhacungcap
            // 
            this.cboMaNhacungcap.FormattingEnabled = true;
            this.cboMaNhacungcap.Location = new System.Drawing.Point(104, 58);
            this.cboMaNhacungcap.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaNhacungcap.Name = "cboMaNhacungcap";
            this.cboMaNhacungcap.Size = new System.Drawing.Size(203, 21);
            this.cboMaNhacungcap.TabIndex = 39;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(529, 139);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 22);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Reset";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimkiem.Location = new System.Drawing.Point(529, 113);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(108, 20);
            this.btnTimkiem.TabIndex = 36;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(332, 114);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(154, 20);
            this.txtTimkiem.TabIndex = 35;
            this.txtTimkiem.Text = "Tìm Tên loại hàng...";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(562, 23);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 47);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(485, 21);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 49);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(406, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 47);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(332, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 47);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(4, 95);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(72, 13);
            this.lblDiachi.TabIndex = 25;
            this.lblDiachi.Text = "Tên loại hàng";
            // 
            // txtTenloaihang
            // 
            this.txtTenloaihang.Location = new System.Drawing.Point(104, 95);
            this.txtTenloaihang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenloaihang.Name = "txtTenloaihang";
            this.txtTenloaihang.Size = new System.Drawing.Size(203, 20);
            this.txtTenloaihang.TabIndex = 24;
            // 
            // txtMalh
            // 
            this.txtMalh.Location = new System.Drawing.Point(104, 23);
            this.txtMalh.Margin = new System.Windows.Forms.Padding(2);
            this.txtMalh.Name = "txtMalh";
            this.txtMalh.Size = new System.Drawing.Size(203, 20);
            this.txtMalh.TabIndex = 22;
            // 
            // lblTenNcc
            // 
            this.lblTenNcc.AutoSize = true;
            this.lblTenNcc.Location = new System.Drawing.Point(4, 58);
            this.lblTenNcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNcc.Name = "lblTenNcc";
            this.lblTenNcc.Size = new System.Drawing.Size(91, 13);
            this.lblTenNcc.TabIndex = 21;
            this.lblTenNcc.Text = "Mã nhà cung cấp";
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.BackColor = System.Drawing.Color.Transparent;
            this.lblMancc.Location = new System.Drawing.Point(4, 25);
            this.lblMancc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(68, 13);
            this.lblMancc.TabIndex = 20;
            this.lblMancc.Text = "Mã loại hàng";
            // 
            // frmLoaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbChucnang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoaihang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại hàng hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaihang_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaihang_Load);
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
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.TextBox txtTenloaihang;
        private System.Windows.Forms.TextBox txtMalh;
        private System.Windows.Forms.Label lblTenNcc;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.ComboBox cboMaNhacungcap;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}