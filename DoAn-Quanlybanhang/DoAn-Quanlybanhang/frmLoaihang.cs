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
    public partial class frmLoaihang : Form
    {
        public frmLoaihang()
        {
            InitializeComponent();
        }
        //Data Source=HARMONIT\SQLEXPRESS;Initial Catalog=QuanLy_BanHang;Integrated Security=True
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktratrungma(txtMalh.Text) && cboMaNhacungcap.Text != null && txtTenloaihang.Text.Trim() != null)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_ThemLoaihang", connect);
                    cmdthemsv.CommandText = "sp_ThemLoaihang";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter parama = new SqlParameter("@MaLH", txtMalh.Text);
                    cmdthemsv.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@TenLH", txtTenloaihang.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramalop = new SqlParameter("@MaNCC", cboMaNhacungcap.SelectedValue);
                    cmdthemsv.Parameters.Add(paramalop);

                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("them thanh cong", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("them khong thanh cong", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSloaihang();
                }
            }

        }

        private void frmLoaihang_Load(object sender, EventArgs e)
        {
            cboMaNhacungcap.DataSource = laydsNCC();

            cboMaNhacungcap.DisplayMember = "MaNCC";
            cboMaNhacungcap.ValueMember = "MaNCC";
            DSloaihang();

            dataGridView1.Columns[0].HeaderText = "Mã Loại hàng";
            dataGridView1.Columns[1].HeaderText = "Tên Loại hàng";
            dataGridView1.Columns[2].HeaderText = "Mã Nhà cung cấp";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int dong = dataGridView1.CurrentCell.RowIndex;
            txtMalh.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtTenloaihang.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            cboMaNhacungcap.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn xóa loại hàng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (txtMalh.Text.Trim() != "" && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_XoaLoaihang", connect);
                    cmdXoa.CommandText = "sp_XoaLoaihang";
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paraxoa = new SqlParameter("@malh", txtMalh.Text);
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
                    DSloaihang();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn sửa loại hàng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (txtMalh.Text.Trim() != null && cboMaNhacungcap.Text != null && txtTenloaihang.Text.Trim() != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_Sualoaihang", connect);
                    cmdthemsv.CommandText = "sp_Sualoaihang";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter parama = new SqlParameter("@MaLH", txtMalh.Text);
                    cmdthemsv.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@TenLH", txtTenloaihang.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramalop = new SqlParameter("@MaNCC", cboMaNhacungcap.SelectedValue);
                    cmdthemsv.Parameters.Add(paramalop);

                    if (cmdthemsv.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công", "thong bao");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "thong bao");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("loi" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSloaihang();
                }
            }

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != "")
            {
                string x = "%" + txtTimkiem.Text.Trim() + "%";
                dataGridView1.DataSource = timloaihang(x);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            DSloaihang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLoaihang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            if (string.Compare("Tìm Tên loại hàng...", txtTimkiem.Text) == 0)
            {
                txtTimkiem.Clear();
            }
        }




        //hàm tìm loại hàng
        private DataTable timloaihang(string x)
        {

            DataTable dtbNhacungcap = null;
            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_timkiemLoaihang", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.CommandText = "sp_timkiemLoaihang";
                SqlParameter parama = new SqlParameter("@TenLH", x);
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
        //hàm lấy danh sách nhà cug cấp
        private DataTable laydsNCC()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdLoaihang = new SqlCommand();
                cmdLoaihang.CommandText = "sp_LaydsNhaCungCap";
                cmdLoaihang.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdLoaihang.Connection = connect;
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdLoaihang);
                dtLoaihang = new DataTable();
                dakhoa.Fill(dtLoaihang);


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
            return dtLoaihang;

        }
        //hàm lấy danh sách loại hàng
        private void DSloaihang()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_dsLoaihang";
                cmdlh.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdlh.Connection = connect;
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdlh);
                dtLoaihang = new DataTable();
                dakhoa.Fill(dtLoaihang);
                dataGridView1.DataSource = dtLoaihang;

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
        //hàm kiểm tra trùng mã
        private bool ktratrungma(string x)
        {
            x = x.Trim();
            if (x.Length > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (string.Compare(dataGridView1.Rows[i].Cells[0].Value.ToString(), x) == 0)
                    {
                        MessageBox.Show("Trùng mã");
                        return false;
                    }
                }
                return true;
            }
            MessageBox.Show("Trùng mã");
            return false;
        }
    }
}
