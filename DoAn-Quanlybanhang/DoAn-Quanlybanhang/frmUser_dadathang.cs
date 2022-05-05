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
    public partial class frmUser_dadathang : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");
        string tenkh = "", MaDH = "";
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public frmUser_dadathang()
        {
            InitializeComponent();
        }
        public frmUser_dadathang(frmUser_dathang frm, string ten, string maDH)
        {
            tenkh = ten; MaDH = maDH;
            InitializeComponent();
        }
        // hàm lấy dữ liệu sql lên để in hóa đơn
        private void btnxeminhoadon_Click(object sender, EventArgs e)
        {
            lenh.CommandText = "Select DonHang.MaKH, KhachHang.TenKH, KhachHang.DC, KhachHang.Sdt, KhachHang.Email, ChiTietDonHang.MaHang,TenHang,giabanra,ChiTietDonHang.Soluong,LoaiHang.TenLH,NhaCungCap.TenCTy,ngayhethang,ChiTietDonHang.MaDH,DonHang.maVoucher,dbo.tongdagiam(ChiTietDonHang.MaDH)as'TongTien'"
                + " from ChiTietDonHang Inner Join MatHang On ChiTietDonHang.MaHang = MatHang.MaHang"
                + " Inner Join LoaiHang On MatHang.MaLH = LoaiHang.MaLH"
                + " Inner Join NhaCungCap On NhaCungCap.MaNCC = MatHang.MaNCC"
                + " Inner Join DonHang On ChiTietDonHang.MaDH = DonHang.MaDH"
                + " Inner Join KhachHang On KhachHang.MaKH = DonHang.MaKH"
                + " Where ChiTietDonHang.MaDH = @MaDH";
            lenh.Parameters.Clear();
            lenh.Parameters.AddWithValue("@MaDH", MaDH);
            lenh.Connection = connect;

            da.SelectCommand = lenh;
            DataTable dt = new DataTable("bangHOADON");
            da.Fill(dt);
            crhoadon hoadon = new crhoadon();
            hoadon.SetDataSource(dt);

            frmHoaDon f = new frmHoaDon();
            f.crystalReportViewer1.ReportSource = hoadon;
            f.ShowDialog();
            
        }

        private void btntiptucmuasam_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUser_dadathang_Load(object sender, EventArgs e)
        {
            label1.Text = "Rất cảm ơn (Anh/ Chị) " + tenkh + " \nđã ghé shop em!!!";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
