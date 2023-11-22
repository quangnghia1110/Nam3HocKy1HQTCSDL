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
    public partial class NhaCungCap : Form
    {
        MyConnect myconn=new MyConnect();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        //hiển thị danh sách nhà cung cấp
        private void btn_Show_NhaCungCap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap", conn);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhaCungCap.DataSource = dt;
                conn.Close();
            }
        }
        
        //tìm kiếm NCC dựa vào Mã NCC
        private void btn_TimKiem_NhaCungCap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ShopLaptop; User Id=" + FormDangNhap.username + ";Password=" +
            FormDangNhap.password + ";"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM fn_TimKiemNhaCungCap(@MaNCC)", conn);
                cmd.Parameters.AddWithValue("@MaNCC", txt_TimKiem_NhaCungCap.Text);
                DataTable dt = new DataTable();
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_NhaCungCap.DataSource = dt;
                conn.Close();
            }
        }
        private void Reset()
        {
            txt_MaNCC.ResetText();
            txt_TenNCC.ResetText();
            txt_Email.ResetText();
            txt_DiaChi.ResetText();
            txt_SDT.ResetText();
            txt_TrangThaiHopTac.ResetText();
        }
        private void LoadData()
        {
            myconn.openConnection();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap", myconn.getConnection);
            dataTable.Load(cmd.ExecuteReader());
            dgv_NhaCungCap.DataSource = dataTable;
            myconn.closeConnection();
        }
        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNCC.Text = dgv_NhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txt_TenNCC.Text = dgv_NhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txt_Email.Text = dgv_NhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dgv_NhaCungCap.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dgv_NhaCungCap.CurrentRow.Cells[4].Value.ToString();
            txt_TrangThaiHopTac.Text = dgv_NhaCungCap.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Them_NhaCungCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhaCungCap '{txt_MaNCC.Text}', N'{txt_TenNCC.Text}', '{txt_Email.Text}', N'{txt_DiaChi.Text}', '{txt_SDT.Text}', N'{txt_TrangThaiHopTac.Text}', 'INSERT' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Sua_NhaCungCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhaCungCap '{txt_MaNCC.Text}', N'{txt_TenNCC.Text}', '{txt_Email.Text}', N'{txt_DiaChi.Text}', '{txt_SDT.Text}', N'{txt_TrangThaiHopTac.Text}', 'UPDATE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void btn_Xoa_NhaCungCap_Click(object sender, EventArgs e)
        {
            myconn.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC sp_ReviseNhaCungCap '{txt_MaNCC.Text}', N'{txt_TenNCC.Text}', '{txt_Email.Text}', N'{txt_DiaChi.Text}', '{txt_SDT.Text}', N'{txt_TrangThaiHopTac.Text}', 'DELETE' ", myconn.getConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Reset();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            myconn.closeConnection();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
