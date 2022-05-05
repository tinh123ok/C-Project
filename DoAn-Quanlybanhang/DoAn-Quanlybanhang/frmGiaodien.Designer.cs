
namespace DoAn_Quanlybanhang
{
    partial class frmGiaodien
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuanly = new System.Windows.Forms.Button();
            this.btnNguoimua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "WELLCOME TO ATH SHOP";
            // 
            // btnQuanly
            // 
            this.btnQuanly.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.btnQuanly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuanly.Location = new System.Drawing.Point(24, 104);
            this.btnQuanly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Size = new System.Drawing.Size(154, 172);
            this.btnQuanly.TabIndex = 2;
            this.btnQuanly.Text = "NGƯỜI QUẢN LÝ";
            this.btnQuanly.UseVisualStyleBackColor = true;
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // btnNguoimua
            // 
            this.btnNguoimua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNguoimua.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.btnNguoimua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNguoimua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNguoimua.Location = new System.Drawing.Point(213, 104);
            this.btnNguoimua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNguoimua.Name = "btnNguoimua";
            this.btnNguoimua.Size = new System.Drawing.Size(160, 172);
            this.btnNguoimua.TabIndex = 3;
            this.btnNguoimua.Text = "NGƯỜI MUA";
            this.btnNguoimua.UseVisualStyleBackColor = false;
            this.btnNguoimua.Click += new System.EventHandler(this.btnNguoimua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(145, 307);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "_______________________";
            // 
            // frmGiaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_Quanlybanhang.Properties.Resources.P7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguoimua);
            this.Controls.Add(this.btnQuanly);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiaodien";
            this.Text = "Giao diện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaodien_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuanly;
        private System.Windows.Forms.Button btnNguoimua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
    }
}

