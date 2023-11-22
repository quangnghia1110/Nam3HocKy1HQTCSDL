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

namespace ShopLaptop
{
    public partial class PhieuNhapKho : Form
    {
        MyConnect myconn=new MyConnect();
        public PhieuNhapKho()
        {
            InitializeComponent();
        }

        //hiển thị danh sách phiếu nhập kho
        private void btn_Show_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhapKho", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }

        //tìm kiếm phiếu nhập kho dựa vào ngày nhập kho
        private void btn_TimKiem_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemPhieuNhapKho(@NgayNhapKho)", conn);
                cmd.Parameters.AddWithValue("@NgayNhapKho", dt_TimKiem_PNK.Value);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_PhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }
        private void Reset()
        {
            txt_MaNK.ResetText();
            txt_MaNCC_PNK.ResetText();
            txt_MaNV_PNK.ResetText();
            txt_SoTienThanhToan_PNK.ResetText();
            txt_TrangThaiThanhToan_PNK.ResetText();
            txt_PhuongThucThanhToan_PNK.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhapKho", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_PhieuNhapKho.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Them_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC_PNK.Text}', '{txt_MaNV_PNK.Text}', {txt_SoTienThanhToan_PNK.Text}, N'{txt_PhuongThucThanhToan_PNK.Text}', N'{txt_TrangThaiThanhToan_PNK.Text}', 'INSERT' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Sua_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC_PNK.Text}', '{txt_MaNV_PNK.Text}', {txt_SoTienThanhToan_PNK.Text}, N'{txt_PhuongThucThanhToan_PNK.Text}', N'{txt_TrangThaiThanhToan_PNK.Text}', 'UPDATE' ", myconn.getConnection);
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

        private void btn_Xoa_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_RevisePhieuNhapKho '{txt_MaNK.Text}', '{txt_MaNCC_PNK.Text}', '{txt_MaNV_PNK.Text}', {txt_SoTienThanhToan_PNK.Text}, N'{txt_PhuongThucThanhToan_PNK.Text}', N'{txt_TrangThaiThanhToan_PNK.Text}', 'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void dgv_PhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNCC_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_MaNV_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_SoTienThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_PhuongThucThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
            txt_TrangThaiThanhToan_PNK.Text = dgv_PhieuNhapKho.CurrentRow.Cells[6].Value.ToString();
        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
