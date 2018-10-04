namespace Lab3_LTCSDL_NguyenMinhThien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.openFileDialogPic = new System.Windows.Forms.OpenFileDialog();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(352, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(27, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(482, 89);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(246, 33);
            this.cbbLop.TabIndex = 4;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(589, 47);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(58, 29);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(482, 47);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(74, 29);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(482, 132);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(246, 81);
            this.txtQueQuan.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 89);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(189, 30);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(140, 46);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(189, 30);
            this.txtMaSV.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(27, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(450, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 38);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(27, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(403, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Nhập vào tên sinh viên cần tìm...";
            this.txtTimKiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseDown);
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.MaLop});
            this.dgvDSSV.Location = new System.Drawing.Point(27, 440);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(749, 211);
            this.dgvDSSV.TabIndex = 2;
            this.dgvDSSV.SelectionChanged += new System.EventHandler(this.dgvDSSV_SelectionChanged);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Location = new System.Drawing.Point(818, 113);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(193, 191);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 3;
            this.picAvatar.TabStop = false;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChonHinh.ImageOptions.Image")));
            this.btnChonHinh.Location = new System.Drawing.Point(839, 310);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(152, 36);
            this.btnChonHinh.TabIndex = 4;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(810, 375);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 86);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(929, 375);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 86);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(810, 467);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 86);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(929, 467);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 86);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(810, 559);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 86);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(929, 559);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 86);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(140, 130);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(200, 30);
            this.dateNgaySinh.TabIndex = 5;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 75;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 170;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 75;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1044, 664);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.PictureBox picAvatar;
        private DevExpress.XtraEditors.SimpleButton btnChonHinh;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.OpenFileDialog openFileDialogPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}

