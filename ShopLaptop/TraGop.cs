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
    public partial class TraGop : Form
    {
        MyConnect myconn = new MyConnect();
        public TraGop()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TraGop", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_TraGop.DataSource = dataTable;
            Reset();
            myconn.closeConnection();
        }
        private void Reset()
        {
            txt_MaHD.ResetText();
            txt_MaKH_HD.ResetText();
            txt_LaiSuatHangThang.ResetText();
            txt_TienTraTruoc_HD.ResetText();
            txt_TienConLai_TG.ResetText();
            txt_ThoiGianTraGop.ResetText();
            Date_NgayBatDau.Value = DateTime.Now;
        }
        private void txt_TimKiem_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_OptionsHD_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_TraGop_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
        }

        

        

        private void btn_Them_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', {txt_LaiSuatHangThang.Text}, {txt_TienTraTruoc_HD.Text}, {txt_TienConLai_TG.Text}, {txt_ThoiGianTraGop.Text}, '{Date_NgayBatDau.Value}', 'INSERT' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin trả góp cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }
        private void btn_Sua_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', {txt_LaiSuatHangThang.Text}, {txt_TienTraTruoc_HD.Text}, {txt_TienConLai_TG.Text}, {txt_ThoiGianTraGop.Text}, '{Date_NgayBatDau.Value}', 'UPDATE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin trả góp cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }
        private void btn_Xoa_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseTraGop '{txt_MaHD.Text}', '{txt_MaKH_HD.Text}', {txt_LaiSuatHangThang.Text}, {txt_TienTraTruoc_HD.Text}, {txt_TienConLai_TG.Text}, {txt_ThoiGianTraGop.Text}, '{Date_NgayBatDau.Value}', 'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin trả góp cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }
        private void dgv_TraGop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHD.Text = dgv_TraGop.CurrentRow.Cells[0].Value.ToString();
            txt_MaKH_HD.Text = dgv_TraGop.CurrentRow.Cells[1].Value.ToString();
            txt_LaiSuatHangThang.Text = dgv_TraGop.CurrentRow.Cells[2].Value.ToString();
            txt_TienTraTruoc_HD.Text = dgv_TraGop.CurrentRow.Cells[3].Value.ToString();
            txt_TienConLai_TG.Text = dgv_TraGop.CurrentRow.Cells[4].Value.ToString();
            txt_ThoiGianTraGop.Text = dgv_TraGop.CurrentRow.Cells[5].Value.ToString();
            Date_NgayBatDau.Value = Convert.ToDateTime(dgv_TraGop.CurrentRow.Cells[6].Value);
        }

        private void btn_TimKiem_TraGop_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            SqlCommand cmd = new SqlCommand("Select * From func_SearchTraGop(@MaHD, @MaKH, @LaiSuat)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@MaHD", txt_TimKiem_MaHD.Text);
            cmd.Parameters.AddWithValue("@MaKH", txt_Tk_MaKH.Text);
            cmd.Parameters.AddWithValue("@LaiSuat", txt_TK_LaiSuat.Text);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv_TraGop.DataSource = dt;
            myconn.closeConnection();
        }

        private void tab_Option_TraGop_Click(object sender, EventArgs e)
        {

        }

    }
}
