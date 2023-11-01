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

namespace buoi9
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=A209PC31\CSSQL08;Initial Catalog=test;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKN_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon==null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if(sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHKN_Click(object sender, EventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
                MessageBox.Show("Đóng kết nối thành công");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string insertString;
                insertString = "insert into KhoaHoc values('" + txtMa.Text + "',N'" + txtTen.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, sqlCon);
                cmd.ExecuteNonQuery();
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Đóng kết nối thành công");
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string updateString;
                updateString = "update KhoaHoc set TenMH='" + txtTen.Text + "'where MaMH='" + txtMa + "'";
                SqlCommand cmd = new SqlCommand(updateString, sqlCon);
                cmd.ExecuteNonQuery();
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                MessageBox.Show("Update thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string deleteString;
                deleteString = "delete KhoaHoc where MaMH='" + txtMa.Text + "'";
                SqlCommand cmd = new SqlCommand(deleteString, sqlCon);
                cmd.ExecuteNonQuery();
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
