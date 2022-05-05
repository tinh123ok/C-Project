using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quanlybanhang
{
    public partial class frmUser_chinh : Form
    {
        public string thaotac = "";
        NumericUpDown nb_soluong = new NumericUpDown();
        Giohang gio = new Giohang();
        frmUser_Giohang frmgio = new frmUser_Giohang();
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        public frmUser_chinh()
        {
            InitializeComponent();
        }
        private void User_chinh_Load(object sender, EventArgs e)
        {
            dtgv_sp.DataSource = laydssp_user();
            dtgv_sp.CurrentCell = dtgv_sp.Rows[0].Cells[0];
            dtgv_sp.Rows[0].Selected = true;
            add_lb();
        }
        private void txttimkiem_Click(object sender, EventArgs e)
        {
            if (string.Compare("Tìm sản phẩm....", txttimkiem.Text) == 0)
            {
                txttimkiem.Text = "";
            }
        }

        private void btnf5_Click(object sender, EventArgs e)
        {
            dtgv_sp.DataSource = laydssp_user();
        }



        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_timkiem.PerformClick();
            }
        }

        private void btn_themgio_Click(object sender, EventArgs e)
        {
            int row = dtgv_sp.SelectedRows[0].Index;
            int slhien = Convert.ToInt32(dtgv_sp.Rows[row].Cells[3].Value.ToString());
            if (row < dtgv_sp.Rows.Count - 1 && row > -1)
            {
                if (ktraslhang(Convert.ToInt32(nb_soluong.Value), slhien))
                {
                    dtgv_sp.Rows[row].Cells[3].Value = (slhien - nb_soluong.Value);
                    SanPham newsp = new SanPham(
                        dtgv_sp.Rows[row].Cells[0].Value.ToString(),
                        Convert.ToInt32(nb_soluong.Value));
                    frmgio.themgio(newsp);
                }
            }
        }

        private void btn_xemgio_Click(object sender, EventArgs e)
        {
            frmgio.ShowDialog();
            gio = new Giohang();
        }

        private void frmUser_chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát ko???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void btn_muan_Click(object sender, EventArgs e)
        {
            int dong = dtgv_sp.CurrentRow.Index;
            if (nb_soluong.Value > 0 && dong > -1 && dong < dtgv_sp.Rows.Count - 1)
            {
                if (ktraslhang(Convert.ToInt32(nb_soluong.Value), laysohientai_hang(dtgv_sp.Rows[dong].Cells[0].Value.ToString())))
                {
                    frmUser_Giohang f = new frmUser_Giohang(this, dtgv_sp.Rows[dong].Cells[0].Value.ToString(), Convert.ToInt32(nb_soluong.Value));
                    f.ShowDialog();
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgv_sp_Click(object sender, EventArgs e)
        {
            add_lb();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() != "")
            {
                dtgv_sp.DataSource = timkiem(txttimkiem.Text);
            }
        }









        //hàm kiểm tra só lượng hàng
        private bool ktraslhang(int slmua, int slcon)
        {
            if (slmua > slcon)
            {
                MessageBox.Show("Chọn lại số lượng. hàng đang có hạn ạ!!!");
                return false;
            }
            return true;
        }
        //hàm add control label sản phẩm
        void add_lb()
        {
            int dong = dtgv_sp.CurrentCell.RowIndex;
            if (dong != dtgv_sp.Rows.Count - 1)
            {
                int max = laysohientai_hang(dtgv_sp.Rows[dong].Cells[0].Value.ToString());


                pn_search_tt.Controls.Clear();
                pn_search_tt.Location = new Point(0, 90);
                string ten = dtgv_sp.Rows[dong].Cells[1].Value.ToString();
                string[] arrten = null;
                arrten = ten.Split(' ');
                string xuat = "";
                for (int i = 0; i < arrten.Length; i++)
                {
                    xuat += arrten[i] + " ";
                    if (i % 2 == 0 && i != 0)
                    {
                        xuat += "\n";
                    }
                }
                string cty = dtgv_sp.Rows[dong].Cells[5].Value.ToString();
                string[] arrcty = null;
                arrcty = cty.Split(' ');
                string xuatcty = "";
                for (int i = 4; i < arrcty.Length; i++)
                {
                    xuatcty += arrcty[i] + " ";
                    if (i % 3 == 0 && i != 4)
                    {
                        xuatcty += "\n";
                    }
                }
                pn_search_tt.Controls.Add(new Label() { Text = "Mã Sản phẩm:", AutoSize = true, Location = new Point(0, 10) });
                pn_search_tt.Controls.Add(new Label() { Text = dtgv_sp.Rows[dong].Cells[0].Value.ToString(), Location = new Point(90, 10), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Tên Sản phẩm:", AutoSize = true, Location = new Point(0, 40) });
                pn_search_tt.Controls.Add(new Label() { Text = xuat, Location = new Point(90, 40), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Giá Sản phẩm:", AutoSize = true, Location = new Point(0, 95) });
                pn_search_tt.Controls.Add(new Label() { Text = dtgv_sp.Rows[dong].Cells[2].Value.ToString(), Location = new Point(90, 95), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Loại Hàng:", AutoSize = true, Location = new Point(0, 120) });
                pn_search_tt.Controls.Add(new Label() { Text = dtgv_sp.Rows[dong].Cells[4].Value.ToString(), Location = new Point(90, 120), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Nhà Cung Cấp:", AutoSize = true, Location = new Point(0, 150) });
                pn_search_tt.Controls.Add(new Label() { Text = xuatcty, Location = new Point(90, 150), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Hạng sử dụng:", AutoSize = true, Location = new Point(0, 210) });
                pn_search_tt.Controls.Add(new Label() { Text = dtgv_sp.Rows[dong].Cells[6].Value.ToString().Substring(0, 11), Location = new Point(90, 210), Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold), AutoSize = true });
                pn_search_tt.Controls.Add(new Label() { Text = "Số lượng:", AutoSize = true, Location = new Point(0, 240) });
                nb_soluong = new NumericUpDown() { Location = new Point(100, 240), Value = 1, Size = new Size(54, 20) };
                pn_search_tt.Controls.Add(nb_soluong);
            }
        }

        //hàm lấy danh sách hàng
        private DataTable laydssp_user()
        {
            DataTable dtbsanpham = null;
            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_laydsMH_user", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdThem);
                dtbsanpham = new DataTable();
                dtaMonhoc.Fill(dtbsanpham);
            }
            catch (Exception ex)
            {
                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtbsanpham;
        }

        //hàm tiềm kiếm hàng 
        private DataTable timkiem(string x)
        {
            x = "%" + x + "%";
            DataTable dtbsanpham = null;
            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_timkiemsp", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                cmdThem.Parameters.Add(new SqlParameter("@key", x));
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdThem);
                dtbsanpham = new DataTable();
                dtaMonhoc.Fill(dtbsanpham);
            }
            catch (Exception ex)
            {
                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtbsanpham;
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


    }
}
