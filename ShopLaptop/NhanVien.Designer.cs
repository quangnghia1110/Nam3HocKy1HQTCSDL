namespace ShopLaptop
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Information = new System.Windows.Forms.TabPage();
            this.lbl_TimKiem_NV = new System.Windows.Forms.Label();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem_NhanVien = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.txt_TimKiem_NhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Show_NhanVien = new Guna.UI.WinForms.GunaButton();
            this.lbl_HeaderTab1NV = new Guna.UI.WinForms.GunaLabel();
            this.tab_Options = new System.Windows.Forms.TabPage();
            this.txt_TrangThaiTaiKhoanNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_TrangThaiTaiKhoan = new Guna.UI.WinForms.GunaLabel();
            this.txt_PasswordNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_EmailNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_HoTenNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SDTNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_MaNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_Password = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Email = new Guna.UI.WinForms.GunaLabel();
            this.lbl_SDT = new Guna.UI.WinForms.GunaLabel();
            this.lbl_HoTenNV = new Guna.UI.WinForms.GunaLabel();
            this.lbl_MaNV = new Guna.UI.WinForms.GunaLabel();
            this.lbl_OptionsNV = new Guna.UI.WinForms.GunaLabel();
            this.btn_Xoa_NhanVien = new Guna.UI.WinForms.GunaButton();
            this.btn_Sua_NhanVien = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_NhanVien = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiobtn_Admin = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tab_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.tab_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tab_Information);
            this.tabControl1.Controls.Add(this.tab_Options);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Information
            // 
            this.tab_Information.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tab_Information.Controls.Add(this.lbl_TimKiem_NV);
            this.tab_Information.Controls.Add(this.dgv_NhanVien);
            this.tab_Information.Controls.Add(this.btn_TimKiem_NhanVien);
            this.tab_Information.Controls.Add(this.txt_TimKiem_NhanVien);
            this.tab_Information.Controls.Add(this.btn_Show_NhanVien);
            this.tab_Information.Controls.Add(this.lbl_HeaderTab1NV);
            this.tab_Information.Location = new System.Drawing.Point(4, 4);
            this.tab_Information.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tab_Information.Name = "tab_Information";
            this.tab_Information.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tab_Information.Size = new System.Drawing.Size(1264, 851);
            this.tab_Information.TabIndex = 0;
            this.tab_Information.Text = "Information";
            this.tab_Information.UseVisualStyleBackColor = true;
            this.tab_Information.Click += new System.EventHandler(this.tab_Information_Click);
            // 
            // lbl_TimKiem_NV
            // 
            this.lbl_TimKiem_NV.AutoSize = true;
            this.lbl_TimKiem_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem_NV.Location = new System.Drawing.Point(839, 64);
            this.lbl_TimKiem_NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TimKiem_NV.Name = "lbl_TimKiem_NV";
            this.lbl_TimKiem_NV.Size = new System.Drawing.Size(156, 18);
            this.lbl_TimKiem_NV.TabIndex = 16;
            this.lbl_TimKiem_NV.Text = "Nhập mã nhân viên:";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.AllowUserToResizeColumns = false;
            this.dgv_NhanVien.AllowUserToResizeRows = false;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_NhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NhanVien.ColumnHeadersHeight = 80;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.SDT,
            this.Email,
            this.Passwd,
            this.TrangThaiTaiKhoan,
            this.VaiTro});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_NhanVien.EnableHeadersVisualStyles = false;
            this.dgv_NhanVien.Location = new System.Drawing.Point(4, 138);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NhanVien.RowHeadersWidth = 62;
            this.dgv_NhanVien.ShowCellErrors = false;
            this.dgv_NhanVien.ShowCellToolTips = false;
            this.dgv_NhanVien.ShowEditingIcon = false;
            this.dgv_NhanVien.ShowRowErrors = false;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1249, 671);
            this.dgv_NhanVien.TabIndex = 15;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellContentClick);
            // 
            // btn_TimKiem_NhanVien
            // 
            this.btn_TimKiem_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_TimKiem_NhanVien.AnimationSpeed = 0.03F;
            this.btn_TimKiem_NhanVien.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhanVien.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_TimKiem_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_TimKiem_NhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NhanVien.Image = null;
            this.btn_TimKiem_NhanVien.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_NhanVien.Location = new System.Drawing.Point(1171, 79);
            this.btn_TimKiem_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem_NhanVien.Name = "btn_TimKiem_NhanVien";
            this.btn_TimKiem_NhanVien.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_TimKiem_NhanVien.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_TimKiem_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NhanVien.OnHoverImage = null;
            this.btn_TimKiem_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TimKiem_NhanVien.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_NhanVien.TabIndex = 14;
            this.btn_TimKiem_NhanVien.Text = "Tìm";
            this.btn_TimKiem_NhanVien.Click += new System.EventHandler(this.btn_TimKiem_NhanVien_Click);
            // 
            // txt_TimKiem_NhanVien
            // 
            this.txt_TimKiem_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem_NhanVien.BaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NhanVien.BorderColor = System.Drawing.Color.Silver;
            this.txt_TimKiem_NhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem_NhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TimKiem_NhanVien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TimKiem_NhanVien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TimKiem_NhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiem_NhanVien.Location = new System.Drawing.Point(843, 86);
            this.txt_TimKiem_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimKiem_NhanVien.Name = "txt_TimKiem_NhanVien";
            this.txt_TimKiem_NhanVien.PasswordChar = '\0';
            this.txt_TimKiem_NhanVien.Radius = 10;
            this.txt_TimKiem_NhanVien.SelectedText = "";
            this.txt_TimKiem_NhanVien.Size = new System.Drawing.Size(255, 42);
            this.txt_TimKiem_NhanVien.TabIndex = 13;
            // 
            // btn_Show_NhanVien
            // 
            this.btn_Show_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_Show_NhanVien.AnimationSpeed = 0.03F;
            this.btn_Show_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show_NhanVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Show_NhanVien.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Show_NhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Show_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Show_NhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_Show_NhanVien.Image = global::ShopLaptop.Properties.Resources.icons8_list_100;
            this.btn_Show_NhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Show_NhanVien.Location = new System.Drawing.Point(8, 76);
            this.btn_Show_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Show_NhanVien.Name = "btn_Show_NhanVien";
            this.btn_Show_NhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Show_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Show_NhanVien.OnHoverImage = null;
            this.btn_Show_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Show_NhanVien.Radius = 20;
            this.btn_Show_NhanVien.Size = new System.Drawing.Size(240, 52);
            this.btn_Show_NhanVien.TabIndex = 12;
            this.btn_Show_NhanVien.Text = "Hiển thị thông tin";
            this.btn_Show_NhanVien.Click += new System.EventHandler(this.btn_Show_NhanVien_Click);
            // 
            // lbl_HeaderTab1NV
            // 
            this.lbl_HeaderTab1NV.AutoSize = true;
            this.lbl_HeaderTab1NV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeaderTab1NV.ForeColor = System.Drawing.Color.Red;
            this.lbl_HeaderTab1NV.Location = new System.Drawing.Point(461, 4);
            this.lbl_HeaderTab1NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeaderTab1NV.Name = "lbl_HeaderTab1NV";
            this.lbl_HeaderTab1NV.Size = new System.Drawing.Size(245, 32);
            this.lbl_HeaderTab1NV.TabIndex = 11;
            this.lbl_HeaderTab1NV.Text = "Thông tin nhân viên";
            // 
            // tab_Options
            // 
            this.tab_Options.Controls.Add(this.gunaLabel1);
            this.tab_Options.Controls.Add(this.radiobtn_Admin);
            this.tab_Options.Controls.Add(this.txt_TrangThaiTaiKhoanNV);
            this.tab_Options.Controls.Add(this.lbl_TrangThaiTaiKhoan);
            this.tab_Options.Controls.Add(this.txt_PasswordNV);
            this.tab_Options.Controls.Add(this.txt_EmailNV);
            this.tab_Options.Controls.Add(this.txt_HoTenNV);
            this.tab_Options.Controls.Add(this.txt_SDTNV);
            this.tab_Options.Controls.Add(this.txt_MaNV);
            this.tab_Options.Controls.Add(this.lbl_Password);
            this.tab_Options.Controls.Add(this.lbl_Email);
            this.tab_Options.Controls.Add(this.lbl_SDT);
            this.tab_Options.Controls.Add(this.lbl_HoTenNV);
            this.tab_Options.Controls.Add(this.lbl_MaNV);
            this.tab_Options.Controls.Add(this.lbl_OptionsNV);
            this.tab_Options.Controls.Add(this.btn_Xoa_NhanVien);
            this.tab_Options.Controls.Add(this.btn_Sua_NhanVien);
            this.tab_Options.Controls.Add(this.btn_Them_NhanVien);
            this.tab_Options.Location = new System.Drawing.Point(4, 4);
            this.tab_Options.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tab_Options.Name = "tab_Options";
            this.tab_Options.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tab_Options.Size = new System.Drawing.Size(1264, 851);
            this.tab_Options.TabIndex = 1;
            this.tab_Options.Text = "Options";
            this.tab_Options.UseVisualStyleBackColor = true;
            this.tab_Options.Click += new System.EventHandler(this.tab_Options_Click);
            // 
            // txt_TrangThaiTaiKhoanNV
            // 
            this.txt_TrangThaiTaiKhoanNV.BackColor = System.Drawing.Color.White;
            this.txt_TrangThaiTaiKhoanNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiTaiKhoanNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiTaiKhoanNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiTaiKhoanNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_TrangThaiTaiKhoanNV.Location = new System.Drawing.Point(557, 469);
            this.txt_TrangThaiTaiKhoanNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TrangThaiTaiKhoanNV.Name = "txt_TrangThaiTaiKhoanNV";
            this.txt_TrangThaiTaiKhoanNV.PasswordChar = '\0';
            this.txt_TrangThaiTaiKhoanNV.SelectedText = "";
            this.txt_TrangThaiTaiKhoanNV.Size = new System.Drawing.Size(429, 42);
            this.txt_TrangThaiTaiKhoanNV.TabIndex = 19;
            // 
            // lbl_TrangThaiTaiKhoan
            // 
            this.lbl_TrangThaiTaiKhoan.AutoSize = true;
            this.lbl_TrangThaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThaiTaiKhoan.Location = new System.Drawing.Point(269, 482);
            this.lbl_TrangThaiTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TrangThaiTaiKhoan.Name = "lbl_TrangThaiTaiKhoan";
            this.lbl_TrangThaiTaiKhoan.Size = new System.Drawing.Size(194, 28);
            this.lbl_TrangThaiTaiKhoan.TabIndex = 18;
            this.lbl_TrangThaiTaiKhoan.Text = "Trạng thái tài khoản:";
            // 
            // txt_PasswordNV
            // 
            this.txt_PasswordNV.BackColor = System.Drawing.Color.White;
            this.txt_PasswordNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_PasswordNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_PasswordNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_PasswordNV.Location = new System.Drawing.Point(557, 418);
            this.txt_PasswordNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PasswordNV.Name = "txt_PasswordNV";
            this.txt_PasswordNV.PasswordChar = '\0';
            this.txt_PasswordNV.SelectedText = "";
            this.txt_PasswordNV.Size = new System.Drawing.Size(429, 42);
            this.txt_PasswordNV.TabIndex = 13;
            // 
            // txt_EmailNV
            // 
            this.txt_EmailNV.BackColor = System.Drawing.Color.White;
            this.txt_EmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EmailNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_EmailNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_EmailNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_EmailNV.Location = new System.Drawing.Point(557, 369);
            this.txt_EmailNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_EmailNV.Name = "txt_EmailNV";
            this.txt_EmailNV.PasswordChar = '\0';
            this.txt_EmailNV.SelectedText = "";
            this.txt_EmailNV.Size = new System.Drawing.Size(429, 42);
            this.txt_EmailNV.TabIndex = 14;
            // 
            // txt_HoTenNV
            // 
            this.txt_HoTenNV.BackColor = System.Drawing.Color.White;
            this.txt_HoTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTenNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_HoTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTenNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_HoTenNV.Location = new System.Drawing.Point(557, 270);
            this.txt_HoTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_HoTenNV.Name = "txt_HoTenNV";
            this.txt_HoTenNV.PasswordChar = '\0';
            this.txt_HoTenNV.SelectedText = "";
            this.txt_HoTenNV.Size = new System.Drawing.Size(429, 42);
            this.txt_HoTenNV.TabIndex = 15;
            // 
            // txt_SDTNV
            // 
            this.txt_SDTNV.BackColor = System.Drawing.Color.White;
            this.txt_SDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDTNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_SDTNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDTNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_SDTNV.Location = new System.Drawing.Point(557, 319);
            this.txt_SDTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SDTNV.Name = "txt_SDTNV";
            this.txt_SDTNV.PasswordChar = '\0';
            this.txt_SDTNV.SelectedText = "";
            this.txt_SDTNV.Size = new System.Drawing.Size(429, 42);
            this.txt_SDTNV.TabIndex = 16;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.Color.White;
            this.txt_MaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNV.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_MaNV.Location = new System.Drawing.Point(557, 219);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.PasswordChar = '\0';
            this.txt_MaNV.SelectedText = "";
            this.txt_MaNV.Size = new System.Drawing.Size(429, 42);
            this.txt_MaNV.TabIndex = 17;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(269, 433);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 28);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(269, 383);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(64, 28);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(269, 334);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(51, 28);
            this.lbl_SDT.TabIndex = 10;
            this.lbl_SDT.Text = "SDT:";
            // 
            // lbl_HoTenNV
            // 
            this.lbl_HoTenNV.AutoSize = true;
            this.lbl_HoTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTenNV.Location = new System.Drawing.Point(269, 283);
            this.lbl_HoTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HoTenNV.Name = "lbl_HoTenNV";
            this.lbl_HoTenNV.Size = new System.Drawing.Size(165, 28);
            this.lbl_HoTenNV.TabIndex = 11;
            this.lbl_HoTenNV.Text = "Họ tên nhân viên:";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(269, 233);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(134, 28);
            this.lbl_MaNV.TabIndex = 12;
            this.lbl_MaNV.Text = "Mã nhân viên:";
            // 
            // lbl_OptionsNV
            // 
            this.lbl_OptionsNV.AutoSize = true;
            this.lbl_OptionsNV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionsNV.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionsNV.Location = new System.Drawing.Point(459, 61);
            this.lbl_OptionsNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OptionsNV.Name = "lbl_OptionsNV";
            this.lbl_OptionsNV.Size = new System.Drawing.Size(356, 32);
            this.lbl_OptionsNV.TabIndex = 7;
            this.lbl_OptionsNV.Text = "Tùy chỉnh thông tin nhân viên";
            this.lbl_OptionsNV.Click += new System.EventHandler(this.lbl_OptionsNV_Click);
            // 
            // btn_Xoa_NhanVien
            // 
            this.btn_Xoa_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_NhanVien.AnimationSpeed = 0.03F;
            this.btn_Xoa_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa_NhanVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Xoa_NhanVien.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_NhanVien.Image = global::ShopLaptop.Properties.Resources.icons8_delete_64;
            this.btn_Xoa_NhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_NhanVien.Location = new System.Drawing.Point(765, 578);
            this.btn_Xoa_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa_NhanVien.Name = "btn_Xoa_NhanVien";
            this.btn_Xoa_NhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_NhanVien.OnHoverImage = null;
            this.btn_Xoa_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_NhanVien.Radius = 6;
            this.btn_Xoa_NhanVien.Size = new System.Drawing.Size(240, 52);
            this.btn_Xoa_NhanVien.TabIndex = 4;
            this.btn_Xoa_NhanVien.Text = "Xóa";
            this.btn_Xoa_NhanVien.Click += new System.EventHandler(this.btn_Xoa_NhanVien_Click);
            // 
            // btn_Sua_NhanVien
            // 
            this.btn_Sua_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_NhanVien.AnimationSpeed = 0.03F;
            this.btn_Sua_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua_NhanVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Sua_NhanVien.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_NhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_NhanVien.Image = global::ShopLaptop.Properties.Resources.icons8_update_48;
            this.btn_Sua_NhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_NhanVien.Location = new System.Drawing.Point(493, 578);
            this.btn_Sua_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua_NhanVien.Name = "btn_Sua_NhanVien";
            this.btn_Sua_NhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_NhanVien.OnHoverImage = null;
            this.btn_Sua_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_NhanVien.Radius = 6;
            this.btn_Sua_NhanVien.Size = new System.Drawing.Size(240, 52);
            this.btn_Sua_NhanVien.TabIndex = 5;
            this.btn_Sua_NhanVien.Text = "Sửa";
            this.btn_Sua_NhanVien.Click += new System.EventHandler(this.btn_Sua_NhanVien_Click);
            // 
            // btn_Them_NhanVien
            // 
            this.btn_Them_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_Them_NhanVien.AnimationSpeed = 0.03F;
            this.btn_Them_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them_NhanVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Them_NhanVien.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_NhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_Them_NhanVien.Image = global::ShopLaptop.Properties.Resources.icons8_add_user_group_woman_man_skin_type_7_48;
            this.btn_Them_NhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_NhanVien.Location = new System.Drawing.Point(224, 578);
            this.btn_Them_NhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_NhanVien.Name = "btn_Them_NhanVien";
            this.btn_Them_NhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_NhanVien.OnHoverImage = null;
            this.btn_Them_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_NhanVien.Radius = 6;
            this.btn_Them_NhanVien.Size = new System.Drawing.Size(240, 52);
            this.btn_Them_NhanVien.TabIndex = 6;
            this.btn_Them_NhanVien.Text = "Thêm";
            this.btn_Them_NhanVien.Click += new System.EventHandler(this.btn_Them_NhanVien_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(278, 150);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(75, 28);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Vai trò:";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên nhân viên";
            this.HoTenNV.MinimumWidth = 8;
            this.HoTenNV.Name = "HoTenNV";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // Passwd
            // 
            this.Passwd.DataPropertyName = "Passwd";
            this.Passwd.HeaderText = "Password";
            this.Passwd.MinimumWidth = 8;
            this.Passwd.Name = "Passwd";
            // 
            // TrangThaiTaiKhoan
            // 
            this.TrangThaiTaiKhoan.DataPropertyName = "TrangThaiTaiKhoan";
            this.TrangThaiTaiKhoan.HeaderText = "Trạng thái tài khoản";
            this.TrangThaiTaiKhoan.MinimumWidth = 8;
            this.TrangThaiTaiKhoan.Name = "TrangThaiTaiKhoan";
            // 
            // VaiTro
            // 
            this.VaiTro.DataPropertyName = "VaiTro";
            this.VaiTro.HeaderText = "Vai trò";
            this.VaiTro.MinimumWidth = 6;
            this.VaiTro.Name = "VaiTro";
            // 
            // radiobtn_Admin
            // 
            this.radiobtn_Admin.AutoSize = true;
            this.radiobtn_Admin.Location = new System.Drawing.Point(557, 150);
            this.radiobtn_Admin.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtn_Admin.Name = "radiobtn_Admin";
            this.radiobtn_Admin.Size = new System.Drawing.Size(77, 24);
            this.radiobtn_Admin.TabIndex = 20;
            this.radiobtn_Admin.TabStop = true;
            this.radiobtn_Admin.Text = "Admin";
            this.radiobtn_Admin.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 827);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Information.ResumeLayout(false);
            this.tab_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.tab_Options.ResumeLayout(false);
            this.tab_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Information;
        private System.Windows.Forms.TabPage tab_Options;
        private System.Windows.Forms.Label lbl_TimKiem_NV;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private Guna.UI.WinForms.GunaGradientCircleButton btn_TimKiem_NhanVien;
        private Guna.UI.WinForms.GunaTextBox txt_TimKiem_NhanVien;
        private Guna.UI.WinForms.GunaButton btn_Show_NhanVien;
        private Guna.UI.WinForms.GunaLabel lbl_HeaderTab1NV;
        private Guna.UI.WinForms.GunaLineTextBox txt_TrangThaiTaiKhoanNV;
        private Guna.UI.WinForms.GunaLabel lbl_TrangThaiTaiKhoan;
        private Guna.UI.WinForms.GunaLineTextBox txt_PasswordNV;
        private Guna.UI.WinForms.GunaLineTextBox txt_EmailNV;
        private Guna.UI.WinForms.GunaLineTextBox txt_HoTenNV;
        private Guna.UI.WinForms.GunaLineTextBox txt_SDTNV;
        private Guna.UI.WinForms.GunaLineTextBox txt_MaNV;
        private Guna.UI.WinForms.GunaLabel lbl_Password;
        private Guna.UI.WinForms.GunaLabel lbl_Email;
        private Guna.UI.WinForms.GunaLabel lbl_SDT;
        private Guna.UI.WinForms.GunaLabel lbl_HoTenNV;
        private Guna.UI.WinForms.GunaLabel lbl_MaNV;
        private Guna.UI.WinForms.GunaLabel lbl_OptionsNV;
        private Guna.UI.WinForms.GunaButton btn_Xoa_NhanVien;
        private Guna.UI.WinForms.GunaButton btn_Sua_NhanVien;
        private Guna.UI.WinForms.GunaButton btn_Them_NhanVien;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.RadioButton radiobtn_Admin;
    }
}