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
    public partial class frmAnalysis : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Int16 AID = 0;
        public frmAnalysis()
        {
            InitializeComponent();
        }

        private void frmAnalysis_Load(object sender, EventArgs e)
        {
           // skinCrafter1.SkinFile = Settings.SkinFile;
            GetTypes();
            GetAnalysis();
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
        private void GetAnalysis()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select AName From Analysis Order By AName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Analysis");
                comAnalysis.Items.Clear();
                comAnalysis.Items.Add("");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comAnalysis.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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
            if (comType.Text.Trim() == "")
            {
                errorPro.SetError(comType, "Please select analysis type.");
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                errorPro.SetError(txtName, "Please write analysis name.");
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

                byte TID = 0;
                //GetType ID
                Da = new SqlDataAdapter("Select TID From Types Where TName='" + comType.Text.Trim() + "'", Con);
                Ds = new DataSet();
                Da.Fill(Ds, "Types");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                }
                else
                {
                    errorPro.SetError(comType, "Please select correct analysis type.");
                    return;
                }

                if (AID == 0)
                {
                    Da = new SqlDataAdapter("Select * From Analysis Where AName='" + txtName.Text.Trim() + "'", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Analysis");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtName, "This analysis alrady exist.");
                        return;
                    }

                    Int16 NewAID = 0;
                    Da = new SqlDataAdapter("Select MAX(AID) From Analysis", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Analysis");
                    if (Ds.Tables[0].Rows.Count > 0 && Ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                        NewAID = Convert.ToInt16(Ds.Tables[0].Rows[0][0]);
                    Da = new SqlDataAdapter("Select * From Analysis", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Analysis");
                    DataRow Row = Ds.Tables[0].NewRow();
                    Row[0] = NewAID + 1;
                    Row[1] = txtName.Text.Trim();
                    Row[2] = TID;
                    Row[3] = txtNormal.Text.Trim();
                    Row[4] = txtUnit.Text.Trim();
                    Ds.Tables[0].Rows.Add(Row);
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Analysis");
                    //
                    AID = NewAID = 0;
                    comType.Text = "";
                    txtName.Text = "";
                    txtNormal.Text = "";
                    txtUnit.Text = "";
                    comAnalysis.Text = "";
                    GetAnalysis();

                }
                else
                {
                    Da = new SqlDataAdapter("Select * From Analysis Where AName='" + txtName.Text.Trim() + "' AND AID <>" + AID, Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Analysis");
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        errorPro.SetError(txtName, "This analysis alrady exist.");
                        return;
                    }
                    Da = new SqlDataAdapter("Select * From Analysis Where AID=" + AID, Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Analysis");
                    Ds.Tables[0].Rows[0][1] = txtName.Text.Trim();
                    Ds.Tables[0].Rows[0][2] = TID;
                    Ds.Tables[0].Rows[0][3] = txtNormal.Text.Trim();
                    Ds.Tables[0].Rows[0][4] = txtUnit.Text.Trim();
                    Da.UpdateCommand = CMD.GetUpdateCommand();
                    Da.Update(Ds, "Analysis");
                    //
                    AID = 0;
                    comType.Text = "";
                    txtName.Text = "";
                    txtNormal.Text = "";
                    txtUnit.Text = "";
                    comAnalysis.Text = "";
                    GetAnalysis();
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

        private void comAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comAnalysis.Text.Trim() == "")
            {
                AID = 0;
                comType.Text = txtName.Text = txtNormal.Text = txtUnit.Text = "";
                return;
            }
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From Analysis Where AName='" + comAnalysis.Text.Trim() + "'", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    AID = Convert.ToInt16(Ds.Tables[0].Rows[0][0]);
                    txtName.Text = Ds.Tables[0].Rows[0][1].ToString();
                    txtNormal.Text = Ds.Tables[0].Rows[0][3].ToString();
                    txtUnit.Text = Ds.Tables[0].Rows[0][4].ToString();
                    //Get Type
                    SqlDataAdapter Da1 = new SqlDataAdapter("Select TName From Types Where TID=" + Ds.Tables[0].Rows[0][2].ToString() , Con);
                    DataSet Ds1 = new DataSet();
                    Da1.Fill(Ds1, "Types");
                    if (Ds1.Tables[0].Rows.Count > 0)
                    {
                        comType.Text = Ds1.Tables[0].Rows[0][0].ToString();
                    }
                }
                else
                {
                    AID = 0;
                    comType.Text = txtName.Text = txtNormal.Text = txtUnit.Text = "";
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
