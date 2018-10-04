using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_LTCSDL_NguyenMinhThien
{
    public partial class frmMain : Form
    {
        #region Biến cục bộ
        string path = "../../Images";
        SinhVien tblSinhVien;
        Lop tblLop;
        BindingManagerBase DSSV;
        bool capNhat = false;
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tblSinhVien = new SinhVien();
            tblLop = new Lop();

            loadCbbLop();
            LoadDGVSinhVien();

            txtMaSV.DataBindings.Add("text", tblSinhVien, "MaSV", true);
            txtHoTen.DataBindings.Add("text", tblSinhVien, "HoTen", true);
            dateNgaySinh.DataBindings.Add("text", tblSinhVien, "NgaySinh", true);
            rdbNam.DataBindings.Add("checked", tblSinhVien, "GioiTinh", true);
            cbbLop.DataBindings.Add("SelectedValue", tblSinhVien, "MaLop", true);
            txtQueQuan.DataBindings.Add("text", tblSinhVien, "DiaChi", true);
            picAvatar.DataBindings.Add("ImageLocation", tblSinhVien, "Hinh", true);

            DSSV = this.BindingContext[tblSinhVien];
            enabledNutLenh(false);
        }

        private void enabledNutLenh(bool value)
        {
            btnThem.Enabled = !value;
            btnXoa.Enabled = !value;
            btnSua.Enabled = !value;
            btnThoat.Enabled = !value;
            btnLuu.Enabled = value;
            btnHuy.Enabled = value;
        }

        private void LoadDGVSinhVien()
        {
            dgvDSSV.AutoGenerateColumns = false;
            dgvDSSV.DataSource = tblSinhVien;
        }

        private void loadCbbLop()
        {
            cbbLop.DataSource = tblLop;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSV.AddNew();
            enabledNutLenh(true);
            capNhat = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.EndCurrentEdit();
                tblSinhVien.GhiBang();
                enabledNutLenh(false);
                capNhat = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSV.CancelCurrentEdit();
            tblSinhVien.RejectChanges();
            enabledNutLenh(false);
            capNhat = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DSSV.RemoveAt(DSSV.Position);
            if (!tblSinhVien.GhiBang())
                MessageBox.Show("Xóa thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enabledNutLenh(true);
            capNhat = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblSinhVien.Select("MaSV ='" + txtTimKiem.Text + "'")[0];
                DSSV.Position = tblSinhVien.Rows.IndexOf(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Tìm Thấy");
            }
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialogPic.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (openFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialogPic.SafeFileName;
                string pathFile = path + "/" + fileName;
                if (!File.Exists(pathFile))
                    File.Copy(openFileDialogPic.FileName, pathFile);
                picAvatar.ImageLocation = pathFile;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSSV_SelectionChanged(object sender, EventArgs e)
        {
            if (capNhat)
            {
                btnHuy_Click(sender, e);
            }
        }
    }
}
