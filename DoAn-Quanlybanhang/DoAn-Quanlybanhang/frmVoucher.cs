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
    public partial class frmVoucher : Form
    {
        public frmVoucher()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            DSVoucher();
        }
        //hàm lấy danh sách voucher
        private void DSVoucher()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_dsVoucher";
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
                dtgvoucher.DataSource = dtLoaihang;
                //đóng kết nối 
                connect.Close();
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenvoucher.Text.Trim() != null && ktraso(txtGiatri.Text) && ktraso(txtDieukien.Text))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_ThemVoucher", connect);
                    cmdthemsv.CommandText = "sp_ThemVoucher";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 

                    SqlParameter paraten = new SqlParameter("@tenVoucher", txtTenvoucher.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramaMancc = new SqlParameter("@giatri", txtGiatri.Text);
                    cmdthemsv.Parameters.Add(paramaMancc);
                    SqlParameter paramaMaHang = new SqlParameter("@dieukien", txtDieukien.Text);
                    cmdthemsv.Parameters.Add(paramaMaHang);


                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("lỗi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSVoucher();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int dong = (dtgvoucher.Rows.Count > 0) ? dtgvoucher.CurrentCell.RowIndex : -1;
            DialogResult h = MessageBox.Show("Bạn có muốn Sửa???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (txtTenvoucher.Text != null && dong != -1 && dong < dtgvoucher.Rows.Count && h == DialogResult.Yes && ktraso(txtGiatri.Text) && ktraso(txtDieukien.Text))
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_SuaVoucher", connect);
                    cmdthemsv.CommandText = "sp_SuaVoucher";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 

                    SqlParameter paramavc = new SqlParameter("@maVoucher", dtgvoucher.Rows[dong].Cells[0].Value);
                    cmdthemsv.Parameters.Add(paramavc);

                    SqlParameter paraten = new SqlParameter("@tenVoucher", txtTenvoucher.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramaMancc = new SqlParameter("@giatri", txtGiatri.Text);
                    cmdthemsv.Parameters.Add(paramaMancc);
                    SqlParameter paramaMaHang = new SqlParameter("@dieukien", txtDieukien.Text);
                    cmdthemsv.Parameters.Add(paramaMaHang);


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

                    MessageBox.Show("lỗi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSVoucher();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dong = (dtgvoucher.Rows.Count > 0) ? dtgvoucher.CurrentCell.RowIndex : -1;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa???", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dong != -1 && dong < dtgvoucher.Rows.Count && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_XoaVoucher", connect);
                    cmdthemsv.CommandText = "sp_XoaVoucher";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter paraxoa = new SqlParameter("@maVoucher", dtgvoucher.Rows[dong].Cells[0].Value);
                    cmdthemsv.Parameters.Add(paraxoa);



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

                    MessageBox.Show("lỗi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSVoucher();
                }
            }
        }

        private void dtgvvoucher_Click(object sender, EventArgs e)
        {
            int dong = dtgvoucher.CurrentCell.RowIndex;
            if (dong != -1 && dong < dtgvoucher.RowCount)
            {
                txtTenvoucher.Text = dtgvoucher.Rows[dong].Cells[1].Value.ToString();
                txtGiatri.Text = dtgvoucher.Rows[dong].Cells[2].Value.ToString();
                txtDieukien.Text = dtgvoucher.Rows[dong].Cells[3].Value.ToString();
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVoucher_FormClosing(object sender, FormClosingEventArgs e)
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
        //hàm kiểm tra chuỗi x có phải dãy số k
        private bool ktraso(string x)
        {
            x = x.Trim();
            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (!char.IsDigit(x[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        //hàm kiểm tra kí tự đặc biệt
        public bool ktra_ten(string x)
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
    }
}
