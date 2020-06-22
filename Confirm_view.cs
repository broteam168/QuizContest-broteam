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

namespace DoAnThiTracNghiem_Son
{
    public partial class Confirm_view : Form
    {
        private string con;
        private SqlConnection conSQL;
        private bool con1 = false, _default;
        public Confirm_view()
        {
            InitializeComponent();
            this._default = _default;
            try
            {
                string s = DoAnThiTracNghiem_Son.Properties.Settings.Default.connection;
                string[] s1 = s.Split(';');
                for (int i = 0; i < s1.Length; i++)
                {
                    string[] s2 = s1[i].Split('=');
                    if (i == 0)
                    {
                        txtServer.Text = s2[1];
                    }
                    if (i == 1)
                    {
                        txtDB.Text = s2[1];
                    }
                    if (i == 2)
                    {
                        txtUser.Text = s2[1];
                    }
                    if (i == 3)
                    {
                        txtPass.Text = s2[1];
                    }
                }
            }
            catch (Exception)
            {

            }
            if (_default == true)
            {
                txtServer.Enabled = false;
                txtDB.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Text = "";
                btcheckConnection.Text = "Sao lưu";
                cmdGhi.Text = "Khôi phục";
                this.Text = "Khôi phục và sao lưu";
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (_default == false)
            {
                if (con1 == true)
                {
                    DoAnThiTracNghiem_Son.Properties.Settings.Default.connection = con;
                    DoAnThiTracNghiem_Son.Properties.Settings.Default.Save();
                    MessageBox.Show("Ghi cấu hình thành công!", "Thông báo");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra kêt nối trước khi ghi cấu hình", "Thông báo!");
                }
            }
            else
            {
                khoiphuc();
            }
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcheckConnection_Click(object sender, EventArgs e)
        {
            if (_default == false)
            {
                checkConnection(txtServer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            }
            else
            {
                blank();
            }
        }
        public void blank()
        {
            try
            {
                saveFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    query("Backup database " + txtDB.Text + " to disk='" + saveFileDialog1.FileName + "' with FORMAT");
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Sao lưu dữ liệu thành công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể sao lưu dữ liệu.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }
        public void khoiphuc()
        {
            try
            {
                openFileDialog1.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string s1 = "alter database " + txtDB.Text + " Set single_user with rollback immediate ;";
                    s1 += "RESTORE DATABASE " + txtDB.Text + " FROM DISK='" + openFileDialog1.FileName + "' with replace;";
                    query(s1, true);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Khôi phục thành công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể khôi phục dữ liệu.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
            }
        }
        public void query(string que, bool _df = false)
        {
            if (conSQL == null)
            {
                if (_df == false)
                {
                    conSQL = new SqlConnection(DoAnThiTracNghiem_Son.Properties.Settings.Default.connection);
                }
                else
                {
                    conSQL = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User ID=" + txtUser.Text + ";Password=" + txtPass.Text + ";");
                }
                conSQL.Open();
            }
            SqlCommand sqlcm = new SqlCommand(que, conSQL);
            sqlcm.ExecuteNonQuery();
            conSQL.Close();
            conSQL.Dispose();
        }
        private void checkConnection(string server, string data, string user, string pass)
        {
            con = "Data Source=" + server + ";Initial Catalog=" + data + ";User ID=" + user + ";Password=" + pass + ";";
            conSQL = new SqlConnection(con);
            try
            {
                conSQL.Open();
                MessageBox.Show("Kết nối thành công!", "Thông báo");
                con1 = true;
            }
            catch (Exception)
            {
                con1 = false;
                MessageBox.Show("Kết nối thất bại!", "Thông báo");
            }
            finally
            {
                conSQL.Close();
            }
        }
    }
}
