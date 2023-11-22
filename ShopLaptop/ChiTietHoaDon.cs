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
namespace ShopLaptop
{
    public partial class ChiTietHoaDon : Form
    {
        MyConnect myconn = new MyConnect();
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void btn_Show_ChiTietHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_ChiTietHD.DataSource = dt;
                conn.Close();
            }
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_ChiTietHD.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MaHD.ResetText();
            txt_SoLuongSP.ResetText();
            txt_ThanhTienTungSP.ResetText();
            txt_KhuyenMai.ResetText();
            txt_ThueVAT.ResetText();
            txt_GiaBanTungSP.ResetText();
        }

        private void btn_Them_CTHD_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaLT.Text}', '{txt_MaHD.Text}', '{txt_SoLuongSP.Text}', {txt_GiaBanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Insert' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Sua_CTHD_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaLT.Text}', '{txt_MaHD.Text}', '{txt_SoLuongSP.Text}', {txt_GiaBanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Update' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Xoa_CTHD_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietHoaDon '{txt_MaLT.Text}', '{txt_MaHD.Text}', '{txt_SoLuongSP.Text}', {txt_GiaBanTungSP.Text}, '{txt_ThueVAT.Text}', '{txt_KhuyenMai.Text}', '{txt_ThanhTienTungSP.Text}', 'Delete' ", myconn.getConnection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void dgv_ChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLT.Text = dgv_ChiTietHD.CurrentRow.Cells[0].Value.ToString();
            txt_MaHD.Text = dgv_ChiTietHD.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuongSP.Text = dgv_ChiTietHD.CurrentRow.Cells[2].Value.ToString();
            txt_GiaBanTungSP.Text = dgv_ChiTietHD.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_ChiTietHD.CurrentRow.Cells[4].Value.ToString();
            txt_KhuyenMai.Text = dgv_ChiTietHD.CurrentRow.Cells[5].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_ChiTietHD.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
