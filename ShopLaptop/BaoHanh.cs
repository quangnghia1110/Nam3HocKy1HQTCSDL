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
    public partial class BaoHanh : Form
    {
        MyConnect myconn = new MyConnect();
        public BaoHanh()
        {
            InitializeComponent();
        }

        private void LoadDataGoiBaoHanh()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GoiBaoHanh", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_GoiBaoHanh.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void LoadDataHoatDongBaoHanh()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoatDongBaoHanh", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_HĐBH.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void btn_Show_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            LoadDataGoiBaoHanh();
        }
        private void btn_Show_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            LoadDataHoatDongBaoHanh();
        }
        private void ResetGoiBaoHanh()
        {
            txt_MaGoiBaoHanh.ResetText();
            txt_TenGoiBH.ResetText();
            txt_MoTaChiTiet.ResetText();
        }
        private void ResetHoatDongBaoHanh()
        {
            txt_MaNV.ResetText();
            txt_MaKH.ResetText();
            txt_MaGoiBHanh.ResetText();
            txt_ChiPhiSuaChua.ResetText();
            txt_SoTienHoTro.ResetText();
            txt_ThoiGianBaoHanh.ResetText();
        }
        private void dgv_GoiBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGoiBaoHanh.Text = dgv_GoiBaoHanh.CurrentRow.Cells[0].Value.ToString();
            txt_TenGoiBH.Text = dgv_GoiBaoHanh.CurrentRow.Cells[1].Value.ToString();
            txt_MoTaChiTiet.Text = dgv_GoiBaoHanh.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgv_HĐBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_HĐBH.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH.Text = dgv_HĐBH.CurrentRow.Cells[1].Value.ToString();
            txt_MaGoiBHanh.Text = dgv_HĐBH.CurrentRow.Cells[2].Value.ToString();
            txt_ChiPhiSuaChua.Text = dgv_HĐBH.CurrentRow.Cells[3].Value.ToString();
            txt_SoTienHoTro.Text = dgv_HĐBH.CurrentRow.Cells[4].Value.ToString();
            txt_ThoiGianBaoHanh.Text = dgv_HĐBH.CurrentRow.Cells[5].Value.ToString();
        }
        private void btn_Them_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{txt_MaGoiBaoHanh.Text}', N'{txt_TenGoiBH.Text}', N'{txt_MoTaChiTiet.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm gói bảo hành thành công!");
                LoadDataGoiBaoHanh();
                ResetGoiBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
           
        }
        private void btn_Sua_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{txt_MaGoiBaoHanh.Text}', N'{txt_TenGoiBH.Text}', N'{txt_MoTaChiTiet.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa gói bảo hành thành công!");
                ResetGoiBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            LoadDataGoiBaoHanh();
        }
        private void btn_Xoa_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseGoiBaoHanh '{txt_MaGoiBaoHanh.Text}', N'{txt_TenGoiBH.Text}', N'{txt_MoTaChiTiet.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa gói bảo hành thành công!");
                ResetGoiBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            LoadDataGoiBaoHanh();
        }
        private void btn_Them_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongBaoHanh '{txt_MaNV.Text}','{txt_MaKH.Text}','{txt_MaGoiBHanh.Text}', '{txt_ChiPhiSuaChua.Text}', '{txt_SoTienHoTro.Text}', '{txt_ThoiGianBaoHanh.Text}', 'Insert' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm hoạt động bảo hành thành công!");
                ResetHoatDongBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            LoadDataHoatDongBaoHanh();
        }
        private void btn_Sua_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongBaoHanh '{txt_MaNV.Text}','{txt_MaKH.Text}','{txt_MaGoiBHanh.Text}', '{txt_ChiPhiSuaChua.Text}', '{txt_SoTienHoTro.Text}', '{txt_ThoiGianBaoHanh.Text}', 'Update' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa hoạt động bảo hành thành công!");
                ResetHoatDongBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            LoadDataGoiBaoHanh();
        }
        private void btn_Xoa_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseHoatDongBaoHanh '{txt_MaNV.Text}','{txt_MaKH.Text}','{txt_MaGoiBHanh.Text}', '{txt_ChiPhiSuaChua.Text}', '{txt_SoTienHoTro.Text}', '{txt_ThoiGianBaoHanh.Text}', 'Delete' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa hoạt động bảo hành thành công!");
                ResetHoatDongBaoHanh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
            LoadDataHoatDongBaoHanh();
        }

        private void btn_TimKiem_GoiBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand("Select * From func_SearchBaoHanhByID(@MaGoiBH)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaGoiBH", txt_TimKiem_MaGoiBaoHanh.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_GoiBaoHanh.DataSource = dt;
            myconn.closeConnection();
        }

        private void btn_TimKiem_HoatDongBaoHanh_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand("Select * From func_SearHoatDongBaoHanh(@MaNV, @MaKH, @MaGoiBH)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaNV", txt_TimKiem_MaNhanVien.Text);
            cmd.Parameters.AddWithValue("@MaKH", txt_TimKiem_MaKhachHang.Text);
            cmd.Parameters.AddWithValue("@MaGoiBH", txt_TimKiem_MaGoiBH.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_HĐBH.DataSource = dt;
            myconn.closeConnection();
        }
    }
}

