
namespace DoAn_Quanlybanhang
{
    partial class frmDonhang
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChitietdonhang = new System.Windows.Forms.Button();
            this.dtpNgaydathang = new System.Windows.Forms.DateTimePicker();
            this.txtMakhachhang = new System.Windows.Forms.TextBox();
            this.txtMadonhang = new System.Windows.Forms.TextBox();
            this.lblGiabanra = new System.Windows.Forms.Label();
            this.lblMaDonhang = new System.Windows.Forms.Label();
            this.lblNgayhethan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 349);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Image = global::DoAn_Quanlybanhang.Properties.Resources.undo;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(561, 58);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 29);
            this.btnBack.TabIndex = 42;
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
            this.btnTimkiem.Location = new System.Drawing.Point(561, 26);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(80, 28);
            this.btnTimkiem.TabIndex = 41;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(449, 31);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(96, 20);
            this.txtTimkiem.TabIndex = 40;
            this.txtTimkiem.Text = "Tìm mã đơn hàng ....";
            this.txtTimkiem.Click += new System.EventHandler(this.txtTimkiem_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(449, 282);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(80, 29);
            this.btnXacnhan.TabIndex = 43;
            this.btnXacnhan.Text = "Chốt Đơn";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(449, 327);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 29);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(561, 327);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(80, 29);
            this.btnThoát.TabIndex = 45;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // btnSua
            // 
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Image = global::DoAn_Quanlybanhang.Properties.Resources.repair_tools;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(561, 282);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 29);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sữa   ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChitietdonhang
            // 
            this.btnChitietdonhang.Location = new System.Drawing.Point(449, 237);
            this.btnChitietdonhang.Margin = new System.Windows.Forms.Padding(2);
            this.btnChitietdonhang.Name = "btnChitietdonhang";
            this.btnChitietdonhang.Size = new System.Drawing.Size(191, 29);
            this.btnChitietdonhang.TabIndex = 47;
            this.btnChitietdonhang.Text = "Chi tiết đơn hàng";
            this.btnChitietdonhang.UseVisualStyleBackColor = true;
            this.btnChitietdonhang.Click += new System.EventHandler(this.btnChitietdonhang_Click);
            // 
            // dtpNgaydathang
            // 
            this.dtpNgaydathang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydathang.Location = new System.Drawing.Point(544, 179);
            this.dtpNgaydathang.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaydathang.Name = "dtpNgaydathang";
            this.dtpNgaydathang.Size = new System.Drawing.Size(97, 20);
            this.dtpNgaydathang.TabIndex = 53;
            this.dtpNgaydathang.Value = new System.DateTime(2021, 12, 3, 0, 0, 0, 0);
            // 
            // txtMakhachhang
            // 
            this.txtMakhachhang.Location = new System.Drawing.Point(544, 141);
            this.txtMakhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMakhachhang.Name = "txtMakhachhang";
            this.txtMakhachhang.Size = new System.Drawing.Size(97, 20);
            this.txtMakhachhang.TabIndex = 52;
            // 
            // txtMadonhang
            // 
            this.txtMadonhang.Location = new System.Drawing.Point(544, 110);
            this.txtMadonhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMadonhang.Name = "txtMadonhang";
            this.txtMadonhang.Size = new System.Drawing.Size(97, 20);
            this.txtMadonhang.TabIndex = 51;
            // 
            // lblGiabanra
            // 
            this.lblGiabanra.AutoSize = true;
            this.lblGiabanra.BackColor = System.Drawing.Color.Transparent;
            this.lblGiabanra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGiabanra.Location = new System.Drawing.Point(450, 144);
            this.lblGiabanra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiabanra.Name = "lblGiabanra";
            this.lblGiabanra.Size = new System.Drawing.Size(82, 13);
            this.lblGiabanra.TabIndex = 50;
            this.lblGiabanra.Text = "Mã khách hàng";
            // 
            // lblMaDonhang
            // 
            this.lblMaDonhang.AutoSize = true;
            this.lblMaDonhang.BackColor = System.Drawing.Color.Transparent;
            this.lblMaDonhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaDonhang.Location = new System.Drawing.Point(450, 110);
            this.lblMaDonhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDonhang.Name = "lblMaDonhang";
            this.lblMaDonhang.Size = new System.Drawing.Size(71, 13);
            this.lblMaDonhang.TabIndex = 49;
            this.lblMaDonhang.Text = "Mã đơn hàng";
            // 
            // lblNgayhethan
            // 
            this.lblNgayhethan.AutoSize = true;
            this.lblNgayhethan.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayhethan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNgayhethan.Location = new System.Drawing.Point(450, 179);
            this.lblNgayhethan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayhethan.Name = "lblNgayhethan";
            this.lblNgayhethan.Size = new System.Drawing.Size(78, 13);
            this.lblNgayhethan.TabIndex = 48;
            this.lblNgayhethan.Text = "Ngày đặt hàng";
            // 
            // frmDonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 366);
            this.Controls.Add(this.dtpNgaydathang);
            this.Controls.Add(this.txtMakhachhang);
            this.Controls.Add(this.txtMadonhang);
            this.Controls.Add(this.lblGiabanra);
            this.Controls.Add(this.lblMaDonhang);
            this.Controls.Add(this.lblNgayhethan);
            this.Controls.Add(this.btnChitietdonhang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDonhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách đơn hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDonhang_FormClosing);
            this.Load += new System.EventHandler(this.frmDonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChitietdonhang;
        private System.Windows.Forms.DateTimePicker dtpNgaydathang;
        private System.Windows.Forms.TextBox txtMakhachhang;
        private System.Windows.Forms.TextBox txtMadonhang;
        private System.Windows.Forms.Label lblGiabanra;
        private System.Windows.Forms.Label lblMaDonhang;
        private System.Windows.Forms.Label lblNgayhethan;
    }
}