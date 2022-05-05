
namespace DoAn_Quanlybanhang
{
    partial class frmthongke
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
            this.components = new System.ComponentModel.Container();
            this.dtgv_thongke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbHH = new System.Windows.Forms.ComboBox();
            this.cbbDH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbdaban = new System.Windows.Forms.Label();
            this.cbxemthongke = new System.Windows.Forms.CheckBox();
            this.lbthudc = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btninds = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnf5 = new System.Windows.Forms.Button();
            this.cbdonhang = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_thongke
            // 
            this.dtgv_thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_thongke.Location = new System.Drawing.Point(0, 322);
            this.dtgv_thongke.Name = "dtgv_thongke";
            this.dtgv_thongke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_thongke.Size = new System.Drawing.Size(702, 152);
            this.dtgv_thongke.TabIndex = 0;
            this.dtgv_thongke.DataSourceChanged += new System.EventHandler(this.dtgv_thongke_DataSourceChanged);
            this.dtgv_thongke.Click += new System.EventHandler(this.dtgv_thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hàng Hóa";
            // 
            // cbbHH
            // 
            this.cbbHH.FormattingEnabled = true;
            this.cbbHH.Items.AddRange(new object[] {
            "",
            "Tất Cả",
            "Tìm Kiếm",
            "Tồn Kho",
            "Hết",
            "Còn Hạn",
            "Hết Hạn",
            "Bán Chạy",
            "Bị Ế"});
            this.cbbHH.Location = new System.Drawing.Point(120, 114);
            this.cbbHH.Name = "cbbHH";
            this.cbbHH.Size = new System.Drawing.Size(152, 21);
            this.cbbHH.TabIndex = 3;
            this.cbbHH.SelectedIndexChanged += new System.EventHandler(this.cbbHH_SelectedIndexChanged);
            this.cbbHH.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // cbbDH
            // 
            this.cbbDH.FormattingEnabled = true;
            this.cbbDH.Items.AddRange(new object[] {
            "",
            "Tất Cả",
            "Đã Chốt",
            "Chưa Chốt",
            "Theo Khách Hàng",
            "Theo móc thời gian"});
            this.cbbDH.Location = new System.Drawing.Point(120, 153);
            this.cbbDH.Name = "cbbDH";
            this.cbbDH.Size = new System.Drawing.Size(152, 21);
            this.cbbDH.TabIndex = 5;
            this.cbbDH.SelectedIndexChanged += new System.EventHandler(this.cbbDH_SelectedIndexChanged);
            this.cbbDH.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Tag = "";
            this.label3.Text = "Đơn Hàng";
            // 
            // cbbLH
            // 
            this.cbbLH.FormattingEnabled = true;
            this.cbbLH.Items.AddRange(new object[] {
            "",
            "Tất Cả",
            "Tìm Kiếm"});
            this.cbbLH.Location = new System.Drawing.Point(120, 192);
            this.cbbLH.Name = "cbbLH";
            this.cbbLH.Size = new System.Drawing.Size(152, 21);
            this.cbbLH.TabIndex = 7;
            this.cbbLH.SelectedIndexChanged += new System.EventHandler(this.cbbLH_SelectedIndexChanged);
            this.cbbLH.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Hàng";
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Items.AddRange(new object[] {
            "",
            "Tất Cả",
            "Tìm Kiếm"});
            this.cbbNCC.Location = new System.Drawing.Point(120, 230);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(152, 21);
            this.cbbNCC.TabIndex = 9;
            this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
            this.cbbNCC.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(30, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // cbbKH
            // 
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Items.AddRange(new object[] {
            "",
            "Tất Cả",
            "Tìm Kiếm"});
            this.cbbKH.Location = new System.Drawing.Point(120, 74);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(152, 21);
            this.cbbKH.TabIndex = 11;
            this.cbbKH.SelectedIndexChanged += new System.EventHandler(this.cbbKH_SelectedIndexChanged);
            this.cbbKH.Click += new System.EventHandler(this.comboBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(30, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Khách Hàng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(512, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2021, 12, 10, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(348, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(474, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Đến";
            // 
            // lbdaban
            // 
            this.lbdaban.AutoSize = true;
            this.lbdaban.BackColor = System.Drawing.Color.Transparent;
            this.lbdaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdaban.ForeColor = System.Drawing.SystemColors.Control;
            this.lbdaban.Location = new System.Drawing.Point(347, 133);
            this.lbdaban.Name = "lbdaban";
            this.lbdaban.Size = new System.Drawing.Size(67, 20);
            this.lbdaban.TabIndex = 16;
            this.lbdaban.Text = "Đã bán";
            // 
            // cbxemthongke
            // 
            this.cbxemthongke.AutoSize = true;
            this.cbxemthongke.BackColor = System.Drawing.Color.Transparent;
            this.cbxemthongke.ForeColor = System.Drawing.SystemColors.Control;
            this.cbxemthongke.Location = new System.Drawing.Point(351, 70);
            this.cbxemthongke.Name = "cbxemthongke";
            this.cbxemthongke.Size = new System.Drawing.Size(97, 17);
            this.cbxemthongke.TabIndex = 17;
            this.cbxemthongke.Text = "Xem Thống Kê";
            this.cbxemthongke.UseVisualStyleBackColor = false;
            this.cbxemthongke.Click += new System.EventHandler(this.cbxemthongke_Click);
            // 
            // lbthudc
            // 
            this.lbthudc.AutoSize = true;
            this.lbthudc.BackColor = System.Drawing.Color.Transparent;
            this.lbthudc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthudc.ForeColor = System.Drawing.SystemColors.Control;
            this.lbthudc.Location = new System.Drawing.Point(347, 159);
            this.lbthudc.Name = "lbthudc";
            this.lbthudc.Size = new System.Drawing.Size(103, 20);
            this.lbthudc.TabIndex = 18;
            this.lbthudc.Text = "Thu được....";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(351, 212);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(145, 20);
            this.txttim.TabIndex = 20;
            this.txttim.Click += new System.EventHandler(this.txttim_Click);
            this.txttim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttim_KeyDown);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(528, 210);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(64, 23);
            this.btntim.TabIndex = 21;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btninds
            // 
            this.btninds.Location = new System.Drawing.Point(351, 269);
            this.btninds.Name = "btninds";
            this.btninds.Size = new System.Drawing.Size(86, 23);
            this.btninds.TabIndex = 24;
            this.btninds.Text = "In Danh Sách";
            this.btninds.UseVisualStyleBackColor = true;
            this.btninds.Click += new System.EventHandler(this.btninds_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(528, 269);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(64, 23);
            this.btnthoat.TabIndex = 25;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // btnf5
            // 
            this.btnf5.Location = new System.Drawing.Point(443, 269);
            this.btnf5.Name = "btnf5";
            this.btnf5.Size = new System.Drawing.Size(75, 23);
            this.btnf5.TabIndex = 26;
            this.btnf5.Text = "F5/Refersh";
            this.btnf5.UseVisualStyleBackColor = true;
            this.btnf5.Click += new System.EventHandler(this.btnf5_Click);
            // 
            // cbdonhang
            // 
            this.cbdonhang.AutoSize = true;
            this.cbdonhang.BackColor = System.Drawing.Color.Transparent;
            this.cbdonhang.Enabled = false;
            this.cbdonhang.ForeColor = System.Drawing.SystemColors.Control;
            this.cbdonhang.Location = new System.Drawing.Point(351, 246);
            this.cbdonhang.Name = "cbdonhang";
            this.cbdonhang.Size = new System.Drawing.Size(144, 17);
            this.cbdonhang.TabIndex = 27;
            this.cbdonhang.Text = "In Danh Sách Đơn Hàng";
            this.cbdonhang.UseVisualStyleBackColor = false;
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.cbdonhang);
            this.Controls.Add(this.btnf5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btninds);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lbthudc);
            this.Controls.Add(this.cbxemthongke);
            this.Controls.Add(this.lbdaban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbDH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_thongke);
            this.Name = "frmthongke";
            this.Text = "frmthongke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmthongke_FormClosing);
            this.Load += new System.EventHandler(this.frmthongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_thongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbHH;
        private System.Windows.Forms.ComboBox cbbDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbdaban;
        private System.Windows.Forms.CheckBox cbxemthongke;
        private System.Windows.Forms.Label lbthudc;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btninds;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ErrorProvider EP;
        private System.Windows.Forms.Button btnf5;
        private System.Windows.Forms.CheckBox cbdonhang;
    }
}