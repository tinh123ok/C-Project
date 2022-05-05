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
    public partial class frmthongke : Form
    {
        //kết nối sql
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        ComboBox[] arrcbb = new ComboBox[5];
        string maDHang = (-1).ToString();
        /// <summary>
        /// Tất cả các report đều áp dụng thông qua dataset rồi mới tới cryreport
        /// </summary>
        public frmthongke()
        {
            InitializeComponent();
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            arrcbb[0] = cbbKH;
            arrcbb[1] = cbbHH;
            arrcbb[2] = cbbDH;
            arrcbb[3] = cbbLH;
            arrcbb[4] = cbbNCC;
            dateTimePicker2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            setindexselectcbb(-1);
            dtlb();
            btntim.Enabled = false;
            btninds.Enabled = false;
        }
        private void btninds_Click(object sender, EventArgs e)
        {
            SqlCommand lenh = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            if (cbxemthongke.Checked == true && cbdonhang.Checked == false)
            {
                int dong;
                dong = dtgv_thongke.Rows.Count - 1 > 0 ? dtgv_thongke.CurrentCell.RowIndex : -1;

                string madh = (dong > -1 && dong < dtgv_thongke.RowCount && Convert.ToInt32(maDHang) == -1) ? dtgv_thongke.Rows[dong].Cells[0].Value.ToString() : (-1).ToString();
                if (Convert.ToInt32(madh) == -1)
                {
                    madh = maDHang;
                }
                DataTable dt = new DataTable();

                if (Convert.ToInt32(madh) != -1 && cbxemthongke.Checked == true && slhang_DH(Convert.ToInt32(madh)) > 0 && cbdonhang.Checked == false)
                {
                    lenh.CommandText = "Select DonHang.MaKH, KhachHang.TenKH, KhachHang.DC, KhachHang.Sdt, KhachHang.Email, ChiTietDonHang.MaHang,TenHang,giabanra,ChiTietDonHang.Soluong,LoaiHang.TenLH,NhaCungCap.TenCTy,ngayhethang,ChiTietDonHang.MaDH,DonHang.maVoucher,dbo.tongdagiam(ChiTietDonHang.MaDH)as'TongTien'"
                    + " from ChiTietDonHang Inner Join MatHang On ChiTietDonHang.MaHang = MatHang.MaHang"
                    + " Inner Join LoaiHang On MatHang.MaLH = LoaiHang.MaLH"
                    + " Inner Join NhaCungCap On NhaCungCap.MaNCC = MatHang.MaNCC"
                    + " Inner Join DonHang On ChiTietDonHang.MaDH = DonHang.MaDH"
                    + " Inner Join KhachHang On KhachHang.MaKH = DonHang.MaKH"
                    + " Where ChiTietDonHang.MaDH = @MaDH or DonHang.MaVach = @MaDH";
                    lenh.Parameters.Clear();
                    lenh.Parameters.AddWithValue("@MaDH", madh);
                    lenh.Connection = connect;

                    da.SelectCommand = lenh;
                    dt = new DataTable("bangHOADON");
                    da.Fill(dt);
                    crhoadon hoadon = new crhoadon();
                    hoadon.SetDataSource(dt);



                    frmHoaDon f = new frmHoaDon();
                    f.crystalReportViewer1.ReportSource = hoadon;
                    f.ShowDialog();
                }
                if (cbdonhang.Checked == false && cbxemthongke.Checked == true && slhang_DH(Convert.ToInt32(madh)) == 0)
                {
                    MessageBox.Show("Đơn Hàng có hàng...");
                }
            }
            if (cbdonhang.Checked == true && cbxemthongke.Checked == true && btntim.Text.Contains("Xem"))
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crDH inDH = new crDH();
                inDH.SetDataSource(dt1);
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
            if (cbbKH.SelectedIndex > 0 && dtgv_thongke.Rows.Count > 1)
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crKH inDH = new crKH();
                inDH.SetDataSource(dt1);
                ((CrystalDecisions.CrystalReports.Engine.TextObject)inDH.ReportDefinition.ReportObjects["Text15"]).Text = cbbKH.Text + " Khách";
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
            if (cbbHH.SelectedIndex > 0 && cbbHH.SelectedIndex != 7 && dtgv_thongke.Rows.Count > 1)
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crHH inDH = new crHH();
                ((CrystalDecisions.CrystalReports.Engine.TextObject)inDH.ReportDefinition.ReportObjects["Text15"]).Text = "Hàng " + cbbHH.Text;
                inDH.SetDataSource(dt1);
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
            if (cbbHH.SelectedIndex > 0 && cbbHH.SelectedIndex == 7 && dtgv_thongke.Rows.Count > 1)
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crHH_banchay inDH = new crHH_banchay();
                inDH.SetDataSource(dt1);
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
            if (dtgv_thongke.Rows.Count <= 1)
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            if (cbbNCC.SelectedIndex > 0 && dtgv_thongke.Rows.Count > 1)
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crNCC inDH = new crNCC();
                ((CrystalDecisions.CrystalReports.Engine.TextObject)inDH.ReportDefinition.ReportObjects["Text15"]).Text = cbbNCC.Text + " Nhà Cùng Cấp";
                inDH.SetDataSource(dt1);
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
            if (cbbLH.SelectedIndex > 0 && dtgv_thongke.Rows.Count > 1)
            {
                DataTable dt1 = new DataTable();
                dt1 = (DataTable)dtgv_thongke.DataSource;
                crLH inDH = new crLH();
                ((CrystalDecisions.CrystalReports.Engine.TextObject)inDH.ReportDefinition.ReportObjects["Text15"]).Text = cbbLH.Text + " Loại Hàng";
                inDH.SetDataSource(dt1);
                frmHoaDon f = new frmHoaDon();
                f.crystalReportViewer1.ReportSource = inDH;
                f.Show();
            }
        }


        private void dtgv_thongke_Click(object sender, EventArgs e)
        {
            if (cbxemthongke.Checked == true)
            {
                btntim.Text = "Xem Đơn Hàng";
                btntim.AutoSize = true;
                txttim.Text = "Tìm Mã ĐH/KH...";
                btninds.Enabled = true;
            }
            else
            {
                btninds.Enabled = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (cbxemthongke.Checked == true)
            {
                dtlb();
            }
            if (cbbDH.SelectedIndex == 5)
            {
                dtgv_thongke.DataSource = getdsalldh(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
            }
        }

        private void txttim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btntim.PerformClick();
            }
        }

        private void btnf5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            btntim.Enabled = true;
            dtgv_thongke.DataSource = dt;
            setindexselectcbb(-1);
            cbxemthongke.Checked = false;
            EP.SetError(txttim, null);
            maDHang = (-1).ToString();
            btninds.Enabled = false;
            txttim.Text = null;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            txttim.Text = txttim.Text.Trim();
            int dong = -1;
            if (btntim.Text.Contains("Xem") && btntim.Enabled == true)
            {
                txttim.Enabled = false;
                dong = dtgv_thongke.Rows.Count - 1 > 0 ? dtgv_thongke.CurrentCell.RowIndex : -1;

                string madh = (dong != -1 && dong < dtgv_thongke.Rows.Count) ? dtgv_thongke.Rows[dong].Cells[0].Value.ToString() : (-1).ToString();
                if (slhang_DH(Convert.ToInt32(madh)) > -1 && dong < dtgv_thongke.Rows.Count - 1)
                {
                    if (cbxemthongke.Checked == true || cbbDH.SelectedIndex > 0)
                    {
                        if (slhang_DH(Convert.ToInt32(madh)) > 0)
                        {
                            if (Convert.ToInt32(madh) != -1)
                            {
                                maDHang = madh;
                            }
                            dtgv_thongke.DataSource = getdsctdh_dh(Convert.ToInt32(madh));
                            btntim.Enabled = false;
                            cbdonhang.Enabled = false;
                            cbdonhang.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Đơn hàng ch có hàng");
                        }
                    }
                }
            }
            if (cbbKH.SelectedIndex == 2 || cbbKH.SelectedIndex == 1)
            {
                if (txttim.Text.Trim() != null)
                {
                    dtgv_thongke.DataSource = timkiemKH(txttim.Text);
                    EP.SetError(txttim, null);
                }
            }
            if ((cbbHH.SelectedIndex == 2 || cbbHH.SelectedIndex == 1) && txttim.Text.Trim() != null)
            {
                dtgv_thongke.DataSource = laydssp_user_key(txttim.Text);
                EP.SetError(txttim, null);
            }
            if (cbbDH.SelectedIndex == 4 && txttim.Text != null)
            {
                dtgv_thongke.DataSource = laydsdh_kh(txttim.Text);
                btntim.Text = "Xem Đơn Hàng";
                txttim.Clear();
                txttim.Enabled = false;
                cbxemthongke.Checked = true;
            }
            if ((cbbLH.SelectedIndex == 1 || cbbLH.SelectedIndex == 2) && txttim.Text != null)
            {
                dtgv_thongke.DataSource = laydsloahang(txttim.Text);
            }
            if ((cbbNCC.SelectedIndex == 1 || cbbNCC.SelectedIndex == 2) && txttim.Text != null)
            {
                dtgv_thongke.DataSource = laydsncc(txttim.Text);
            }
        }
        private void comboBox_Click(object sender, EventArgs e)
        {
            setindexselectcbb(sender.GetHashCode());
            cbxemthongke.Checked = false;
        }

        private void txttim_Click(object sender, EventArgs e)
        {
            if (string.Compare("Tìm Mã,Tên,DC,SDT...", txttim.Text) == 0 || string.Compare("Tìm Mã,Tên,NCC...", txttim.Text) == 0 || string.Compare("Tìm Mã,Tên KH...", txttim.Text) == 0 || string.Compare("Tìm Mã ĐH/KH...", txttim.Text) == 0 || string.Compare("Tìm Mã/Tên...", txttim.Text) == 0 || string.Compare("Tìm mã DH/mã Vạch...", txttim.Text) == 0 || string.Compare("Tìm Mã/Tên/Địa chỉ/SDT Khách...", txttim.Text) == 0)
            {
                txttim.Text = null;
            }
        }
        //hàm cập thông kê cơ bản ở đầu from
        void dtlb()
        {
            DateTime d1 = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime d2 = Convert.ToDateTime(dateTimePicker2.Text);
            if (ktrangay(d1, d2))
            {
                if (getdsDH_datetime(1, d1, d2).Rows.Count != 0)
                {
                    lbdaban.Text = "Đã bán được " + getcoutDH(1).ToString() + " đơn hàng";
                    lbthudc.Text = "Lãi " + (gettongtiendh_giabanra(1, d1, d2) - gettongtiendh_gianhap(1, d1, d2)).ToString() + " đ";
                }
                else
                {
                    lbdaban.Text = "Đang Ế";
                    lbthudc.Text = "Chưa ai mở hàng";
                }
            }
        }
        private void cbxemthongke_Click(object sender, EventArgs e)
        {

            setindexselectcbb(-1);
            if (cbxemthongke.Checked == true)
            {
                dtgv_thongke.DataSource = getdsDH(1);
                btntim.Text = "Xem Đơn Hàng";
                btntim.AutoSize = true;
                dtlb();
                txttim.Enabled = false;
                cbdonhang.Enabled = true;
            }
            else
            {
                txttim.Enabled = true;
                cbdonhang.Enabled = false;
            }
        }
        private void cbbKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbKH.SelectedIndex == 1)
            {
                DataTable dt = getKH();
                dtgv_thongke.DataSource = dt;
                btntim.Text = "Tìm";
                txttim.Text = "Tìm Mã/Tên/Địa chỉ/SDT Khách...";
            }
            if (cbbKH.SelectedIndex == 2)
            {
                dtgv_thongke.DataSource = getKH();
                EP.SetError(txttim, "Mã/Tên/Địa chỉ/SDT");
                txttim.Text = "Tìm Mã/Tên/Địa chỉ/SDT Khách...";
                btntim.Text = "Tìm";
                btntim.AutoSize = true;

            }
        }
        private void cbbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            EP.SetError(txttim, null);
            if (cbbHH.SelectedIndex == 1)
            {
                dtgv_thongke.DataSource = laydssp_user();
                txttim.Text = "Tìm Mã/Tên...";
                btntim.Text = "Tìm";
            }
            if (cbbHH.SelectedIndex == 2 && txttim.Text != null)
            {
                EP.SetError(txttim, "Mã/Tên...");
                dtgv_thongke.DataSource = laydssp_user();
                txttim.Text = "Tìm Mã/Tên...";
                btntim.Text = "Tìm";
                btntim.AutoSize = true;
            }
            if (cbbHH.SelectedIndex == 3)
            {
                dtgv_thongke.DataSource = laydssp_user_hangton(1, 1, new DateTime(2001, 1, 1));
            }
            if (cbbHH.SelectedIndex == 4)
            {
                dtgv_thongke.DataSource = laydssp_user_hangton(0, 1, DateTime.Now);
            }
            if (cbbHH.SelectedIndex == 5)
            {
                dtgv_thongke.DataSource = laydssp_user_hangton(1, 1, DateTime.Now);
            }
            if (cbbHH.SelectedIndex == 6)
            {
                dtgv_thongke.DataSource = laydssp_user_hangton(1, 0, DateTime.Now);
            }
            if (cbbHH.SelectedIndex == 7)
            {
                dtgv_thongke.DataSource = hangbanchay();
                this.dtgv_thongke.Sort(this.dtgv_thongke.Columns["DaBan"], ListSortDirection.Descending);
            }
            if (cbbHH.SelectedIndex == 8)
            {
                dtgv_thongke.DataSource = hangbie();
            }
        }
        private void cbbDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            EP.SetError(dateTimePicker2, null);
            if (cbbDH.SelectedIndex == 1)
            {
                dtgv_thongke.DataSource = getdsalldh(new DateTime(2001, 1, 1), new DateTime(2030, 12, 12));
            }
            if (cbbDH.SelectedIndex == 2)
            {
                dtgv_thongke.DataSource = getdsDH(1);
            }
            if (cbbDH.SelectedIndex == 3)
            {
                dtgv_thongke.DataSource = getdsDH(0);
            }
            if (cbbDH.SelectedIndex == 4)
            {
                dtgv_thongke.DataSource = getdsalldh(new DateTime(2001, 1, 1), new DateTime(2030, 12, 12));
                EP.SetError(txttim, "Tìm Mã,Tên...");
                btntim.Text = "Tìm Mã,Tên KH...";
                txttim.Enabled = true;
            }
            if (cbbDH.SelectedIndex == 5)
            {
                dtgv_thongke.DataSource = getdsalldh(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                EP.SetError(dateTimePicker2, "Chọn móc thời");
            }
            if (cbbDH.SelectedIndex != 4 && cbbDH.SelectedIndex != 0)
            {
                btntim.Text = "Xem Đơn Hàng";
                btntim.AutoSize = true;
                txttim.Enabled = false;
                cbxemthongke.Checked = true;
                txttim.Clear();
                cbdonhang.Enabled = true;
            }
        }
        private void cbbLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            EP.SetError(txttim, null);
            if (cbbLH.SelectedIndex == 1)
            {
                dtgv_thongke.DataSource = laydsloahang(" ");
                btntim.Text = "Tìm";
                txttim.Text = "Tìm Mã,Tên,NCC...";
            }
            if (cbbLH.SelectedIndex == 2)
            {
                dtgv_thongke.DataSource = laydsloahang(" ");
                btntim.Text = "Tìm";
                txttim.Text = "Tìm Mã,Tên,NCC...";
                EP.SetError(txttim, "Tìm Mã,Tên,Tên NCC...");
            }
        }
        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            EP.SetError(txttim, null);
            if (cbbNCC.SelectedIndex == 1)
            {
                dtgv_thongke.DataSource = laydsncc(" ");
                btntim.Text = "Tìm";
                txttim.Text = "Tìm Mã,Tên,DC,SDT...";
            }
            if (cbbNCC.SelectedIndex == 2)
            {
                dtgv_thongke.DataSource = laydsncc(" ");
                btntim.Text = "Tìm";
                txttim.Text = "Tìm Mã,Tên,DC,SDT...";
                EP.SetError(txttim, "Tìm Mã,Tên,DC,SDT...");
            }
        }
        private void frmthongke_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

















        private void cbbselect()
        {
            for (int i = 0; i < arrcbb.Length; i++)
            {
                if (arrcbb[i].SelectedIndex != 0)
                {
                    btninds.Enabled = true;
                }
            }
        }
        //hàm lấy danh sách nhà cung cấp có tìm kiếm
        private DataTable laydsncc(string key)
        {
            string key2 = "%" + key + "%";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select * from NhaCungcap " +
                    "where MaNCC like '%" + key + "%' or TenCTy like '%" + key + "%' or DC like '%" + key + "%' or Sdt like '%" + key + "%'";
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
            return dt;
        }
        //hàm lấy danh loại hàng có tìm kiếm
        private DataTable laydsloahang(string key)
        {
            string key2 = "%" + key + "%";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select MaLH,TenLH,NhaCungCap.TenCTy from LoaiHang inner join NhaCungcap on NhaCungcap.MaNCC = LoaiHang.MaNCC " +
                    " where MaLH like '%" + key + "%' or TenLH like '%" + key + "%' or NhaCungcap.TenCTy like '%" + key + "%'";
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
            return dt;
        }
        //hàm lấy danh sách đơn hàng theo mã, tên khách hàng
        private DataTable laydsdh_kh(string key)
        {
            string key2 = "%" + key + "%";
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select DonHang.*,dbo.tongdagiam(DonHang.MaDH) as'TongTien' from DonHang inner join KhachHang on KhachHang.MaKH = DonHang.MaKH" +
                    " where KhachHang.MaKH = '" + key + "' or KhachHang.TenKH like '" + key2 + "'";
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
            return dt;
        }
        //hàm trả tất cả các combobox về selectindex = 0
        public void setindexselectcbb(int index)
        {
            for (int i = 0; i < arrcbb.Length; i++)
            {
                if (arrcbb[i].GetHashCode() != index)
                {
                    arrcbb[i].Text = "";
                }
            }

        }
        //hàm lấy danh sách đơn hàng 
        public DataTable getdsDH(int chotdon)
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

            }
            catch (Exception e)
            {
                MessageBox.Show("đọc không được dữ liệu " + e.Message);
            }
            finally
            {
                connect.Close();
            }
            return dtDonhang;
        }
        //hàm lấy tất cả đơn hàng
        public DataTable getdsalldh(DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select *,dbo.tongdagiam(MaDH) as'TongTien' from DonHang"
                    + " where NgayDatHang <= '" + d2.ToString("yyyy-MM-dd") + "' and NgayDatHang >= '" + d1.ToString("yyyy-MM-dd") + "'";
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
            return dt;
        }
        //hàm lấy danh sách đơn hàng theo móc thời gian
        public DataTable getdsDH_datetime(int chotdon, DateTime d1, DateTime d2)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select*,dbo.SL_hang(MaDH)as 'SoLuong',dbo.tongdagiam(MaDH) as'TongTien'"
                    + " from DonHang"
                    + " where ChotDon = " + chotdon + "and NgayDatHang <= '" + d2.ToString("yyyy-MM-dd") + "' and NgayDatHang >= '" + d1.ToString("yyyy-MM-dd") + "'";
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
            return dt;
        }



        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //hàm kiểm tra ngày
        private bool ktrangay(DateTime d1, DateTime d2)
        {
            if (DateTime.Compare(d1, d2) > 0)
            {
                MessageBox.Show("Chọn lại móc thời gian hiển thị...");
                return false;
            }
            return true;
        }

        //hàm lấy số lượng đơn hàng
        private int getcoutDH(int chotdon)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select count(MaDH) from DonHang where ChotDon = " + chotdon;
                lenh.Connection = connect;

                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi getcoutDH" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
        }
        //hàm tính tổng tiền với giá bán ra
        private int gettongtiendh_giabanra(int chotdon, DateTime d1, DateTime d2)
        {
            int tong = 0;
            SqlCommand lenh = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                for (int i = 0; i < getdsDH_datetime(chotdon, d1, d2).Rows.Count; i++)
                {
                    DataTable dt = new DataTable();
                    string x = getdsDH_datetime(chotdon, d1, d2).Rows[i].ItemArray[0].ToString();
                    lenh.CommandText = "select dbo.tongtien_hang_banra(" + x + ")";
                    lenh.Connection = connect;

                    da.SelectCommand = lenh;
                    da.Fill(dt);
                    int g = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                    tong += g;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gettongtiendh_giabanra " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return tong;
        }
        //hàm tính tổng tiền đh theo giá nhập
        private int gettongtiendh_gianhap(int chotdon, DateTime d1, DateTime d2)
        {
            int tong = 0;
            SqlCommand lenh = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                for (int i = 0; i < getdsDH_datetime(chotdon, d1, d2).Rows.Count; i++)
                {
                    DataTable dt = new DataTable();
                    lenh.CommandText = "select dbo.tongtien_hang_nhapvao('" + getdsDH_datetime(chotdon, d1, d2).Rows[i].ItemArray[0].ToString() + "')";
                    lenh.Connection = connect;

                    da.SelectCommand = lenh;
                    da.Fill(dt);
                    tong += Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gettongtiendh_gianhap " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return tong;
        }

        //hàm lấy hàng trong đơn hàng
        private DataTable getdsctdh_dh(int MaDH)
        {
            if (MaDH != -1)
            {
                DataTable dt = new DataTable();
                try
                {

                    SqlCommand lenh = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter();
                    lenh.CommandText = "select CT.MaHang,H.TenHang,H.giabanra,CT.Soluong,L.TenLH,N.TenCTy,H.ngayhethang " +
                        "from ChiTietDonHang CT,MatHang H, LoaiHang L, NhaCungcap N " +
                        "where CT.MaDH = " + MaDH +
                        "and H.TenHang in (select TenHang from MatHang where MaHang = CT.MaHang) " +
                        "and L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH) " +
                        "and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC) ";
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
                return dt;
            }
            return new DataTable();
        }
        //hàm tìm kiếm khách hàng theo mã,tên,địa chỉ,sdt
        private DataTable timkiemKH(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                string key2 = "%" + key + "%";
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select * from KhachHang where MaKH like '" + key + "' or TenKH like '" + key2 + "' or DC like '" + key2 + "' or Sdt like '" + key + "'";
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 123" + ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }
        //hàm kiểm tra chuỗi x có pải là 1 dãy số
        private bool ktraso(string x)
        {
            x = x.Trim();
            if (x.Length > 0)
            {

                for (int i = 0; i < x.Length; i++)
                {
                    if (!char.IsDigit(x[i]))
                    {
                        MessageBox.Show("Nhập lại mã");
                        return false;
                    }
                }
                return true;
            }
            return false;
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
        //tìm kím sản phẩm theo mã, tên
        private DataTable laydssp_user_key(string key)
        {
            DataTable dt = new DataTable();
            try
            {
                string key2 = "%" + key.Trim() + "%";
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select H.MaHang,H.TenHang,H.giabanra,H.soluong,L.TenLH,N.TenCTy,H.ngayhethang" +
                    " from MatHang H,LoaiHang L, NhaCungcap N" +
                    " where (H.MaHang like '" + key2 + "' or H.TenHang like N'" + key2 + "')" +
                    " and L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH)" +
                    " and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC)  ";
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
            return dt;
        }
        //hàm lấy tên hàng theo mã hàng
        private string laytenhang(string mahang)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select TenHang from MatHang where MaHang = '" + mahang + "'";
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi laytenhang" + ex.Message);
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].ItemArray[0].ToString();
            }
            return null;
        }
        //hàm lấy danh sách hàng bán chạy
        private DataTable hangbanchay()
        {
            DataTable tenhang = new DataTable();
            DataTable daloc = new DataTable();
            DataTable top20 = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select Distinct MaHang from ChiTietDonHang";
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(tenhang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tenhang" + ex.Message);
            }
            top20.Columns.Add("MaHang", typeof(string));
            top20.Columns.Add("TenHang", typeof(string));
            top20.Columns.Add("DaBan", typeof(int));
            daloc.Columns.Add("MaHang", typeof(string));
            daloc.Columns.Add("TenHang", typeof(string));
            daloc.Columns.Add("DaBan", typeof(int));
            for (int i = 0; i < tenhang.Rows.Count; i++)
            {
                if (demsl(tenhang.Rows[i].ItemArray[0].ToString()) > 0)
                {
                    daloc.Rows.Add(tenhang.Rows[i].ItemArray[0].ToString(), laytenhang(tenhang.Rows[i].ItemArray[0].ToString()), demsl(tenhang.Rows[i].ItemArray[0].ToString()));
                }
            }
            daloc.DefaultView.Sort = "DaBan ASC";
            for (int i = 0; i < daloc.Rows.Count; i++)
            {
                top20.Rows.Add(daloc.Rows[i].ItemArray[0], daloc.Rows[i].ItemArray[1], daloc.Rows[i].ItemArray[2]);
            }
            top20.DefaultView.Sort = "DaBan ASC";
            return daloc;
        }
        //hàm lấy danh sách chi tiết đơn hàng
        private DataTable getdsctdh()
        {
            DataTable ctdh = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select * from ChiTietDonHang";
                lenh.Connection = connect;
                da.SelectCommand = lenh;
                da.Fill(ctdh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CTDH" + ex.Message);
            }
            return ctdh;
        }
        //hàm đêm số lượng đã bán 
        private int demsl(string mahang)
        {
            int dem = 0;
            string dhcu = "";
            for (int i = 0; i < getdsctdh().Rows.Count; i++)
            {
                if (string.Compare(getdsctdh().Rows[i].ItemArray[1].ToString(), mahang) == 0 && string.Compare(getdsctdh().Rows[i].ItemArray[0].ToString(), dhcu) != 0)
                {
                    dhcu = getdsctdh().Rows[i].ItemArray[0].ToString();
                    dem += Convert.ToInt32(getdsctdh().Rows[i].ItemArray[2].ToString());
                }
            }
            return dem;
        }
        // hàm lấy danh sách hàng tồn theo số lượng và móc thời gian
        private DataTable laydssp_user_hangton(int chieusl, int chieudt, DateTime d1)
        {
            string chieusssl = chieusl == 1 ? ">" : "<=";
            string chieussdt = chieudt == 1 ? ">" : "<=";

            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select H.MaHang,H.TenHang,H.giabanra,H.soluong,L.TenLH,N.TenCTy,H.ngayhethang" +
                    " from MatHang H,LoaiHang L, NhaCungcap N" +
                    " where H.soluong " + chieusssl + " 0 and H.ngayhethang" + chieussdt + "'" + d1.ToString("yyyy-MM-dd") + "'" +
                    " and L.TenLH in (select LoaiHang.TenLH from LoaiHang where MaLH = H.MaLH)" +
                    " and N.TenCTy in (select TenCTy from NhaCungcap where MaNCC like H.MaNCC)  ";
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
            return dt;
        }
        //hàm lấy danh sách khách hàng
        private DataTable getKH()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select * from KhachHang";
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
            return dt;
        }

        // hàm lấy số lượng hàng trong đơn hàng
        private int slhang_DH(int maDH)
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
                    return Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                }
                return 0;
            }
            return -1;
        }

        //hàm lấy danh sách hàng bị ế
        private DataTable hangbie()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand lenh = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                lenh.CommandText = "select MaHang,TenHang,giabanra,soluong,LoaiHang.TenLH,NhaCungcap.TenCTy,ngayhethang from MatHang inner join LoaiHang on MatHang.MaLH = LoaiHang.MaLH inner join NhaCungcap on MatHang.MaNCC = NhaCungcap.MaNCC where MaHang not in (select MaHang from ChiTietDonHang)";
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
            return dt;
        }

        private void dtgv_thongke_DataSourceChanged(object sender, EventArgs e)
        {
            if (dtgv_thongke.Rows.Count > 1)
            {
                btninds.Enabled = true;
                btntim.Enabled = true;
            }
            else
            {
                btntim.Enabled = false;
                btninds.Enabled = false;
            }
        }
    }
}
