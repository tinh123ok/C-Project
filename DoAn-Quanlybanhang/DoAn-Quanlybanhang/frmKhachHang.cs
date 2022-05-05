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
using System.Text.RegularExpressions;

namespace DoAn_Quanlybanhang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktraten(txtTenkhachhang.Text) && ktrasdt(txtSdt.Text) && ktraemail(txtEmail.Text) && txtDiachi.Text.Trim() != null)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_themKH", connect);
                    cmdthemsv.CommandText = "sp_themKH";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter paramaTen = new SqlParameter("@TenKH", txtTenkhachhang.Text);
                    cmdthemsv.Parameters.Add(paramaTen);
                    SqlParameter paramaDiachi = new SqlParameter("@DC", txtDiachi.Text);
                    cmdthemsv.Parameters.Add(paramaDiachi);
                    SqlParameter paramasdt = new SqlParameter("@Sdt", txtSdt.Text);
                    cmdthemsv.Parameters.Add(paramasdt);
                    SqlParameter paramaEmail = new SqlParameter("@Email", txtEmail.Text);
                    cmdthemsv.Parameters.Add(paramaEmail);


                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("them thành công", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("them không thành công", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSKhachhang();
                }
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DSKhachhang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMakhachhang.Text.Trim() != null && ktraten(txtTenkhachhang.Text) && ktrasdt(txtSdt.Text) && ktraemail(txtEmail.Text) && txtDiachi.Text.Trim() != null)
            {
                DialogResult h = MessageBox.Show("Bạn có muốn Sửa khách hàng này???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmdthemsv = new SqlCommand("sp_suaKH", connect);
                        cmdthemsv.CommandText = "sp_suaKH";
                        cmdthemsv.CommandType = CommandType.StoredProcedure;
                        //kết nối command 
                        SqlParameter paramama = new SqlParameter("@MaKH", txtMakhachhang.Text);
                        cmdthemsv.Parameters.Add(paramama);

                        SqlParameter paramaTen = new SqlParameter("@TenKH", txtTenkhachhang.Text);
                        cmdthemsv.Parameters.Add(paramaTen);
                        SqlParameter paramaDiachi = new SqlParameter("@DC", txtDiachi.Text);
                        cmdthemsv.Parameters.Add(paramaDiachi);
                        SqlParameter paramasdt = new SqlParameter("@Sdt", txtSdt.Text);
                        cmdthemsv.Parameters.Add(paramasdt);
                        SqlParameter paramaEmail = new SqlParameter("@Email", txtEmail.Text);
                        cmdthemsv.Parameters.Add(paramaEmail);


                        if (cmdthemsv.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Sữa thành công", "thong bao");
                        }
                        else
                        {
                            MessageBox.Show("Sữa không thành công", "thong bao");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("loi" + ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                        DSKhachhang();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != "")
            {
                string x = "%" + txtTimkiem.Text.Trim() + "%";
                dtgKhachhang.DataSource = timKhachhang(x);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DSKhachhang();
            txtTimkiem.Text = "Hãy nhập tên ....";
        }

        private void dtgKhachhang_Click(object sender, EventArgs e)
        {
            int dong = dtgKhachhang.CurrentCell.RowIndex;
            txtMakhachhang.Text = dtgKhachhang.Rows[dong].Cells[0].Value.ToString();
            txtTenkhachhang.Text = dtgKhachhang.Rows[dong].Cells[1].Value.ToString();
            txtDiachi.Text = dtgKhachhang.Rows[dong].Cells[2].Value.ToString();
            txtSdt.Text = dtgKhachhang.Rows[dong].Cells[3].Value.ToString();
            txtEmail.Text = dtgKhachhang.Rows[dong].Cells[4].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn xóa???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtMakhachhang.Text.Trim() != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_xoaKH", connect);
                    cmdthemsv.CommandText = "sp_xoaKH";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter paramama = new SqlParameter("@MaKH", txtMakhachhang.Text);
                    cmdthemsv.Parameters.Add(paramama);



                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSKhachhang();
                }
            }
        }
        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimkiem.PerformClick();
            }
        }
        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        //hàm kiểm tra email
        private bool ktraemail(string x)
        {
            if (x.Trim().Length > 0 && x.Contains("@"))
            {
                return true;
            }
            MessageBox.Show("Nhập lại email");
            return false;
        }
        //hàm kiểm tra số điện thoại
        private bool ktrasdt(string x)
        {
            if (x[0] == '0')
            {
                if (x.Length == 10 || x.Length == 11)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (!char.IsDigit(x[i]))
                        {
                            MessageBox.Show("Nhập lại số điện thoại");
                            return false;
                        }
                    }
                    return true;
                }
            }
            MessageBox.Show("Nhập lại số điện thoại");
            return false;
        }
        // hàm kiểm tra tên
        private bool ktraten(string x)
        {
            var regexItem = new Regex(@"[^a-zA-Z\s\u00C0-\u017F]|[^ẩẫấầắằẳẵếềễểốồỗổ]");
            x = x.Trim();
            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (char.IsDigit(x[i]) || regexItem.IsMatch(x))
                    {
                        MessageBox.Show("Nhập lại tên");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public bool ktra_ten1(string x)
        {
            var regexItem = new Regex(@"[^a-zA-Z\d\s\u00C0-\u017F]||[^ẩẫấầắằẳẵếềễểốồỗổ]");
            x = x.Trim();
            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (regexItem.IsMatch(x))
                    {
                        MessageBox.Show("Nhập lại tên");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        //hàm tìm khách hàng theo tên, địa chỉ , sdt
        private DataTable timKhachhang(string x)
        {
            x = "%" + x.Trim() + "%";
            DataTable dtbNhacungcap = null;
            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_timkiemKhachhang", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.CommandText = "sp_timkiemKhachhang";
                SqlParameter parama = new SqlParameter("@TenKH", x);
                cmdThem.Parameters.Add(parama);

                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdThem);
                dtbNhacungcap = new DataTable();
                dtaMonhoc.Fill(dtbNhacungcap);
            }
            catch (Exception ex)
            {

                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtbNhacungcap;

        }
        //hàm lấy danh sách khách hàng
        private void DSKhachhang()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_laydsKH";
                cmdlh.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdlh.Connection = connect;
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdlh);
                dtLoaihang = new DataTable();
                dakhoa.Fill(dtLoaihang);

            }
            catch (Exception e)
            {
                MessageBox.Show("đọc không được dữ liệu " + e.Message);
            }
            finally
            {
                dtgKhachhang.DataSource = dtLoaihang;
                //đóng kết nối 
                connect.Close();

            }
        }


    }
}
