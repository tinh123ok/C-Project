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
    public partial class frmNhaCungcap : Form
    {
        public frmNhaCungcap()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=TINH✓\\SQLEXPRESS2012;Initial Catalog=QuanLy_BanHang;Integrated Security=True");


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktratrungma(txtMancc.Text) && ktrasdt(txtSdt.Text) && ktraemail(txtEmail.Text) && txtdiachi.Text.Trim() != null && txtTenncc.Text.Trim() != null)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdThem = new SqlCommand("sp_ThemNCC", connect);
                    cmdThem.CommandType = CommandType.StoredProcedure;
                    cmdThem.CommandText = "sp_ThemNCC";
                    SqlParameter parama = new SqlParameter("@mancc", txtMancc.Text);
                    cmdThem.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@tenncc", txtTenncc.Text);
                    cmdThem.Parameters.Add(paraten);
                    SqlParameter paradiachi = new SqlParameter("@diachi", txtdiachi.Text);
                    cmdThem.Parameters.Add(paradiachi);
                    SqlParameter paraemail = new SqlParameter("@email", txtEmail.Text);
                    cmdThem.Parameters.Add(paraemail);
                    SqlParameter parasdt = new SqlParameter("@sodienthoai", txtSdt.Text);
                    cmdThem.Parameters.Add(parasdt);

                    if (cmdThem.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("không thêm được");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi: ", ex.Message);//lỗi âu m

                }
                finally
                {
                    connect.Close();
                    dtgvNCC.DataSource = laydsNhacungcap();
                }
            }
        }


        private void frmNhaCungcap_Load(object sender, EventArgs e)
        {
            dtgvNCC.DataSource = laydsNhacungcap();
            dtgvNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dtgvNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dtgvNCC.Columns[2].HeaderText = "Địa chỉ";
            dtgvNCC.Columns[3].HeaderText = "Email";
            dtgvNCC.Columns[4].HeaderText = "Số điện thoại";


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dtgvNCC.CurrentCell.RowIndex;
                txtMancc.Text = dtgvNCC.Rows[dong].Cells[0].Value.ToString();
                txtTenncc.Text = dtgvNCC.Rows[dong].Cells[1].Value.ToString();
                txtdiachi.Text = dtgvNCC.Rows[dong].Cells[2].Value.ToString();
                txtEmail.Text = dtgvNCC.Rows[dong].Cells[3].Value.ToString();
                txtSdt.Text = dtgvNCC.Rows[dong].Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message + "thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn muốn Sữa nội dung Nhà cung cấp này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (txtMancc.Text.Trim() != null && ktrasdt(txtSdt.Text) && ktraemail(txtEmail.Text) && txtdiachi.Text.Trim() != null && txtTenncc.Text.Trim() != null && h == DialogResult.Yes)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmdThem = new SqlCommand("sp_SuaNhacungcap", connect);
                    cmdThem.CommandType = CommandType.StoredProcedure;
                    cmdThem.CommandText = "sp_SuaNhacungcap";
                    SqlParameter parama = new SqlParameter("@mancc", txtMancc.Text);
                    cmdThem.Parameters.Add(parama);
                    SqlParameter paraten = new SqlParameter("@tenncc", txtTenncc.Text);
                    cmdThem.Parameters.Add(paraten);
                    SqlParameter paradiachi = new SqlParameter("@diachi", txtdiachi.Text);
                    cmdThem.Parameters.Add(paradiachi);
                    SqlParameter paraemail = new SqlParameter("@email", txtEmail.Text);
                    cmdThem.Parameters.Add(paraemail);
                    SqlParameter parasdt = new SqlParameter("@sodienthoai", txtSdt.Text);
                    cmdThem.Parameters.Add(parasdt);

                    if (cmdThem.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sữa thành công");
                    }
                    else
                    {
                        MessageBox.Show("không Sữa được");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi: ", ex.Message);//lỗi âu m

                }
                finally
                {
                    connect.Close();
                    dtgvNCC.DataSource = laydsNhacungcap();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtgvNCC.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn muốn xóa dòng này ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes && index < dtgvNCC.RowCount)
            {
                if (h == DialogResult.Yes && index != dtgvNCC.Rows.Count - 1)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmdkhoa = new SqlCommand("sp_Xoancc", connect);
                        cmdkhoa.CommandType = CommandType.StoredProcedure;
                        SqlParameter prma = new SqlParameter("@mancc", dtgvNCC.Rows[index].Cells[0].Value.ToString());
                        cmdkhoa.Parameters.Add(prma);
                        if (cmdkhoa.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xóa không được");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: ", ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                        dtgvNCC.DataSource = laydsNhacungcap();
                    }
                }

            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text.Trim() != null)
            {
                string x = "%" + txtTimkiem.Text.Trim() + "%";
                dtgvNCC.DataSource = timNhacungcap(x);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "Nhập mã nhà cung cấp...";
            dtgvNCC.DataSource = laydsNhacungcap();
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
        }
        //hàm tìm kiếm nhà cung cấp theo tên, mã,dc
        private DataTable timNhacungcap(string x)
        {
            string x1 = "%" + x + "%";
            DataTable dtbNhacungcap = null;
            try
            {
                connect.Open();
                SqlCommand cmdThem = new SqlCommand("sp_timkiemncc", connect);
                cmdThem.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@tenncc", x1);
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
        //hàm lấy danh sách nhà cung cấp
        private DataTable laydsNhacungcap()
        {
            DataTable dtbNhacungcap = null;
            try
            {
                connect.Open();
                SqlCommand cmdnhacungcap = new SqlCommand("sp_LaydsNhaCungCap", connect);
                cmdnhacungcap.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dtaMonhoc = new SqlDataAdapter(cmdnhacungcap);
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
        //hàm kiểm tra trùng mã
        private bool ktratrungma(string x)
        {
            x = x.Trim();
            if (x.Length > 0)
            {
                for (int i = 0; i < dtgvNCC.Rows.Count; i++)
                {
                    if (string.Compare(dtgvNCC.Rows[i].Cells[0].Value.ToString(), x) == 0)
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
        //hàm kiểm tra email
        private bool ktraemail(string x)
        {
            if (x.Trim().Length > 0 && x.Contains("@"))
            {
                return true;
            }
            MessageBox.Show("nhập lại email");
            return false;
        }
        //hàm kiểm tra số điện thoại
        private bool ktrasdt(string x)
        {
            if (x[0] == '0')
            {
                if (x.Length == 10 || x.Length == 11)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (!char.IsDigit(x[i]))
                        {
                            MessageBox.Show("Nhập lại số điện thoại");
                            return false;
                        }
                    }
                    return true;
                }
            }
            MessageBox.Show("Nhập lại số điện thoại");
            return false;
        }

        private void frmNhaCungcap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimkiem.PerformClick();
            }
        }
    }
}

