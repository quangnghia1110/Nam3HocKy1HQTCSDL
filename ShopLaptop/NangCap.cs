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
    public partial class NangCap : Form
    {
        MyConnect myconn = new MyConnect();
        public NangCap()
        {
            InitializeComponent();
        }

        private void LoadDataGoiNangCap()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GoiNangCap", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_GoiNangCap.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void LoadDataHDNC()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoatDongNangCap", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_HoatDongNangCap.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Show_GoiNangCap_Click(object sender, EventArgs e)
        {
            LoadDataGoiNangCap();
        }
        private void btn_Show_HoatDongNangCap_Click(object sender, EventArgs e)
        {
            LoadDataHDNC();
        }
        private void ResetGoiNangCap()
        {
            txt_MaGoiNangCap.ResetText();
            txt_TenGoiNC.ResetText();
            txt_PhiNC.ResetText();
        }
        private void ResetHDNC()
        {
            txt_MaNV_HDNC.ResetText();
            txt_MaKH_HDNC.ResetText();
            txt_MaGoi_HDNC.ResetText();
        }
        private void dgv_GoiNangCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGoiNangCap.Text = dgv_GoiNangCap.CurrentRow.Cells[0].Value.ToString();
            txt_TenGoiNC.Text = dgv_GoiNangCap.CurrentRow.Cells[1].Value.ToString();
            txt_PhiNC.Text = dgv_GoiNangCap.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgv_HoatDongNangCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV_HDNC.Text = dgv_HoatDongNangCap.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HDNC.Text = dgv_HoatDongNangCap.CurrentRow.Cells[1].Value.ToString();
            txt_MaGoi_HDNC.Text = dgv_HoatDongNangCap.CurrentRow.Cells[2].Value.ToString();
        }
        private void btn_Them_GoiNangCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{txt_MaGoiNangCap.Text}', N'{txt_TenGoiNC.Text}', '{txt_PhiNC.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm gói nâng cấp thành công!");
                LoadDataGoiNangCap();
                ResetGoiNangCap();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            
            
        }
        private void btn_Sua_GoiNangCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{txt_MaGoiNangCap.Text}', N'{txt_TenGoiNC.Text}', '{txt_PhiNC.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa gói nâng cấp thành công!");
                LoadDataGoiNangCap();
                ResetGoiNangCap();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            
        }
        private void btn_Xoa_GoiNangCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiNangCap '{txt_MaGoiNangCap.Text}', N'{txt_TenGoiNC.Text}', '{txt_PhiNC.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa gói nâng cấp thành công!");
                LoadDataGoiNangCap();
                ResetGoiNangCap();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            
        }
        private void btn_Them_HDNC_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongNangCap '{txt_MaNV_HDNC.Text}','{txt_MaKH_HDNC.Text}','{txt_MaGoi_HDNC.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm hoạt dộng nâng cấp thành công!");
                LoadDataHDNC();
                ResetHDNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            
        }

        private void btn_Sua_HDNC_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongNangCap '{txt_MaNV_HDNC.Text}','{txt_MaKH_HDNC.Text}','{txt_MaGoi_HDNC.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa hoạt động nâng cấp thành công!");
                LoadDataGoiNangCap();
                ResetHDNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            
        }

        private void btn_Xoa_HDNC_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongNangCap '{txt_MaNV_HDNC.Text}','{txt_MaKH_HDNC.Text}','{txt_MaGoi_HDNC.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hoạt động nâng cấp thành công!");
                LoadDataHDNC();
                ResetHDNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
           
        }

        private void tbp_Infor_GoiNangCap_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_GoiNangCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand("Select * From func_SearchNangCapByID(@MaGoiNC)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaGoiNC", txt_TimKiem_GoiNangCap.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_GoiNangCap.DataSource = dt;
            myconn.closeConnection();
        }


        private void btn_TimKiem_HoatDongNangCap_Click_1(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand("Select * From func_SearHoatDongNangCap(@MaNV, @MaKH, @MaGoiBH)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", txt_TimKiem_MaNhanVien.Text);
            cmd.Parameters.AddWithValue("@MaKH", txt_TimKiem_MaKhachHang.Text);
            cmd.Parameters.AddWithValue("@MaGoiBH", txt_TimKiem_MaGoiNC.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_HoatDongNangCap.DataSource = dt;
            myconn.closeConnection();
        }
    }
}
