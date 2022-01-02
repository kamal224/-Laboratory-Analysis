using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Laboratory_Analysis
{
    public partial class frmLabInfo : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmLabInfo()
        {
            InitializeComponent();
        }

        private void frmLabInfo_Load(object sender, EventArgs e)
        {
            GetInfo();
        }
        private void GetInfo()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From LABInfo Where ID=1", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "LABInfo");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    txtLName.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtDName.Text = Ds.Tables[0].Rows[0][2].ToString();
                    txtPhone.Text = Ds.Tables[0].Rows[0][3].ToString();
                    txtAddress.Text = Ds.Tables[0].Rows[0][4].ToString();
                }
                Da.Dispose();
                Ds.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in system");
            }
            finally
            {
                Con.Close();
            }
        }
        private void SaveInfo()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From LABInfo Where ID=1", Con);
                DataSet Ds = new DataSet();
                SqlCommandBuilder CMD = new SqlCommandBuilder(Da);
                Da.Fill(Ds, "LABInfo");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Ds.Tables[0].Rows[0][1] = txtLName.Text;
                    Ds.Tables[0].Rows[0][2] = txtDName.Text;
                    Ds.Tables[0].Rows[0][3] = txtPhone.Text;
                    Ds.Tables[0].Rows[0][4] = txtAddress.Text;
                    Da.UpdateCommand = CMD.GetUpdateCommand();
                    Da.Update(Ds, "LABInfo");
                    //Update Setting
                    Settings.LABName = txtLName.Text.Trim();
                    Settings.DocotrName = txtDName.Text.Trim();
                    Settings.Phone = txtPhone.Text.Trim();
                    Settings.Address = txtAddress.Text.Trim();
                }
                Da.Dispose();
                Ds.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in system");
            }
            finally
            {
                Con.Close();
            }
        }

        private void frmLabInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveInfo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
