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
    public partial class frmDoctors : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private byte DID = 0;
        public frmDoctors()
        {
            InitializeComponent();
        }

        private void frmDoctors_Load(object sender, EventArgs e)
        {
            
            GetDoctors();
        }
        private void GetDoctors()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select DName From Doctors Order By DName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                comDoctors.Items.Clear();
                comDoctors.Items.Add("");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comDoctors.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                errorPro.SetError(txtName, "Please write doctor name.");
                return;
            }
            else
                errorPro.Clear();
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da;
                DataSet Ds;
                SqlCommandBuilder CMD;
                if (DID == 0)
                {
                    Da = new SqlDataAdapter("Select * From Doctors Where DName='" + txtName.Text.Trim() + "'", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Doctors");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtName, "This doctor alrady exist.");
                        return;
                    }

                    byte NewDID = 0;
                    Da = new SqlDataAdapter("Select MAX(DID) From Doctors", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Doctors");
                    if (Ds.Tables[0].Rows.Count > 0 && Ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                        NewDID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                    //Save
                    Da = new SqlDataAdapter("Select * From Doctors", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Doctors");
                    DataRow Row = Ds.Tables[0].NewRow();
                    Row[0] = NewDID + 1;
                    Row[1] = txtName.Text.Trim();
                    Row[2] = txtPhone.Text.Trim();
                    Row[3] = txtAddress.Text.Trim();
                    Ds.Tables[0].Rows.Add(Row);
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Doctors");
                    //
                    DID = NewDID = 0;
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    comDoctors.Text = "";
                    GetDoctors();

                }
                else
                {
                    Da = new SqlDataAdapter("Select * From Doctors Where DName='" + txtName.Text.Trim() + "' AND DID <>" + DID, Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Doctors");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtName, "This doctor alrady exist.");
                        return;
                    }
                    Da = new SqlDataAdapter("Select * From Doctors Where DID=" + DID, Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Doctors");
                    Ds.Tables[0].Rows[0][1] = txtName.Text.Trim();
                    Ds.Tables[0].Rows[0][2] = txtPhone.Text.Trim();
                    Ds.Tables[0].Rows[0][3] = txtAddress.Text.Trim();
                    Da.UpdateCommand = CMD.GetUpdateCommand();
                    Da.Update(Ds, "Doctors");
                    //
                    DID = 0;
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    comDoctors.Text = "";
                    GetDoctors();
                }
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

        private void comDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDoctors.Text.Trim() == "")
            {
                DID = 0;
                txtName.Text = txtPhone.Text = txtAddress.Text = "";
                return;
            }
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From Doctors Where DName='" + comDoctors.Text.Trim() + "'", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    DID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                    txtName.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtPhone.Text = Ds.Tables[0].Rows[0][2].ToString();
                    txtAddress.Text = Ds.Tables[0].Rows[0][3].ToString();
                }
                else
                {
                    DID = 0;
                    txtName.Text = txtPhone.Text = txtAddress.Text = "";
                }
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
    }
}
