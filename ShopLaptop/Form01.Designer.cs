namespace ShopLaptop
{
    partial class ShopLaptop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopLaptop));
            this.panelNavBar = new Guna.UI.WinForms.GunaPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton13 = new Guna.UI.WinForms.GunaButton();
            this.btn_CTHD = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_CTPN = new Guna.UI.WinForms.GunaButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_TrangChu = new Guna.UI.WinForms.GunaButton();
            this.btn_NhanVien = new Guna.UI.WinForms.GunaButton();
            this.btn_Laptop = new Guna.UI.WinForms.GunaButton();
            this.btn_ThongKe = new Guna.UI.WinForms.GunaButton();
            this.btn_NhaCungCap = new Guna.UI.WinForms.GunaButton();
            this.btn_NangCap = new Guna.UI.WinForms.GunaButton();
            this.btn_KhachHang = new Guna.UI.WinForms.GunaButton();
            this.btn_BaoHanh = new Guna.UI.WinForms.GunaButton();
            this.btn_PhieuNhapKho = new Guna.UI.WinForms.GunaButton();
            this.btn_TraGop = new Guna.UI.WinForms.GunaButton();
            this.btn_HoaDon = new Guna.UI.WinForms.GunaButton();
            this.panelHeader = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabelWelcome = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.panelContent = new Guna.UI.WinForms.GunaPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelNavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            resources.ApplyResources(this.panelNavBar, "panelNavBar");
            this.panelNavBar.BackColor = System.Drawing.Color.White;
            this.panelNavBar.Controls.Add(this.panel1);
            this.panelNavBar.Controls.Add(this.panelHeader);
            this.panelNavBar.Controls.Add(this.panelContent);
            this.panelNavBar.Name = "panelNavBar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.gunaButton13);
            this.panel1.Controls.Add(this.btn_CTHD);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.btn_CTPN);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btn_TrangChu);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.btn_Laptop);
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.btn_NhaCungCap);
            this.panel1.Controls.Add(this.btn_NangCap);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Controls.Add(this.btn_BaoHanh);
            this.panel1.Controls.Add(this.btn_PhieuNhapKho);
            this.panel1.Controls.Add(this.btn_TraGop);
            this.panel1.Controls.Add(this.btn_HoaDon);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaButton13
            // 
            this.gunaButton13.AnimationHoverSpeed = 0.07F;
            this.gunaButton13.AnimationSpeed = 0.03F;
            this.gunaButton13.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton13.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.gunaButton13.BorderColor = System.Drawing.Color.Black;
            this.gunaButton13.DialogResult = System.Windows.Forms.DialogResult.No;
            this.gunaButton13.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaButton13, "gunaButton13");
            this.gunaButton13.ForeColor = System.Drawing.Color.White;
            this.gunaButton13.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton13.Image")));
            this.gunaButton13.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton13.Name = "gunaButton13";
            this.gunaButton13.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton13.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton13.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton13.OnHoverImage = null;
            this.gunaButton13.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton13.Radius = 10;
            this.gunaButton13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_CTHD
            // 
            this.btn_CTHD.AnimationHoverSpeed = 0.07F;
            this.btn_CTHD.AnimationSpeed = 0.03F;
            this.btn_CTHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_CTHD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_CTHD.BorderColor = System.Drawing.Color.Black;
            this.btn_CTHD.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_CTHD.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_CTHD, "btn_CTHD");
            this.btn_CTHD.ForeColor = System.Drawing.Color.White;
            this.btn_CTHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_CTHD.Image")));
            this.btn_CTHD.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_CTHD.Name = "btn_CTHD";
            this.btn_CTHD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_CTHD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_CTHD.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_CTHD.OnHoverImage = null;
            this.btn_CTHD.OnPressedColor = System.Drawing.Color.Black;
            this.btn_CTHD.Radius = 10;
            this.btn_CTHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CTHD.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            resources.ApplyResources(this.gunaLabel1, "gunaLabel1");
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Name = "gunaLabel1";
            // 
            // btn_CTPN
            // 
            this.btn_CTPN.AnimationHoverSpeed = 0.07F;
            this.btn_CTPN.AnimationSpeed = 0.03F;
            this.btn_CTPN.BackColor = System.Drawing.Color.Transparent;
            this.btn_CTPN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_CTPN.BorderColor = System.Drawing.Color.Black;
            this.btn_CTPN.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_CTPN.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_CTPN, "btn_CTPN");
            this.btn_CTPN.ForeColor = System.Drawing.Color.White;
            this.btn_CTPN.Image = ((System.Drawing.Image)(resources.GetObject("btn_CTPN.Image")));
            this.btn_CTPN.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_CTPN.Name = "btn_CTPN";
            this.btn_CTPN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_CTPN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_CTPN.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_CTPN.OnHoverImage = null;
            this.btn_CTPN.OnPressedColor = System.Drawing.Color.Black;
            this.btn_CTPN.Radius = 10;
            this.btn_CTPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CTPN.Click += new System.EventHandler(this.btn_CTPN_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 37;
            resources.ApplyResources(this.iconPictureBox1, "iconPictureBox1");
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.AnimationHoverSpeed = 0.07F;
            this.btn_TrangChu.AnimationSpeed = 0.03F;
            this.btn_TrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TrangChu.BorderColor = System.Drawing.Color.Black;
            this.btn_TrangChu.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_TrangChu.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_TrangChu, "btn_TrangChu");
            this.btn_TrangChu.ForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TrangChu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TrangChu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TrangChu.OnHoverImage = null;
            this.btn_TrangChu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TrangChu.Radius = 10;
            this.btn_TrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.AnimationHoverSpeed = 0.07F;
            this.btn_NhanVien.AnimationSpeed = 0.03F;
            this.btn_NhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_NhanVien.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_NhanVien.BorderColor = System.Drawing.Color.Black;
            this.btn_NhanVien.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_NhanVien.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_NhanVien, "btn_NhanVien");
            this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_NhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.OnHoverImage = null;
            this.btn_NhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NhanVien.Radius = 10;
            this.btn_NhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_Laptop
            // 
            this.btn_Laptop.AnimationHoverSpeed = 0.07F;
            this.btn_Laptop.AnimationSpeed = 0.03F;
            this.btn_Laptop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Laptop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_Laptop.BorderColor = System.Drawing.Color.Black;
            this.btn_Laptop.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Laptop.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_Laptop, "btn_Laptop");
            this.btn_Laptop.ForeColor = System.Drawing.Color.White;
            this.btn_Laptop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Laptop.Image")));
            this.btn_Laptop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Laptop.Name = "btn_Laptop";
            this.btn_Laptop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Laptop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Laptop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Laptop.OnHoverImage = null;
            this.btn_Laptop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Laptop.Radius = 10;
            this.btn_Laptop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Laptop.Click += new System.EventHandler(this.btn_Laptop_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.AnimationHoverSpeed = 0.07F;
            this.btn_ThongKe.AnimationSpeed = 0.03F;
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_ThongKe.BorderColor = System.Drawing.Color.Black;
            this.btn_ThongKe.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_ThongKe.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_ThongKe, "btn_ThongKe");
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.OnHoverImage = null;
            this.btn_ThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ThongKe.Radius = 10;
            this.btn_ThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.AnimationHoverSpeed = 0.07F;
            this.btn_NhaCungCap.AnimationSpeed = 0.03F;
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_NhaCungCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_NhaCungCap.BorderColor = System.Drawing.Color.Black;
            this.btn_NhaCungCap.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_NhaCungCap.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_NhaCungCap, "btn_NhaCungCap");
            this.btn_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhaCungCap.Image")));
            this.btn_NhaCungCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_NhaCungCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NhaCungCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.OnHoverImage = null;
            this.btn_NhaCungCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NhaCungCap.Radius = 10;
            this.btn_NhaCungCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_NangCap
            // 
            this.btn_NangCap.AnimationHoverSpeed = 0.07F;
            this.btn_NangCap.AnimationSpeed = 0.03F;
            this.btn_NangCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_NangCap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_NangCap.BorderColor = System.Drawing.Color.Black;
            this.btn_NangCap.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_NangCap.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_NangCap, "btn_NangCap");
            this.btn_NangCap.ForeColor = System.Drawing.Color.White;
            this.btn_NangCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_NangCap.Image")));
            this.btn_NangCap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NangCap.Name = "btn_NangCap";
            this.btn_NangCap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_NangCap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NangCap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_NangCap.OnHoverImage = null;
            this.btn_NangCap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NangCap.Radius = 10;
            this.btn_NangCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NangCap.Click += new System.EventHandler(this.btn_NangCap_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.AnimationHoverSpeed = 0.07F;
            this.btn_KhachHang.AnimationSpeed = 0.03F;
            this.btn_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_KhachHang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_KhachHang.BorderColor = System.Drawing.Color.Black;
            this.btn_KhachHang.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_KhachHang.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_KhachHang, "btn_KhachHang");
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
            this.btn_KhachHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_KhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_KhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.OnHoverImage = null;
            this.btn_KhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_KhachHang.Radius = 10;
            this.btn_KhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_BaoHanh
            // 
            this.btn_BaoHanh.AnimationHoverSpeed = 0.07F;
            this.btn_BaoHanh.AnimationSpeed = 0.03F;
            this.btn_BaoHanh.BackColor = System.Drawing.Color.Transparent;
            this.btn_BaoHanh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_BaoHanh.BorderColor = System.Drawing.Color.Black;
            this.btn_BaoHanh.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_BaoHanh.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_BaoHanh, "btn_BaoHanh");
            this.btn_BaoHanh.ForeColor = System.Drawing.Color.White;
            this.btn_BaoHanh.Image = ((System.Drawing.Image)(resources.GetObject("btn_BaoHanh.Image")));
            this.btn_BaoHanh.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_BaoHanh.Name = "btn_BaoHanh";
            this.btn_BaoHanh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_BaoHanh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_BaoHanh.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_BaoHanh.OnHoverImage = null;
            this.btn_BaoHanh.OnPressedColor = System.Drawing.Color.Black;
            this.btn_BaoHanh.Radius = 10;
            this.btn_BaoHanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_BaoHanh.Click += new System.EventHandler(this.btn_BaoHanh_Click);
            // 
            // btn_PhieuNhapKho
            // 
            this.btn_PhieuNhapKho.AnimationHoverSpeed = 0.07F;
            this.btn_PhieuNhapKho.AnimationSpeed = 0.03F;
            this.btn_PhieuNhapKho.BackColor = System.Drawing.Color.Transparent;
            this.btn_PhieuNhapKho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_PhieuNhapKho.BorderColor = System.Drawing.Color.Black;
            this.btn_PhieuNhapKho.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_PhieuNhapKho.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_PhieuNhapKho, "btn_PhieuNhapKho");
            this.btn_PhieuNhapKho.ForeColor = System.Drawing.Color.White;
            this.btn_PhieuNhapKho.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhieuNhapKho.Image")));
            this.btn_PhieuNhapKho.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_PhieuNhapKho.Name = "btn_PhieuNhapKho";
            this.btn_PhieuNhapKho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_PhieuNhapKho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_PhieuNhapKho.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_PhieuNhapKho.OnHoverImage = null;
            this.btn_PhieuNhapKho.OnPressedColor = System.Drawing.Color.Black;
            this.btn_PhieuNhapKho.Radius = 10;
            this.btn_PhieuNhapKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_PhieuNhapKho.Click += new System.EventHandler(this.btn_PhieuNhapKho_Click);
            // 
            // btn_TraGop
            // 
            this.btn_TraGop.AnimationHoverSpeed = 0.07F;
            this.btn_TraGop.AnimationSpeed = 0.03F;
            this.btn_TraGop.BackColor = System.Drawing.Color.Transparent;
            this.btn_TraGop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TraGop.BorderColor = System.Drawing.Color.Black;
            this.btn_TraGop.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_TraGop.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_TraGop, "btn_TraGop");
            this.btn_TraGop.ForeColor = System.Drawing.Color.White;
            this.btn_TraGop.Image = ((System.Drawing.Image)(resources.GetObject("btn_TraGop.Image")));
            this.btn_TraGop.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_TraGop.Name = "btn_TraGop";
            this.btn_TraGop.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_TraGop.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_TraGop.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_TraGop.OnHoverImage = null;
            this.btn_TraGop.OnPressedColor = System.Drawing.Color.Black;
            this.btn_TraGop.Radius = 10;
            this.btn_TraGop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_TraGop.Click += new System.EventHandler(this.btn_TraGop_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.AnimationHoverSpeed = 0.07F;
            this.btn_HoaDon.AnimationSpeed = 0.03F;
            this.btn_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_HoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_HoaDon.BorderColor = System.Drawing.Color.Black;
            this.btn_HoaDon.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_HoaDon.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.btn_HoaDon, "btn_HoaDon");
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_HoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_HoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.OnHoverImage = null;
            this.btn_HoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btn_HoaDon.Radius = 10;
            this.btn_HoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panelHeader.Controls.Add(this.gunaPanel3);
            this.panelHeader.Controls.Add(this.gunaLabelWelcome);
            this.panelHeader.Controls.Add(this.gunaLabel);
            this.panelHeader.Controls.Add(this.gunaPictureBox);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // gunaPanel3
            // 
            resources.ApplyResources(this.gunaPanel3, "gunaPanel3");
            this.gunaPanel3.Name = "gunaPanel3";
            // 
            // gunaLabelWelcome
            // 
            resources.ApplyResources(this.gunaLabelWelcome, "gunaLabelWelcome");
            this.gunaLabelWelcome.ForeColor = System.Drawing.Color.White;
            this.gunaLabelWelcome.Name = "gunaLabelWelcome";
            // 
            // gunaLabel
            // 
            resources.ApplyResources(this.gunaLabel, "gunaLabel");
            this.gunaLabel.ForeColor = System.Drawing.Color.White;
            this.gunaLabel.Name = "gunaLabel";
            // 
            // gunaPictureBox
            // 
            this.gunaPictureBox.BaseColor = System.Drawing.Color.White;
            resources.ApplyResources(this.gunaPictureBox, "gunaPictureBox");
            this.gunaPictureBox.Name = "gunaPictureBox";
            this.gunaPictureBox.TabStop = false;
            this.gunaPictureBox.Click += new System.EventHandler(this.gunaPictureBox_Click);
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ShopLaptop
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNavBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShopLaptop";
            this.Load += new System.EventHandler(this.ShopLaptop_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private Guna.UI.WinForms.GunaPanel panelNavBar;
            private Guna.UI.WinForms.GunaLabel gunaLabel1;
            private Guna.UI.WinForms.GunaButton btn_TrangChu;
            private Guna.UI.WinForms.GunaButton btn_NhanVien;
            private Guna.UI.WinForms.GunaButton btn_ThongKe;
            private Guna.UI.WinForms.GunaButton btn_NangCap;
            private Guna.UI.WinForms.GunaButton btn_BaoHanh;
            private Guna.UI.WinForms.GunaButton btn_PhieuNhapKho;
            private Guna.UI.WinForms.GunaButton btn_KhachHang;
            private Guna.UI.WinForms.GunaButton btn_NhaCungCap;
            private Guna.UI.WinForms.GunaButton btn_Laptop;
            private Guna.UI.WinForms.GunaButton btn_HoaDon;
            private Guna.UI.WinForms.GunaPanel panelHeader;
            private Guna.UI.WinForms.GunaLabel gunaLabel;
            private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
            private Guna.UI.WinForms.GunaLabel gunaLabelWelcome;
            private System.Windows.Forms.Timer timer;
            private Guna.UI.WinForms.GunaPanel gunaPanel3;
            private System.Windows.Forms.Label label1;
            private Guna.UI.WinForms.GunaPanel panelContent;
        private Guna.UI.WinForms.GunaButton btn_CTPN;
        private Guna.UI.WinForms.GunaButton btn_CTHD;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton13;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI.WinForms.GunaButton btn_TraGop;
    }
}