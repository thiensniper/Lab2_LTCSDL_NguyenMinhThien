using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class XL_Bang : DataTable
    {
        #region Biến cục bộ
        public static string Connection_String = "Data Source=.;Initial Catalog=QLSINHVIEN4;Integrated Security=True";
        private string chuoiSQL;
        private string tenBang;
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        #endregion

        #region Thuộc tính
        public string ChuoiSQL
        {
            get { return chuoiSQL; }
            set { chuoiSQL = value; }
        }
        public string TenBang
        {
            get { return tenBang; }
            set { tenBang = value; }
        }

        #endregion

        #region Phương thức khởi tạo
        public XL_Bang() : base() { }
        public XL_Bang(String tenBang) // Tạo mới với tên bảng
        {

        }
        public XL_Bang(String tenBang, String chuoiSQL) // Tạo mới với câu truy vấn
        {

        }
        #endregion

        #region Phương thức xử lý: đọc, ghi, lọc dữ liệu
        public void DocBang()
        {
            if (chuoiSQL == null)
                chuoiSQL = "SELECT * FROM " + tenBang;
            if (sqlConnection == null)
                sqlConnection = new SqlConnection(Connection_String);
            try
            {
                dataAdapter = new SqlDataAdapter(chuoiSQL, sqlConnection);
                dataAdapter.FillSchema(this, SchemaType.Mapped);
                dataAdapter.Fill(this);
                dataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(AutonumberRowUpdated);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool GhiBang()
        {
            bool updateResult = true;
            try
            {
                dataAdapter.Update(this);
                this.AcceptChanges();
            }
            catch ( SqlException ex)
            {
                this.RejectChanges();
                updateResult = false;
                throw ex;
            }
            return updateResult;
        }
        public void LocDuLieu(string condition)
        {
            try
            {
                this.DefaultView.RowFilter = condition;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Xử lý sự kiện
        // Xử lý sự kiện RowUpdated đối với trường khóa chính có kiểu Autonumber
        private void AutonumberRowUpdated(Object sender, SqlRowUpdatedEventArgs e)
        {
            if (this.PrimaryKey[0].AutoIncrement)
            {
                if ((e.Status == UpdateStatus.Continue) && (e.StatementType == StatementType.Insert))
                {
                    SqlCommand cmd = new SqlCommand("Select @@IDENTITY ", sqlConnection);
                    e.Row.ItemArray[0] = cmd.ExecuteScalar();
                    e.Row.AcceptChanges();
                }
            }
        }
        #endregion

        #region Phương thức thực hiện lệnh
        // Thực hiện câu truy vấn cập nhật dữ liệu: Insert, Update, Delete
        public int ThucHienLenh(string cmd)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(cmd, sqlConnection);
                sqlConnection.Open();
                int result = sqlCmd.ExecuteNonQuery();
                sqlConnection.Close();
                return result;
            }
            catch
            {
                return -1;
            }
        }
        // Thực hiện câu truy vấn trả về 1 giá trị
        public Object ThucHienLenhTinhToan(string cmd)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(cmd, sqlConnection);
                sqlConnection.Open();
                Object result = sqlCmd.ExecuteScalar();
                sqlConnection.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
