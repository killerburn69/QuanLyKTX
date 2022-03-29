using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKTX
{
    //heloo anh ae adasdasd - Okey em iu
    public partial class Form1 : Form
    {
        public static string UserName = "";
        string strConnectionString = "Data Source=DESKTOP-07KO9B1\\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Hung edit
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                boxPass.PasswordChar = (char)0;
            }
            else
            {
                boxPass.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QL_AuthoLogin";
                cmd.Parameters.AddWithValue("@UserName", boxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", boxPass.Text);
                cmd.Connection = conn;
                UserName = boxUsername.Text;
                object kq = cmd.ExecuteScalar();
                string code = Convert.ToString(kq);
                if (code == "01")
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin ad = new Admin();
                    this.Hide();
                    ad.ShowDialog();
                    this.Close();

                }
                else if (code == "02")
                {
                    MessageBox.Show("Chào mừng Sinh viên KTX đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Student stu = new Student();
                    this.Hide();
                    stu.ShowDialog();
                    this.Close();
                }
                else if (code == "03")
                {
                    MessageBox.Show("Chào mừng Nhân viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhanVien nv = new NhanVien();
                    this.Hide();
                    nv.ShowDialog();
                    this.Close();
                }
                else if (code == "04")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxPass.Text = "";
                    boxUsername.Text = "";
                    boxUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boxPass.Text = "";
                    boxUsername.Text = "";
                    boxUsername.Focus();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void boxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            boxUsername.SelectAll();
        }

        private void boxPass_MouseClick(object sender, MouseEventArgs e)
        {
            boxPass.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
