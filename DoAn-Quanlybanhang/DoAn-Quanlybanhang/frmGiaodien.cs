using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quanlybanhang
{
    public partial class frmGiaodien : Form
    {
        public frmGiaodien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGiaodien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            frmDangnhap login = new frmDangnhap();
            login.ShowDialog();
        }

        private void btnNguoimua_Click(object sender, EventArgs e)
        {
            frmUser_chinh f = new frmUser_chinh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        
    }
}
