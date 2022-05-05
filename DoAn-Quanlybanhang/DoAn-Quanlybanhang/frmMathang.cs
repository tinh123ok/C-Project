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
    public partial class frmMathang : Form
    {
        public frmMathang()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");

        private void frmMathang_FormClosing(object sender, FormClosingEventArgs e)
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
        private DataTable laydsNhacungcap()
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
        private DataTable laydsLoaihang(string x)
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdLoaihang = new SqlCommand();
                cmdLoaihang.CommandText = "layLH_NCC";
                cmdLoaihang.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdLoaihang.Parameters.Add(new SqlParameter("@NCC", x));
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
        private void DSmathang()
        {
            DataTable dtLoaihang = null;
            try
            {
                // mở kết nối 
                connect.Open();

                SqlCommand cmdlh = new SqlCommand();
                cmdlh.CommandText = "sp_dsmathang";
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
                dataGridView1.DataSource = dtLoaihang;
                //đóng kết nối 
                connect.Close();
            }


        }

        private void frmMathang_Load(object sender, EventArgs e)
        {
            cboMancc.DataSource = laydsNhacungcap();
            cboMancc.DisplayMember = "TenCTy";
            cboMancc.ValueMember = "MaNCC";
            cboMancc.SelectedIndex = 0;

            cboMalh.DataSource = laydsLoaihang(cboMancc.SelectedValue.ToString());
            cboMalh.DisplayMember = "TenLH";
            cboMalh.ValueMember = "MaLH";
            cboMalh.Enabled = true;


            DSmathang();

            //Đổi tên Datagridview
            dataGridView1.Columns[0].HeaderText = "Mã Hàng";
            dataGridView1.Columns[1].HeaderText = "Tên Hàng";
            dataGridView1.Columns[2].HeaderText = "Mã Nhà cung cấp";
            dataGridView1.Columns[3].HeaderText = "Mã loại hàng";
            dataGridView1.Columns[4].HeaderText = "Số lượng";
            dataGridView1.Columns[5].HeaderText = "Ngày hết hạn";
            dataGridView1.Columns[6].HeaderText = "Gía nhập vào";
            dataGridView1.Columns[7].HeaderText = "Gía bán ra";
            dataGridView1.Columns[8].HeaderText = "Ngày nhập";
        }


        private void cboMancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMalh.Enabled = true;
            cboMalh.Text = "";
            cboMalh.DataSource = laydsLoaihang(cboMancc.SelectedValue.ToString());
            cboMalh.DisplayMember = "TenLH";
            cboMalh.ValueMember = "MaLH";
            if (cboMalh.Items.Count == 0)
            {
                cboMalh.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktratrungma(txtMahang.Text) && txtTenHanghoa.Text != null && ktrahsd(Convert.ToDateTime(dtpHansudung.Text)) && ktratiennhapvao(txtGianhapvao.Text, txtGiabanra.Text) && ktraso("Số lượng", txtSoluong.Text))
            {
                try
                {
                    string[] x = dtpHansudung.Text.Split('/');
                    connect.Open();
                    SqlCommand cmdthemsv = new SqlCommand("sp_ThemMathang", connect);
                    cmdthemsv.CommandText = "sp_ThemMathang";
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command 
                    SqlParameter paramamathang = new SqlParameter("@MaHang", txtMahang.Text);
                    cmdthemsv.Parameters.Add(paramamathang);
                    SqlParameter paraten = new SqlParameter("@TenHang", txtTenHanghoa.Text);
                    cmdthemsv.Parameters.Add(paraten);

                    SqlParameter paramaMancc = new SqlParameter("@MaNCC", cboMancc.SelectedValue);
                    cmdthemsv.Parameters.Add(paramaMancc);
                    SqlParameter paramaMaHang = new SqlParameter("@MaLH", cboMalh.SelectedValue);
                    cmdthemsv.Parameters.Add(paramaMaHang);
                    SqlParameter parasoluong = new SqlParameter("@soluong", txtSoluong.Text);
                    cmdthemsv.Parameters.Add(parasoluong);
                    SqlParameter parangayhethang = new SqlParameter("@ngayhethang", x[2] + x[1] + x[0]);
                    cmdthemsv.Parameters.Add(parangayhethang);
                    SqlParameter paragianhapvao = new SqlParameter("@gianhapvao", txtGianhapvao.Text);
                    cmdthemsv.Parameters.Add(paragianhapvao);
                    SqlParameter paragiabanra = new SqlParameter("@giabanra", txtGiabanra.Text);
                    cmdthemsv.Parameters.Add(paragiabanra);

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

                    MessageBox.Show("loi them" + ex.Message);
                }
                finally
                {
                    connect.Close();
                    DSmathang();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn xóa mặt hàng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (txtMahang.Text.Trim() != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdXoa = new SqlCommand("sp_XoaMathang", connect);
                    cmdXoa.CommandText = "sp_XoaMathang";
                    cmdXoa.CommandType = CommandType.StoredProcedure;
                    SqlParameter paraxoa = new SqlParameter("@MaHang", txtMahang.Text);
                    cmdXoa.Parameters.Add(paraxoa);
                    if (cmdXoa.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thành công !");
                    }
                    else
                    {
                        MessageBox.Show("không xóa dc");
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
                    DSmathang();
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dataGridView1.CurrentCell.RowIndex;
                txtMahang.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
                txtTenHanghoa.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
                cboMancc.SelectedValue = dataGridView1.Rows[dong].Cells[2].Value.ToString();
                cboMalh.SelectedValue = dataGridView1.Rows[dong].Cells[3].Value.ToString();
                txtSoluong.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();

                dtpHansudung.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();

                txtGiabanra.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();
                txtGianhapvao.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không in dc file" + ex.Message);
                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text.Trim() != null && txtTenHanghoa.Text != null && ktrahsd(Convert.ToDateTime(dtpHansudung.Text)) && ktratiennhapvao(txtGianhapvao.Text, txtGiabanra.Text) && ktraso("Số lượng", txtSoluong.Text))
            {
                DialogResult h = MessageBox.Show("Bạn muốn sửa mặt hàng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (h == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmdthemsv = new SqlCommand("sp_SuaMathang", connect);
                        cmdthemsv.CommandType = CommandType.StoredProcedure;
                        //kết nối command 
                        SqlParameter paramamathang = new SqlParameter("@MaHang", txtMahang.Text);
                        cmdthemsv.Parameters.Add(paramamathang);
                        SqlParameter paraten = new SqlParameter("@TenHang", txtTenHanghoa.Text);
                        cmdthemsv.Parameters.Add(paraten);

                        SqlParameter paramaMancc = new SqlParameter("@MaNCC", cboMancc.SelectedValue);
                        cmdthemsv.Parameters.Add(paramaMancc);
                        SqlParameter paramaMaHang = new SqlParameter("@MaLH", cboMalh.SelectedValue);
                        cmdthemsv.Parameters.Add(paramaMaHang);
                        SqlParameter parasoluong = new SqlParameter("@soluong", txtSoluong.Text);
                        cmdthemsv.Parameters.Add(parasoluong);
                        SqlParameter parangayhethang = new SqlParameter("@ngayhethang", dtpHansudung.Text);
                        cmdthemsv.Parameters.Add(parangayhethang);
                        SqlParameter paragianhapvao = new SqlParameter("@gianhapvao", txtGianhapvao.Text);
                        cmdthemsv.Parameters.Add(paragianhapvao);
                        SqlParameter paragiabanra = new SqlParameter("@giabanra", txtGiabanra.Text);
                        cmdthemsv.Parameters.Add(paragiabanra);

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
                        DSmathang();
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
                dataGridView1.DataSource = timMathang(x);
            }
        }
        private DataTable timMathang(string x)
        {
            DataTable dtbNhacungcap = null;

            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_timkiemMathang", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.CommandText = "sp_timkiemMathang";
                SqlParameter parama = new SqlParameter("@TenHang", x);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "Nhập tên hàng ....";
            DSmathang();

        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            if (string.Compare("Nhập tên hàng ....", txtTimkiem.Text) == 0)
            {
                txtTimkiem.Text = "";
            }
        }
        //hàm kiểm tra số
        private bool ktraso(string tenx, string x)
        {
            if (x.Length > 0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (!char.IsDigit(x[i]))
                    {
                        MessageBox.Show("Nhập lại " + tenx);
                        return false;
                    }
                }
                if (Convert.ToInt32(x) > 0)
                {
                    return true;
                }
            }
            MessageBox.Show("Nhập lại " + tenx);
            return false;
        }
        //hàm kiểm tra hạn sử dụng
        private bool ktrahsd(DateTime x)
        {
            if (DateTime.Compare(x, DateTime.Now) > 0)
            {
                return true;
            }
            MessageBox.Show("Chọn lại hạn sử dụng...");
            return false;
        }
        //hàm kiểm tra trùng mã
        private bool ktratrungma(string x)
        {
            if (x.Length > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (string.Compare(dataGridView1.Rows[i].Cells[0].Value.ToString(), x) == 0)
                    {
                        MessageBox.Show("Trùng mã");
                        return false;
                    }
                }
                return true;
            }
            MessageBox.Show("Nhập lại mã");
            return false;
        }
        //hàm ktra giá nhập và giá bán
        private bool ktratiennhapvao(string tnv, string tbr)
        {
            if (ktraso("", tnv) && ktraso("", tbr))
            {
                int tiennhapvao = Convert.ToInt32(tnv);
                int tienbanra = Convert.ToInt32(tbr);
                if (tiennhapvao <= tienbanra)
                {
                    return true;
                }
            }
            MessageBox.Show("hãy nhập lại số tiền !");
            return false;
        }
    }
}
