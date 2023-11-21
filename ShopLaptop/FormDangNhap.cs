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
    public partial class FormDangNhap : Form
    {
        MyConnect myconn=new MyConnect();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                myconn.openConnectionAdmin();
                string user = txtUser.Text;
                string password = txtPassword.Text;
                SqlCommand cmd = new SqlCommand("SELECT dbo.fn_checkLogin(@Username,@Passwd)", myconn.getConnectionAdmin);
                cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                cmd.Parameters.AddWithValue("@Passwd", txtPassword.Text);
                bool count = (bool)cmd.ExecuteScalar();
                myconn.closeConnectionAdmin();
                if (count)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Hide();
                    ShopLaptop shopLaptop = new ShopLaptop();
                    shopLaptop.Show();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công do sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
