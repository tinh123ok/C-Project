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
    public partial class frmDonhang : Form
    {
        int chotdon = 0;
        int sl;
        public frmDonhang()
        {
            InitializeComponent();
        }
        public frmDonhang(int chot)
        {
            chotdon = chot;
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");

        private void frmDonhang_Load(object sender, EventArgs e)
        {
            if (chotdon == 1)
            {
                btnSua.Enabled = false;
                btnXacnhan.Enabled = false;
            }
            DSDonhang();
            txtMadonhang.Text = null;
            sl = dataGridView1.Rows.Count;
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int dong = dataGridView1.CurrentCell.RowIndex;
            if (dong > -1 && dong < dataGridView1.RowCount - 1)
            {
                txtMadonhang.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                txtMakhachhang.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
                dtpNgaydathang.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn sửa đơn hàng này???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sl > 1 && txtMadonhang.Text != null && KHtontaiko(txtMakhachhang.Text) && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_suaDH", connect);
                    cmdthemsv.CommandText = "sp_suaDH";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter parama = new SqlParameter("@MaDH", txtMadonhang.Text);
                    cmdthemsv.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@MaKH", txtMakhachhang.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramalop = new SqlParameter("@NgayDatHang", dtpNgaydathang.Text);
                    cmdthemsv.Parameters.Add(paramalop);

                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sữa thanh cong", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("Sữa khong thanh cong", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSDonhang();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn xóa đơn hàng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sl > 1 && txtMadonhang.Text != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_xoaDH", connect);
                    cmdXoa.CommandText = "sp_xoaDH";
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paraxoa = new SqlParameter("@maDH", txtMadonhang.Text);
                    cmdXoa.Parameters.Add(paraxoa);
                    if (cmdXoa.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xoa thanh cong !");
                    }
                    else
                    {
                        MessageBox.Show("khong xoa dc");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi" + ex.Message);
                    throw;
                }
                finally
                {
                    connect.Close();
                    DSDonhang();
                }
            }
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChitietdonhang_Click(object sender, EventArgs e)
        {
            if (txtMadonhang.Text.Trim() != null && sl > 1 && slhang_DH(Convert.ToInt32(txtMadonhang.Text)))
            {
                frmChitietdonhang ctdh = new frmChitietdonhang(txtMadonhang.Text, chotdon);
                ctdh.ShowDialog();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text.Trim() != null && string.Compare("Tìm mã đơn hàng ....", txtTimkiem.Text) != 0)
            {
                timdh(txtTimkiem.Text);
            }
        }

        //bunton xác nhận là chuyển trạng thái của đơn hàng thành đã chốt
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn chốt đơn " + txtMadonhang.Text + " ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sl > 1 && txtMadonhang.Text != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_chotdon", connect);
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paraxoa = new SqlParameter("@maDH", txtMadonhang.Text);
                    cmdXoa.Parameters.Add(paraxoa);
                    if (cmdXoa.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Chốt thành công!");
                    }
                    else
                    {
                        MessageBox.Show("chốt không thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSDonhang();
                }
            }
        }

        private void frmDonhang_FormClosing(object sender, FormClosingEventArgs e)
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
        //hàm set số lượng lại sau khi chốt đơn
        private void setsl_chotdon(string madh)
        {
            DataTable dt = laydsctdh_dh(madh);
            try
            {
                connect.Open();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int newsl = laysohientai_hang(dt.Rows[i].ItemArray[1].ToString()) - Convert.ToInt32(dt.Rows[i].ItemArray[2].ToString());
                    SqlCommand cmdXoa = new SqlCommand("suasl_hang", connect);
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter parama = new SqlParameter("@mahang", dt.Rows[i].ItemArray[1].ToString());
                    SqlParameter parasl = new SqlParameter("@sl", newsl);
                    cmdXoa.Parameters.Add(parama);
                    cmdXoa.Parameters.Add(parasl);
                    if (cmdXoa.ExecuteNonQuery() < 0)
                    {
                        MessageBox.Show("đổi số ko thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi setsl_chotdon" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //hàm lấy danhh sách chi tiết đơnn hàng theo mã đơn hàng
        private DataTable laydsctdh_dh(string madh)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select MaDH,MaHang,Soluong from ChiTietDonHang where MaDH = " + madh;
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi laydsctdh_dh" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        //hàm lấy số lượng của hàng
        private int laysohientai_hang(string mahang)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select soluong from MatHang where MaHang = '" + mahang + "'";
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi laysohientai_hang" + ex.Message);
            }
            finally
            {
            }
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            }
            return -1;
        }
        //hàm lấy danh sách đơn hàng
        private void DSDonhang()
        {
            DataTable dtDonhang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_laydsDH";
                cmdlh.CommandType = CommandType.StoredProcedure;
                cmdlh.Parameters.Add(new SqlParameter("@chotdon", chotdon));
                //kết nối 
                cmdlh.Connection = connect;
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdlh);
                dtDonhang = new DataTable();
                dakhoa.Fill(dtDonhang);
                dataGridView1.DataSource = dtDonhang;

            }
            catch (Exception e)
            {
                MessageBox.Show("đọc không được dữ liệu " + e.Message);
            }
            finally
            {
                //đóng kết nối 
                connect.Close();
            }


        }
        private bool KHtontaiko(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select MaKH from KhachHang where MaKH = " + key;
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            if (dt.Rows.Count > 1)
            {
                return true;
            }
            MessageBox.Show("Mã Khách hàng ko tồn tại");
            return false;
        }
        //hàm tìm đơn hàng
        public void timdh(string madh)
        {
            DataTable dtDonhang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_timkiemdh";
                cmdlh.CommandType = CommandType.StoredProcedure;
                cmdlh.Parameters.Add(new SqlParameter("@maDH", txtTimkiem.Text));
                cmdlh.Parameters.Add(new SqlParameter("@chotdon", chotdon));
                //kết nối 
                cmdlh.Connection = connect;
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdlh);
                dtDonhang = new DataTable();
                dakhoa.Fill(dtDonhang);
                dataGridView1.DataSource = dtDonhang;

            }
            catch (Exception e)
            {
                MessageBox.Show("đọc không được dữ liệu " + e.Message);
            }
            finally
            {
                //đóng kết nối 
                connect.Close();
            }
        }
        // hàm lấy số lượng hàng trong đơn hàng
        private bool slhang_DH(int maDH)
        {
            if (maDH != -1)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlCommand lenh = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter();
                    lenh.CommandText = "select dbo.SL_hang(" + maDH + ")";
                    lenh.Connection = connect;
                    da.SelectCommand = lenh;
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
                if (dt.Rows.Count > 0)
                {
                    if (Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString()) > 0)
                    {
                        return true;
                    }
                }
                MessageBox.Show("Đơn hàng chưa có hàng");
                return false;
            }
            MessageBox.Show("Đơn hàng chưa có hàng");
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DSDonhang();
            txtTimkiem.Text = "Tìm mã đơn hàng ....";
        }
    }
}
