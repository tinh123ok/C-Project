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
    public partial class frmUser_Giohang : Form
    {
        public string thaotac = "";
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        frmUser_dathang frmdathang;
        Giohang _gio = new Giohang();
        frmUser_chinh frm;
        public frmUser_Giohang()
        {
            InitializeComponent();
        }
        public frmUser_Giohang(frmUser_chinh fr, string masp, int sl)
        {
            _gio.them(new SanPham(masp, sl));
            InitializeComponent();
        }
        public frmUser_Giohang(frmUser_chinh fr, int s)
        {
            frm = fr;
            InitializeComponent();
        }
        public void themgio(SanPham sp)
        {
            _gio.themsp(sp);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUser_Giohang_Load(object sender, EventArgs e)
        {
            dtgvGiohang.DataSource = addvalue();
            thongke();
            comboBox1.DataSource = laydsvoucher(soluonghang());
            comboBox1.DisplayMember = "tenVoucher";
            comboBox1.ValueMember = "maVoucher";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int dong = dtgvGiohang.CurrentCell.RowIndex;
            if (dong != dtgvGiohang.RowCount - 1)
            {
                SanPham newvalue = new SanPham(dtgvGiohang.Rows[dong].Cells[0].Value.ToString(), Convert.ToInt32(nbsoluong.Value));
                _gio.suatt(newvalue);
                dtgvGiohang.DataSource = addvalue();
                thongke();
                comboBox1.DataSource = laydsvoucher(soluonghang());
                comboBox1.DisplayMember = "tenVoucher";
                comboBox1.ValueMember = "maVoucher";
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int dong = -1;
            try
            {
                dong = dtgvGiohang.CurrentCell.RowIndex;
            }
            catch (Exception)
            {
            }
            DialogResult h = MessageBox.Show("Bạn có muốn xóa???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes && dong != dtgvGiohang.Rows.Count - 1 && dong > -1)
            {
                _gio.xoasp(dtgvGiohang.Rows[dong].Cells[0].Value.ToString());
                dtgvGiohang.DataSource = addvalue();
                thongke();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongke();
        }

        private void btndathang_Click(object sender, EventArgs e)
        {
            if (soluonghang() > 0)
            {
                _gio.MaVoucher = Convert.ToInt32(comboBox1.SelectedValue);
                frmdathang = new frmUser_dathang(_gio.MaVoucher, this);
                for (int i = 0; i < _gio.Arr.Length; i++)
                {
                    frmdathang.themhang(_gio.Arr[i]);
                }
                frmdathang.ShowDialog();
                if (string.Compare(thaotac, "0") != 0)
                {
                    Close();
                    _gio = new Giohang();
                }
            }
        }
        private void dtgvGiohang_Click(object sender, EventArgs e)
        {
            int dong = dtgvGiohang.CurrentCell.RowIndex;
            if (dong != dtgvGiohang.RowCount - 1)
            {
                lbtenhang.Text = tachchuoi(dtgvGiohang.Rows[dong].Cells[1].Value.ToString(), 0);
                lbloaihang.Text = dtgvGiohang.Rows[dong].Cells[4].Value.ToString();
                lbhsd.Text = dtgvGiohang.Rows[dong].Cells[6].Value.ToString().Substring(0, 10);
                lbgia.Text = dtgvGiohang.Rows[dong].Cells[3].Value.ToString();
                lbcongty.Text = tachchuoi(dtgvGiohang.Rows[dong].Cells[5].Value.ToString(), 4);
                nbsoluong.Value = Convert.ToInt32(dtgvGiohang.Rows[dong].Cells[2].Value.ToString());
            }
        }







        //hàm lấy số lượng hàng 
        public int soluonghang()
        {
            int dem = 0;
            for (int i = 0; i < dtgvGiohang.Rows.Count - 1; i++)
            {
                dem += (Convert.ToInt32(dtgvGiohang.Rows[i].Cells[2].Value.ToString()));

            }
            return dem;
        }
        //hàm lấy danh sách voucher theo có điều kiện (số lượng sản phẩm)
        public DataTable laydsvoucher(int dk)
        {
            DataTable dtvoucher = null;

            try
            {
                connect.Open();
                SqlCommand cmdvoucher = new SqlCommand("sp_laydsvoucher_dieukien", connect);
                cmdvoucher.CommandType = CommandType.StoredProcedure;
                cmdvoucher.Parameters.Add(new SqlParameter("@dk", dk));
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdvoucher);
                dtvoucher = new DataTable();
                dtaMonhoc.Fill(dtvoucher);
            }
            catch (Exception ex)
            {

                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtvoucher;
        }
        //hàm add hàng trong class giohang vào datagriview
        public DataTable addvalue()
        {
            DataTable dtsp_giohang = new DataTable();

            try
            {
                connect.Open();
                for (int i = 0; i < _gio.Arr.Length; i++)
                {
                    SqlCommand cmdlaysp = new SqlCommand("sp_laysp_cosl", connect);
                    cmdlaysp.CommandType = CommandType.StoredProcedure;
                    cmdlaysp.Parameters.Add(new SqlParameter("@maMH", _gio.Arr[i].MaSP));
                    cmdlaysp.Parameters.Add(new SqlParameter("@sl", _gio.Arr[i].Sl));
                    SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdlaysp);
                    dtaMonhoc.Fill(dtsp_giohang);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtsp_giohang;
        }
        //hàm thông kế thông tin chung của giỏ hàng
        public void thongke()
        {
            int tong = 0;
            int dem = 0;
            for (int i = 0; i < dtgvGiohang.Rows.Count - 1; i++)
            {
                dem++;
                tong += (Convert.ToInt32(dtgvGiohang.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dtgvGiohang.Rows[i].Cells[3].Value.ToString()));
            }
            lbvoucher.Text = comboBox1.Text;
            lbtongtien.Text = tong.ToString();
            lbsoluong.Text = dem.ToString();

        }
        //hàm tách chuỗi
        private string tachchuoi(string x, int index)
        {
            string[] y = x.Split(' ');
            string newvalue = "";
            for (int i = index; i < y.Length; i++)
            {
                newvalue += y[i] + " ";
                if (i % 2 == 0 && i != index)
                {
                    newvalue += "\n";
                }
            }
            return newvalue;
        }
    }
}
