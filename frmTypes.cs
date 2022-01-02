using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DMSoft;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace Laboratory_Analysis
{
    public partial class frmTypes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmTypes()
        {
            InitializeComponent();
        }
        private byte TID = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetTypes();
        }
        private void GetTypes()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select TName From Types Order By TName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Types");
                comType.Items.Clear();
                comType.Items.Add("");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comType.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtType.Text.Trim() == "")
            {
                errorPro.SetError(txtType, "Please write type name.");
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
                if (TID == 0)
                {
                    Da = new SqlDataAdapter("Select * From Types Where TName='" + txtType.Text.Trim() + "'", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Types");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtType, "This type alrady exist.");
                        return;
                    }

                    byte NewTID = 0;
                    Da = new SqlDataAdapter("Select MAX(TID) From Types", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Types");
                    if (Ds.Tables[0].Rows.Count > 0 && Ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                        NewTID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                    Da = new SqlDataAdapter("Select * From Types", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Types");
                    DataRow Row = Ds.Tables[0].NewRow();
                    Row[0] = NewTID + 1;
                    Row[1] = txtType.Text.Trim();
                    Row[2] = txtNote.Text.Trim();
                    Ds.Tables[0].Rows.Add(Row);
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Types");
                    //
                    TID = NewTID = 0;
                    txtType.Text = "";
                    txtNote.Text = "";
                    comType.Text = "";
                    GetTypes();
                    
                }
                else
                {
                    Da = new SqlDataAdapter("Select * From Types Where TName='" + txtType.Text.Trim() + "' AND TID <>" + TID, Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Types");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtType, "This type alrady exist.");
                        return;
                    }
                    Da = new SqlDataAdapter("Select * From Types Where TID=" + TID, Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Types");
                    Ds.Tables[0].Rows[0][1] = txtType.Text.Trim();
                    Ds.Tables[0].Rows[0][2] = txtNote.Text.Trim();
                    Da.UpdateCommand = CMD.GetUpdateCommand();
                    Da.Update(Ds, "Types");
                    //
                    TID = 0;
                    txtType.Text = "";
                    txtNote.Text = "";
                    comType.Text = "";
                    GetTypes();
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

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comType.Text.Trim() == "")
            {
                TID = 0;
                txtType.Text = txtNote.Text = "";
                return;
            }
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From Types Where TName='" + comType.Text.Trim() + "'", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Types");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                    txtType.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtNote.Text = Ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    TID = 0;
                    txtType.Text = txtNote.Text = "";
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

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
