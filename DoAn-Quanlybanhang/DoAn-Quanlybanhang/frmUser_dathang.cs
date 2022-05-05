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
    public partial class frmUser_dathang : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        Giohang gio = new Giohang();
        public string thaotac = "";
        frmUser_Giohang frm;
        public frmUser_dathang()
        {
            InitializeComponent();
        }
        public frmUser_dathang(int mavc, frmUser_Giohang f)
        {
            frm = f;
            gio.MaVoucher = mavc;
            InitializeComponent();
        }

        private void frmUser_dathang_Load(object sender, EventArgs e)
        {
            dtgvhang.DataSource = addvalue();
            lbtienhang.Text = tongtien().ToString();
            lbgiatrivc.Text = laygiatrivc(gio.MaVoucher.ToString()).ToString();
            lbtongtien.Text = (Convert.ToInt32(lbtienhang.Text) - Convert.ToInt32(lbgiatrivc.Text)).ToString();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            frm.thaotac = "0";

        }
        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtDC.Clear();
            txtho.Clear();
            txtten.Clear();
            txtsdt.Clear();
            txtemail.Clear();

            ER.SetError(txtho, null);
            ER.SetError(txtten, null);
            ER.SetError(txtemail, null);
            ER.SetError(txtsdt, null);
        }

        private void btndathang_Click(object sender, EventArgs e)
        {
            if (txtho.Text != "" && txtten.Text != "" && ktra_email(txtemail.Text) && ktra_sdt(txtsdt.Text) && ktrasl())
            {
                DialogResult h = MessageBox.Show("Bạn chắc điền thông tin không???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h == DialogResult.Yes)
                {
                    int makh = Convert.ToInt32(laymaKH(txtho.Text + " " + txtten.Text, txtDC.Text, txtsdt.Text));
                    int madh = 0;
                    string mavach = random().ToString();
                    if (makh == Convert.ToInt32(null))
                    {
                        addKH(txtho.Text + " " + txtten.Text, txtDC.Text, txtsdt.Text, txtemail.Text);
                        makh = Convert.ToInt32(laymaKH(txtho.Text + " " + txtten.Text, txtDC.Text, txtsdt.Text));
                    }
                    addDH(makh, mavach, gio.MaVoucher);
                    madh = Convert.ToInt32(laymaDH(mavach));
                    if (madh != Convert.ToInt32(null))
                    {
                        addSP_DH(madh);
                        setsl_chotdon(madh.ToString());
                        frmUser_dadathang f = new frmUser_dadathang(this, txtho.Text + " " + txtten.Text, madh.ToString());
                        f.ShowDialog();
                        if (string.Compare(thaotac, "0") != 0)
                        {
                            Close();
                        }
                    }
                }

            }
        }
        private void txtDC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndathang.PerformClick();
            }
        }






        //hàm thêm hàng vào class giohang từ bên frm cha (frm giohang)
        public void themhang(SanPham sp)
        {
            gio.them(sp);
        }
        //hàm thêm hàng vào datagriview từ class giohang
        public DataTable addvalue()
        {
            DataTable dtsp_giohang = new DataTable();
            try
            {
                connect.Open();
                for (int i = 0; i < gio.Arr.Length; i++)
                {
                    SqlCommand cmdlaysp = new SqlCommand("sp_laysp_cosl_tomtat", connect);
                    cmdlaysp.CommandType = CommandType.StoredProcedure;
                    cmdlaysp.Parameters.Add(new SqlParameter("@maMH", gio.Arr[i].MaSP));
                    cmdlaysp.Parameters.Add(new SqlParameter("@sl", gio.Arr[i].Sl));
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

        //hàm random cho mavach của đơn hàng
        public int random()
        {
            Random R = new Random();
            int x;
            do
            {
                x = R.Next(9999, 100000);
            } while (ktramavach(x.ToString()));
            return x;
        }
        //hàm tính tiền
        public int tongtien()
        {
            int tong = 0;
            for (int i = 0; i < dtgvhang.Rows.Count - 1; i++)
            {
                tong += (Convert.ToInt32(dtgvhang.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt32(dtgvhang.Rows[i].Cells[3].Value.ToString()));
            }
            return tong;
        }
        //hàm kiểm tra ma vạch có trùng hay k
        public bool ktramavach(string x)
        {
            DataTable ma = new DataTable();

            try
            {
                connect.Open();

                SqlCommand cmdtimma = new SqlCommand("sp_timmavach", connect);
                cmdtimma.CommandType = CommandType.StoredProcedure;
                cmdtimma.Connection = connect;
                cmdtimma.Parameters.Add(new SqlParameter("@mavach", x));
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdtimma);
                dtaMonhoc.Fill(ma);
            }
            catch (Exception ex)
            {
                MessageBox.Show("đọc không được dữ liệu", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            if (ma.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //hàm thêm hàng vào đơn hàng
        public void addSP_DH(int maDH)
        {
            bool b = true;
            try
            {
                connect.Open();
                for (int i = 0; i < gio.Arr.Length; i++)
                {

                    SqlCommand cmdthemsv = new SqlCommand("sp_themCTDH", connect);
                    cmdthemsv.CommandType = CommandType.StoredProcedure;
                    //kết nối command @MaDH int @MaHang varchar(20),@Soluong int
                    cmdthemsv.Parameters.Add(new SqlParameter("@MaDH", maDH));
                    SqlParameter parama = new SqlParameter("@MaHang", gio.Arr[i].MaSP);
                    cmdthemsv.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@Soluong", gio.Arr[i].Sl);
                    cmdthemsv.Parameters.Add(paraten);


                    if (cmdthemsv.ExecuteNonQuery() < 0)
                    {
                        b = false;
                        MessageBox.Show("Thêm không thành công", "Thông báo");
                    }
                }
                if (b != false)
                {
                    MessageBox.Show("Đặt hàng thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //hàm thêm khách hàng vào database
        public void addKH(string ten, string dc, string sdt, string email)
        {
            try
            {
                connect.Open();
                SqlCommand cmdthemsv = new SqlCommand("sp_themKH", connect);
                cmdthemsv.CommandType = CommandType.StoredProcedure;
                //kết nối command @TenKH,@DC,@Sdt,@Email
                SqlParameter parama = new SqlParameter("@TenKH", ten);
                cmdthemsv.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@DC", dc);
                cmdthemsv.Parameters.Add(paraten);

                SqlParameter paramalop = new SqlParameter("@Sdt", sdt);
                cmdthemsv.Parameters.Add(paramalop);
                cmdthemsv.Parameters.Add(new SqlParameter("@Email", email));

                if (cmdthemsv.ExecuteNonQuery() < 0)
                {
                    MessageBox.Show("Thêm KH không thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("loi" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //hàm thêm đơn hàng vo database
        public void addDH(int maKH, string mavach, int mavoucher)
        {
            try
            {
                connect.Open();
                SqlCommand cmdthemsv = new SqlCommand("sp_themDH", connect);
                cmdthemsv.CommandType = CommandType.StoredProcedure;
                //@MaKH int,@mavach varchar(20) ,@mavoucher int
                cmdthemsv.Parameters.Add(new SqlParameter("@MaKH", maKH));
                cmdthemsv.Parameters.Add(new SqlParameter("@mavach", mavach));
                cmdthemsv.Parameters.Add(new SqlParameter("@mavoucher", mavoucher));

                if (cmdthemsv.ExecuteNonQuery() < 0)
                {
                    MessageBox.Show("Thêm ĐH không thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("lỗi" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        //hàm lấy mã khách hàng theo tên, địa chỉ, sdt
        public string laymaKH(string ten, string dc, string sdt)
        {
            DataTable ma = new DataTable();

            try
            {
                connect.Open();

                SqlCommand cmdtimma = new SqlCommand("sp_laymaKH", connect);
                cmdtimma.CommandType = CommandType.StoredProcedure;
                cmdtimma.Parameters.Add(new SqlParameter("@ten", ten));
                cmdtimma.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmdtimma.Parameters.Add(new SqlParameter("@diachi", dc));
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdtimma);
                dtaMonhoc.Fill(ma);

            }
            catch (Exception ex)
            {
                MessageBox.Show("đọc không được dữ liệu (KH)", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            string x = "";
            if (ma.Rows.Count > 0)
            {
                x = ma.Rows[0].ItemArray[0].ToString();
                return x;
            }
            else
            {
                return null;
            }
        }
        //hàm lấy mã đơn hàng
        public string laymaDH(string mavach)
        {
            DataTable ma = new DataTable();

            try
            {
                connect.Open();

                SqlCommand cmdtimma = new SqlCommand("sp_laymaDH", connect);
                cmdtimma.CommandType = CommandType.StoredProcedure;
                cmdtimma.Parameters.Add(new SqlParameter("@mavach", mavach));
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdtimma);
                dtaMonhoc.Fill(ma);

            }
            catch (Exception ex)
            {
                MessageBox.Show("đọc không được dữ liệu(ĐH)", ex.Message);
            }
            finally
            {
                connect.Close();
            }
            string x = "";
            if (ma.Rows.Count > 0)
            {
                x = ma.Rows[0].ItemArray[0].ToString();
                return x;
            }
            else
            {
                return null;
            }
        }
        //hàm kiểm tra tên 
        public bool ktra_ten(string x)
        {
            var regexItem = new Regex(@"[^a-zA-Z\s\u00C0-\u017F]");
            x = x.Trim();
            MessageBox.Show(x);
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
        //hàm kiếm tra email
        public bool ktra_email(string x)
        {
            if (!x.Contains('@'))
            {
                ER.SetError(txtemail, "nhập lại email");
                return false;
            }
            ER.SetError(txtemail, null);
            return true;
        }
        //hàm kiểm tra sdt có pải dãy số hay k
        public bool ktra_sdt(string x)
        {
            if (x[0] == '0')
            {
                if (x.Length == 10 || x.Length == 11)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (!char.IsDigit(x[i]))
                        {
                            ER.SetError(txtsdt, "nhập lại sdt");
                            return false;
                        }
                    }
                    ER.SetError(txtsdt, null);
                    return true;
                }
            }
            ER.SetError(txtsdt, "nhập lại sdt");
            return false;
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

        private void frmUser_dathang_FormClosing(object sender, FormClosingEventArgs e)
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
        //hàm kiểm tra só lượng hàng
        private bool ktraslhang(int slmua, int slcon)
        {
            if (slmua > slcon)
            {
                MessageBox.Show("Hết hạng đag hết. mời bạn quay lại sau ạ");
                return false;
            }
            return true;
        }//
        private bool ktrasl()
        {
            if (gio.Arr.Length > 0)
            {
                for (int i = 0; i < gio.Arr.Length; i++)
                {
                    if (gio.Arr[i].Sl > laysohientai_hang(gio.Arr[i].MaSP))
                    {
                        MessageBox.Show("Hết hạng đag hết. mời bạn quay lại sau ạ");
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
