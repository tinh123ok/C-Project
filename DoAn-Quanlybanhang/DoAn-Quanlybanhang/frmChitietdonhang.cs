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
    public partial class frmChitietdonhang : Form
    {
        string maDH = "";
        int chotdon = 0;
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        public frmChitietdonhang()
        {
            InitializeComponent();
        }
        public frmChitietdonhang(string x)
        {
            maDH = x;
            InitializeComponent();
        }
        public frmChitietdonhang(string x,int chot)
        {
            chotdon = chot;
            maDH = x;
            InitializeComponent();
        }

        private void frmChitietdonhang_Load(object sender, EventArgs e)
        {
            DShang_dh();
            if (chotdon == 1)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            txtvc.Text = laygiatrivc(laymavc(maDH)).ToString();
            txttonghang.Text = tonghang(Convert.ToInt32(maDH)).ToString();
            txttongtien.Text = tonghangdagiam(Convert.ToInt32(maDH)).ToString();
            txtmaDH.Text = maDH;
        }
        private void frmChitietdonhang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text.Trim() != null)
            {

                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_xoaCTDH", connect);
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramadh = new SqlParameter("@maDH", maDH);
                    SqlParameter paramahang = new SqlParameter("@MaHang", txtMahang.Text);
                    cmdXoa.Parameters.Add(paramadh);
                    cmdXoa.Parameters.Add(paramahang);
                    if (cmdXoa.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
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
                    DShang_dh();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text.Trim() != null)
            {

                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_suaCTDH", connect);
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramadh = new SqlParameter("@maDH", maDH);
                    SqlParameter paramahang = new SqlParameter("@MaHang", txtMahang.Text);

                    cmdXoa.Parameters.Add(paramadh);
                    cmdXoa.Parameters.Add(paramahang);
                    cmdXoa.Parameters.Add(new SqlParameter("@Soluong", nbsoluong.Value));
                    if (cmdXoa.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
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
                    DShang_dh();
                }
            }
        }

        private void dtgv_CTDH_Click(object sender, EventArgs e)
        {
            int dong = dtgv_CTDH.CurrentCell.RowIndex;
            if (dong > -1 && dong < dtgv_CTDH.Rows.Count - 1)
            {
                txtMahang.Text = dtgv_CTDH.Rows[dong].Cells[0].Value.ToString();
                txtTenHanghoa.Text = dtgv_CTDH.Rows[dong].Cells[1].Value.ToString();
                txtgia.Text = dtgv_CTDH.Rows[dong].Cells[2].Value.ToString();
                nbsoluong.Value = Convert.ToInt32(dtgv_CTDH.Rows[dong].Cells[3].Value.ToString());
            }

        }
        //hàm lấy danh sách hàng trong đơn hàng
        private void DShang_dh()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_laysp_DH";
                cmdlh.CommandType = CommandType.StoredProcedure;

                cmdlh.Connection = connect;
                cmdlh.Parameters.Add(new SqlParameter("@maDH", maDH));
                //kết nối 
                SqlDataAdapter dakhoa = new SqlDataAdapter(cmdlh);
                dtLoaihang = new DataTable();
                dakhoa.Fill(dtLoaihang);
                dtgv_CTDH.DataSource = dtLoaihang;

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
        //hàm lấy giá trị voucher
        public int laygiatrivc(string mavc)
        {
            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT  dbo.laygiatrivoucher(@mavoucher)", connect);

                cmd.Parameters.AddWithValue("@mavoucher", mavc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();

            }
            string str = dt.Rows[0][0].ToString(); //ở đây giá trị trả về chỉ là 1 chuỗi             
            return Convert.ToInt32(str);
        }
        //hàm lấy mã voucher
        public string laymavc(string _maDH)
        {
            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT  dbo.laymavoucher(@maDH)", connect);

                cmd.Parameters.AddWithValue("@maDH", _maDH);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();

            }
            string str = dt.Rows[0][0].ToString(); //ở đây giá trị trả về chỉ là 1 chuỗi             
            return str;
        }
        //hàm tính tổng hàng chưa trừ voucher
        public int tonghang(int _maDH)
        {
            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT  dbo.tongtien_hang_banra(@maDH)", connect);

                cmd.Parameters.AddWithValue("@maDH", _maDH);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();

            }
            string str = dt.Rows[0][0].ToString(); //ở đây giá trị trả về chỉ là 1 chuỗi             
            return Convert.ToInt32(str);
        }
        //hàm tính tổng đã trừ voucher
        public int tonghangdagiam(int _maDH)
        {
            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT  dbo.tongdagiam(@maDH)", connect);

                cmd.Parameters.AddWithValue("@maDH", _maDH);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();

            }
            string str = dt.Rows[0][0].ToString(); //ở đây giá trị trả về chỉ là 1 chuỗi             
            return Convert.ToInt32(str);
        }

        
    }
}
