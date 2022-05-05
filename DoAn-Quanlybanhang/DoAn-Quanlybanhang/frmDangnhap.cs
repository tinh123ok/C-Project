using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAn_Quanlybanhang
{
    public partial class frmDangnhap : Form
    {
        bool dangnhap = false;
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (dangnhap == false)
            {
                SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
                try
                {
                    connect.Open();
                    string tk = txtTaikhoan.Text;
                    string mk = txtMatkhau.Text;
                    string sql = "select* from Admin Where Taikhoan = '" + tk + "'and Matkhau = '" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("Đặng nhập thành công !");
                        Close();
                        this.Hide();

                        frmNguoiquanly f1 = new frmNguoiquanly();
                        dangnhap = true;
                        f1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu hoặc tài khoản, Đăng nhập thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi !" + ex.Message);
                }
            }
            else
            {
                frmNguoiquanly f1 = new frmNguoiquanly();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void txtTaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

    }
}
