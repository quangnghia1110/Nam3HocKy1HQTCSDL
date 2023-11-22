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
    public partial class ChiTietPhieuNhap : Form
    {
        MyConnect myconn = new MyConnect();
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void lbl_HeaderTab1PNK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_PhieuNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_ChiTietPhieuNhapKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_ChiTietPhieuNhapKho.DataSource = dt;
                conn.Close();
            }
        }

        private void Reset()
        {
            txt_MaLT.ResetText();
            txt_MaNK.ResetText();
            txt_SoLuongSP.ResetText();
            txt_ThanhTienTungSP.ResetText();
            txt_ThueVAT.ResetText();
            txt_GiaNhapTungSP.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietPhieuNhap", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_ChiTietPhieuNhapKho.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Them_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaLT.Text}', '{txt_MaNK.Text}', '{txt_SoLuongSP.Text}', {txt_GiaNhapTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Insert' ", myconn.getConnection);
                if(cmd.ExecuteNonQuery() > 0)
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

        private void btn_Sua_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaLT.Text}', '{txt_MaNK.Text}', '{txt_SoLuongSP.Text}', {txt_GiaNhapTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Update' ", myconn.getConnection);
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

        private void btn_Xoa_PhieuNhapKho_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseChiTietPhieuNhap '{txt_MaLT.Text}', '{txt_MaNK.Text}', '{txt_SoLuongSP.Text}', {txt_GiaNhapTungSP.Text}, N'{txt_ThueVAT.Text}', '{txt_ThanhTienTungSP.Text}', 'Delete' ", myconn.getConnection);
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

        private void dgv_ChiTietPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLT.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[0].Value.ToString();
            txt_MaNK.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuongSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[2].Value.ToString();
            txt_GiaNhapTungSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[3].Value.ToString();
            txt_ThueVAT.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[4].Value.ToString();
            txt_ThanhTienTungSP.Text = dgv_ChiTietPhieuNhapKho.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
