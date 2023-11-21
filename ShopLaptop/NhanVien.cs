using FontAwesome.Sharp;
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
//using System.Data.SqlClient;

namespace ShopLaptop
{
    public partial class NhanVien : Form
    {
        MyConnect myconn=new MyConnect();
        public NhanVien()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txt_MaNV.ResetText();
            txt_HoTenNV.ResetText();
            txt_SDTNV.ResetText();
            txt_TrangThaiTaiKhoanNV.ResetText();
            txt_EmailNV.ResetText();
            txt_PasswordNV.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnectionAdmin();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", myconn.getConnectionAdmin);
            dataTable.Load(cmd.ExecuteReader());
            dgv_NhanVien.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void dgv_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoTenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_SDTNV.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_EmailNV.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_PasswordNV.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiTaiKhoanNV.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
        }        

        //hiển thị danh sách nhân viên
        private void btn_Show_NhanVien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);               
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhanVien.DataSource = dt;
                conn.Close();
            }
        }

        //tìm kiếm nhân viên dựa vào mã nhân viên
        private void btn_TimKiem_NhanVien_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_TimKiemNhanVien(@MaNV)", conn);
                cmd.Parameters.AddWithValue("@MaNV", txt_TimKiem_NhanVien.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhanVien.DataSource = dt;
                conn.Close();
            }
        }

        private void btn_Them_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnectionAdmin();
            try
            {
                int isAdmin = 0;
                if(radiobtn_Admin.Checked)
                {
                    isAdmin = 1;
                }
                SqlCommand cmd = new SqlCommand($"BEGIN EXEC dbo.sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'INSERT'" +
                    $"EXEC proc_ThemTaiKhoan '{txt_MaNV.Text}, '{txt_PasswordNV.Text}',{isAdmin} END", myconn.getConnectionAdmin);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnectionAdmin();
        }

        private void btn_Sua_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnectionAdmin();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC dbo.sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'UPDATE'", myconn.getConnectionAdmin);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnectionAdmin();
        }

        private void btn_Xoa_NhanVien_Click(object sender, EventArgs e)
        {
            myconn.openConnectionAdmin();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhanVien '{txt_MaNV.Text}', N'{txt_HoTenNV.Text}', '{txt_SDTNV.Text}', '{txt_EmailNV.Text}', '{txt_PasswordNV.Text}', N'{txt_TrangThaiTaiKhoanNV.Text}', 'DELETE' ", myconn.getConnectionAdmin);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            myconn.closeConnectionAdmin();
        }

        private void tab_Information_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void tab_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
