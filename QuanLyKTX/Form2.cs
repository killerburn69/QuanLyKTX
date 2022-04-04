using System;
using System.Data;
//1. Provider
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyKTX
{
    public partial class frmNV : Form
    {
        // ADO.NET
        SqlConnection conn;
        SqlDataAdapter daNhanVien;
        DataTable dtNhanVien;
        string connStr = "Data Source=(local)" +
            ";Initial Catalog=QuanLyKTX" +
            ";Integrated Security=True";
        private void LoadData()
        {
            try
            {
                //2. Open connection
                conn = new SqlConnection(connStr);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                //3. Get Data
                daNhanVien = new SqlDataAdapter(
                    "SELECT * FROM NhanVien", conn);
                //4. Fill the container
                dtNhanVien = new DataTable();
                daNhanVien.Fill(dtNhanVien);

                conn.Close();
                //5. Transfer to DataGridView
                dgvNhanVien.DataSource = dtNhanVien;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public frmNV()
        {
            InitializeComponent();
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
