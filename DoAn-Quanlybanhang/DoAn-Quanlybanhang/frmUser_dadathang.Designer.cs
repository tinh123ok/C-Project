
namespace DoAn_Quanlybanhang
{
    partial class frmUser_dadathang
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
            this.btnxeminhoadon = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btntiptucmuasam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnxeminhoadon
            // 
            this.btnxeminhoadon.Location = new System.Drawing.Point(56, 78);
            this.btnxeminhoadon.Name = "btnxeminhoadon";
            this.btnxeminhoadon.Size = new System.Drawing.Size(126, 23);
            this.btnxeminhoadon.TabIndex = 0;
            this.btnxeminhoadon.Text = "Xem và in đơn hàng";
            this.btnxeminhoadon.UseVisualStyleBackColor = true;
            this.btnxeminhoadon.Click += new System.EventHandler(this.btnxeminhoadon_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(80, 167);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rất cảm ơn....";
            // 
            // btntiptucmuasam
            // 
            this.btntiptucmuasam.Location = new System.Drawing.Point(56, 121);
            this.btntiptucmuasam.Name = "btntiptucmuasam";
            this.btntiptucmuasam.Size = new System.Drawing.Size(126, 23);
            this.btntiptucmuasam.TabIndex = 3;
            this.btntiptucmuasam.Text = "Tiếp tục mua sắm";
            this.btntiptucmuasam.UseVisualStyleBackColor = true;
            this.btntiptucmuasam.Click += new System.EventHandler(this.btntiptucmuasam_Click);
            // 
            // frmUser_dadathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 227);
            this.ControlBox = false;
            this.Controls.Add(this.btntiptucmuasam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxeminhoadon);
            this.Name = "frmUser_dadathang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng đang chờ xét duyệt";
            this.Load += new System.EventHandler(this.frmUser_dadathang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxeminhoadon;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntiptucmuasam;
    }
}