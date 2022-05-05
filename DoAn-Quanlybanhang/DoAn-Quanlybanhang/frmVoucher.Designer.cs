
namespace DoAn_Quanlybanhang
{
    partial class frmVoucher
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
            this.dtgvoucher = new System.Windows.Forms.DataGridView();
            this.lblGiatri = new System.Windows.Forms.Label();
            this.lblTenvoucher = new System.Windows.Forms.Label();
            this.lblDieukien = new System.Windows.Forms.Label();
            this.txtTenvoucher = new System.Windows.Forms.TextBox();
            this.txtGiatri = new System.Windows.Forms.TextBox();
            this.txtDieukien = new System.Windows.Forms.TextBox();
            this.lblNamefrm = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvoucher
            // 
            this.dtgvoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvoucher.Location = new System.Drawing.Point(9, 206);
            this.dtgvoucher.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvoucher.Name = "dtgvoucher";
            this.dtgvoucher.RowHeadersWidth = 51;
            this.dtgvoucher.RowTemplate.Height = 24;
            this.dtgvoucher.Size = new System.Drawing.Size(466, 150);
            this.dtgvoucher.TabIndex = 0;
            this.dtgvoucher.Click += new System.EventHandler(this.dtgvvoucher_Click);
            // 
            // lblGiatri
            // 
            this.lblGiatri.AutoSize = true;
            this.lblGiatri.BackColor = System.Drawing.Color.Transparent;
            this.lblGiatri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGiatri.Location = new System.Drawing.Point(42, 96);
            this.lblGiatri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiatri.Name = "lblGiatri";
            this.lblGiatri.Size = new System.Drawing.Size(36, 13);
            this.lblGiatri.TabIndex = 2;
            this.lblGiatri.Text = "Gía trị";
            // 
            // lblTenvoucher
            // 
            this.lblTenvoucher.AutoSize = true;
            this.lblTenvoucher.BackColor = System.Drawing.Color.Transparent;
            this.lblTenvoucher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenvoucher.Location = new System.Drawing.Point(87, 54);
            this.lblTenvoucher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenvoucher.Name = "lblTenvoucher";
            this.lblTenvoucher.Size = new System.Drawing.Size(68, 13);
            this.lblTenvoucher.TabIndex = 3;
            this.lblTenvoucher.Text = "Tên voucher";
            // 
            // lblDieukien
            // 
            this.lblDieukien.AutoSize = true;
            this.lblDieukien.BackColor = System.Drawing.Color.Transparent;
            this.lblDieukien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDieukien.Location = new System.Drawing.Point(261, 97);
            this.lblDieukien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDieukien.Name = "lblDieukien";
            this.lblDieukien.Size = new System.Drawing.Size(52, 13);
            this.lblDieukien.TabIndex = 4;
            this.lblDieukien.Text = "Điều kiện";
            // 
            // txtTenvoucher
            // 
            this.txtTenvoucher.Location = new System.Drawing.Point(159, 51);
            this.txtTenvoucher.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenvoucher.Name = "txtTenvoucher";
            this.txtTenvoucher.Size = new System.Drawing.Size(199, 20);
            this.txtTenvoucher.TabIndex = 6;
            // 
            // txtGiatri
            // 
            this.txtGiatri.Location = new System.Drawing.Point(96, 93);
            this.txtGiatri.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiatri.Name = "txtGiatri";
            this.txtGiatri.Size = new System.Drawing.Size(123, 20);
            this.txtGiatri.TabIndex = 7;
            // 
            // txtDieukien
            // 
            this.txtDieukien.Location = new System.Drawing.Point(315, 93);
            this.txtDieukien.Margin = new System.Windows.Forms.Padding(2);
            this.txtDieukien.Name = "txtDieukien";
            this.txtDieukien.Size = new System.Drawing.Size(123, 20);
            this.txtDieukien.TabIndex = 8;
            // 
            // lblNamefrm
            // 
            this.lblNamefrm.AutoSize = true;
            this.lblNamefrm.BackColor = System.Drawing.Color.Transparent;
            this.lblNamefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamefrm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNamefrm.Location = new System.Drawing.Point(186, 9);
            this.lblNamefrm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamefrm.Name = "lblNamefrm";
            this.lblNamefrm.Size = new System.Drawing.Size(116, 25);
            this.lblNamefrm.TabIndex = 13;
            this.lblNamefrm.Text = "VOUCHER";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = global::DoAn_Quanlybanhang.Properties.Resources.close__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(354, 134);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 47);
            this.btnThoat.TabIndex = 33;
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
            this.btnSua.Location = new System.Drawing.Point(242, 134);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 49);
            this.btnSua.TabIndex = 32;
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
            this.btnXoa.Location = new System.Drawing.Point(139, 134);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 47);
            this.btnXoa.TabIndex = 31;
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
            this.btnThem.Location = new System.Drawing.Point(35, 134);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 47);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm   ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNamefrm);
            this.Controls.Add(this.txtDieukien);
            this.Controls.Add(this.txtGiatri);
            this.Controls.Add(this.txtTenvoucher);
            this.Controls.Add(this.lblDieukien);
            this.Controls.Add(this.lblTenvoucher);
            this.Controls.Add(this.lblGiatri);
            this.Controls.Add(this.dtgvoucher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVoucher";
            this.Text = "frmVoucher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvoucher;
        private System.Windows.Forms.Label lblGiatri;
        private System.Windows.Forms.Label lblTenvoucher;
        private System.Windows.Forms.Label lblDieukien;
        private System.Windows.Forms.TextBox txtTenvoucher;
        private System.Windows.Forms.TextBox txtGiatri;
        private System.Windows.Forms.TextBox txtDieukien;
        private System.Windows.Forms.Label lblNamefrm;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}