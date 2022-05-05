using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quanlybanhang
{
    public partial class frmNguoiquanly : Form
    {
        public frmNguoiquanly()
        {
            InitializeComponent();
        }

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            frmNhaCungcap NCC = new frmNhaCungcap();
            NCC.ShowDialog();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            frmLoaihang lh = new frmLoaihang();
            lh.ShowDialog();
        }

        private void btnMathang_Click(object sender, EventArgs e)
        {
            frmMathang mh = new frmMathang();
            mh.ShowDialog();
        }


        private void btnDsdonhang_Click(object sender, EventArgs e)
        {
            frmDonhang dh = new frmDonhang();
            dh.ShowDialog();
        }

        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            frmVoucher vc = new frmVoucher();
            vc.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void btnDHdachot_Click(object sender, EventArgs e)
        {
            frmDonhang f = new frmDonhang(1);
            f.ShowDialog();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            frmthongke f = new frmthongke();
            f.ShowDialog();
        }
    }
}
