using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;
namespace Laboratory_Analysis
{
    public partial class frmVisits : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private int VID = 0;
        private bool Print;
        public frmVisits()
        {
            InitializeComponent();
        }

        private void frmVisits_Load(object sender, EventArgs e)
        {
            comSearchBy.Text = "Patient Name";
            DatePicSearch.Visible = false;
            comGander.SelectedIndex = 1;
            Print = false;
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            DatePic.Value = DatePicSearch.Value = Convert.ToDateTime(DateTime.Now.ToString(ci));
            GetDoctorsVisit();
            GetTypes();
            GetPatient();
        }
        private void GetPatient()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select DISTINCT FName +' '+MName+' '+LName AS Name FROM Visits ORDER BY Name", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Visits");
                comSearch.Items.Clear();
                comSearch.Items.Add("");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comSearch.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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
        private void GetDoctors()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select DName AS Name FROM Doctors ORDER BY DName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                comSearch.Items.Clear();
                comSearch.Items.Add("");
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comSearch.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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
        private void GetDoctorsVisit()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select DName AS Name FROM Doctors ORDER BY DName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                comDoctors.Items.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    comDoctors.Items.Add(Ds.Tables[0].Rows[i][0].ToString());
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
        private void GetTypes()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select TName From Types Order By TName", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Types");
                comType.Items.Clear();
                comType.Items.Add("All");
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
                comType.Text = "All";
                Con.Close();
            }
        }
        private void comSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comSearchBy.Text == "Patient Name")
            {
                comSearch.Visible = true;
                DatePicSearch.Visible = false;
                GetPatient();
            }
            else if (comSearchBy.Text == "Doctor Name")
            {
                comSearch.Visible = true;
                DatePicSearch.Visible = false;
                GetDoctors();
            }
            else if (comSearchBy.Text == "Visit Date")
            {
                comSearch.Visible = false;
                DatePicSearch.Visible = true;
                GetVisit();
            }
        }
        private void GetVisit()
        {
            if (comSearchBy.Text == "Patient Name" || comSearchBy.Text == "Doctor Name")
                if (comSearch.Text.Trim() == "") return;
           
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                string str = "Select VID,FName+' '+MName+' '+LName AS Name,VDate,DName,Gander,BYear FROM Visits,Doctors Where Doctors.DID=Visits.DID";
                if (comSearchBy.Text == "Patient Name")
                    str += " AND FName+' '+MName+' '+LName LIKE '" + comSearch.Text.Trim() + "%'";
                else if (comSearchBy.Text == "Doctor Name")
                    str += " AND DName = '" + comSearch.Text.Trim() + "'";
                else if (comSearchBy.Text == "Visit Date")
                {
                    string DATE = DatePicSearch.Value.Year + "-" + DatePicSearch.Value.Month + "-" + DatePicSearch.Value.Day;
                    str += " AND (VDate >='" + DATE + " 12:00:00 AM' AND VDate <='" + DATE + " 12:00:00 PM')";
                }

                SqlDataAdapter Da = new SqlDataAdapter(str, Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Visit");
                DataGV.Rows.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    DataGV.Rows.Add(Ds.Tables[0].Rows[i][0],
                        Ds.Tables[0].Rows[i][1],
                        Convert.ToDateTime(Ds.Tables[0].Rows[i][2]).ToShortDateString(),
                        Ds.Tables[0].Rows[i][3],
                        Ds.Tables[0].Rows[i][4].ToString().ToLower() == "true" ? "Male" : "Female",
                        Ds.Tables[0].Rows[i][5]);
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
        private void comSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVisit();
        }

        private void DatePicSearch_ValueChanged(object sender, EventArgs e)
        {
            GetVisit();
        }

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "Select AName From Analysis Where TID IN (Select TID From Types Where TName";
            if (comType.Text.Trim().ToLower() == "all")
                str += " LIKE '%') Order By AName ";
            else
                str += " ='" + comType.Text.Trim() + "') Order By AName ";
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter(str, Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Analysis");
                comAnalysis.Items.Clear();
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

       
        private void comAnalysis_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From Analysis Where AName='" + comAnalysis.Text.Trim() + "'", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "Analysis");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DataAGV.Rows.Count; i++)
                        if (DataAGV[0, i].Value.ToString() == Ds.Tables[0].Rows[0][0].ToString())
                        {
                            MessageBox.Show("This analysis alrady exist");
                            return;
                        }
                    DataAGV.Rows.Add(Ds.Tables[0].Rows[0][0], Ds.Tables[0].Rows[0][1], "");
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Trim() == "")
            {
                errorPro.SetError(txtFName, "Please write patient first name.");
                return;
            }
            else if (txtLName.Text.Trim() == "")
            {
                errorPro.SetError(txtLName, "Please write patient last name.");
                return;
            }
            if (comGander.Text.Trim() == "")
            {
                errorPro.SetError(comGander, "Please select patient gander.");
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
                //Check Doctor DID
                byte DID = 0;
                Da = new SqlDataAdapter("Select DID From Doctors Where DName='" + comDoctors.Text.Trim() + "'", Con);
                Ds = new DataSet();
                Da.Fill(Ds, "Doctors");
                if (Ds.Tables[0].Rows.Count > 0)
                    DID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                if (DID == 0)
                {
                    errorPro.SetError(comDoctors, "Please select doctor.");
                    return;
                }
                //Check If have Analysis
                if (DataAGV.Rows.Count == 0)
                {
                    errorPro.SetError(DataAGV, "You must have one analysis at last.");
                    return;
                }
                if (VID == 0)
                {
                    //Insert to Visits Table
                    int NewVID = 0;
                    Da = new SqlDataAdapter("Select MAX(VID) From Visits", Con);
                    Ds = new DataSet();
                    Da.Fill(Ds, "Visits");
                    if (Ds.Tables[0].Rows.Count > 0 && Ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                        NewVID = Convert.ToByte(Ds.Tables[0].Rows[0][0]);
                    Da = new SqlDataAdapter("Select * From Visits", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Visits");
                    DataRow Row = Ds.Tables[0].NewRow();
                    Row[0] = NewVID + 1;
                    Row[1] = DatePic.Value.ToShortDateString();
                    Row[2] = txtFName.Text.Trim();
                    Row[3] = txtLName.Text.Trim();
                    Row[4] = txtMName.Text.Trim();
                    Row[5] = txtBYear.Text.Trim();
                    Row[6] = Convert.ToBoolean(comGander.SelectedIndex);
                    Row[7] = txtPhone.Text.Trim();
                    Row[8] = DID;
                    Ds.Tables[0].Rows.Add(Row);
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Visits");
                    //Insert To Result Table
                    Da = new SqlDataAdapter("Select * From Results", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Results");
                    for (int i = 0; i < DataAGV.Rows.Count; i++)
                    {
                        DataRow Row2 = Ds.Tables[0].NewRow();
                        Row2[0] = DataAGV[0, i].Value.ToString();
                        Row2[1] = NewVID + 1;
                        Row2[2] = DataAGV[2, i].Value.ToString().Trim() == "" ? " " : DataAGV[2, i].Value.ToString();
                        Ds.Tables[0].Rows.Add(Row2);
                    }
                    
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Results");
                    if (Print)
                        PrintReport(NewVID + 1);
                    DID = 0;
                    VID = NewVID = 0;
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtMName.Text = "";
                    txtBYear.Text = "";
                    txtPhone.Text = "";
                    comGander.SelectedIndex = 1;
                    comDoctors.Text = "";
                    comType.Text = "";
                    comAnalysis.Text = "";
                    DataAGV.Rows.Clear();
                    comSearchBy.Text = "Patient Name";
                    GetVisit();

                }
                else
                {

                    Da = new SqlDataAdapter("Select * From Visits Where VID=" + VID, Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Visits");
                    Ds.Tables[0].Rows[0][1] = DatePic.Value.ToShortDateString();
                    Ds.Tables[0].Rows[0][2] = txtFName.Text.Trim();
                    Ds.Tables[0].Rows[0][3] = txtLName.Text.Trim();
                    Ds.Tables[0].Rows[0][4] = txtMName.Text.Trim();
                    Ds.Tables[0].Rows[0][5] = txtBYear.Text.Trim();
                    Ds.Tables[0].Rows[0][6] = Convert.ToBoolean(comGander.SelectedIndex);
                    Ds.Tables[0].Rows[0][7] = txtPhone.Text.Trim();
                    Ds.Tables[0].Rows[0][8] = DID;
                    Da.UpdateCommand = CMD.GetUpdateCommand();
                    Da.Update(Ds, "Visits");
                    //Delete All Result
                    SqlCommand DeleteCMD = new SqlCommand("DELETE FROM Results WHERE VID=" + VID.ToString(), Con);
                    if (Con.State != ConnectionState.Open) Con.Open();
                    DeleteCMD.ExecuteNonQuery();
                    
                    //Insert To Result Table
                    Da = new SqlDataAdapter("Select * From Results", Con);
                    Ds = new DataSet();
                    CMD = new SqlCommandBuilder(Da);
                    Da.Fill(Ds, "Results");
                    for (int i = 0; i < DataAGV.Rows.Count; i++)
                    {
                        DataRow Row2 = Ds.Tables[0].NewRow();
                        Row2[0] = DataAGV[0, i].Value.ToString();
                        Row2[1] = VID;
                        Row2[2] = DataAGV[2, i].Value.ToString().Trim() == "" ? " ": DataAGV[2, i].Value.ToString();
                        Ds.Tables[0].Rows.Add(Row2);
                    }
                    
                    Da.InsertCommand = CMD.GetInsertCommand();
                    Da.Update(Ds, "Results");
                    if (Print)
                        PrintReport(VID);
                    DID = 0;
                    VID  = 0;
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtMName.Text = "";
                    txtPhone.Text = "";
                    txtBYear.Text = "";
                    comGander.SelectedIndex = 1;
                    comDoctors.Text = "";
                    comType.Text = "";
                    comAnalysis.Text = "";
                    DataAGV.Rows.Clear();
                    comSearchBy.Text = "Patient Name";
                    GetVisit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in system");
            }
            finally
            {
                Print = false;
                Con.Close();
            }
        }

        private void DataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
             SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da;
                DataSet Ds;
                //Get Visit Information
                Da = new SqlDataAdapter("Select VID,VDate,FName,LName,MName,BYear,Gander,Visits.Phone,DName From Visits,Doctors WHERE Visits.DID=Doctors.DID AND VID=" + DataGV[0, e.RowIndex].Value.ToString(), Con);
                Ds = new DataSet();
                Da.Fill(Ds, "Visits");
                if (Ds.Tables[0].Rows.Count != 0)
                {
                    VID = Convert.ToInt32(Ds.Tables[0].Rows[0][0]);
                    DatePic.Value = Convert.ToDateTime(Ds.Tables[0].Rows[0][1].ToString());
                    txtFName.Text = Ds.Tables[0].Rows[0][2].ToString();
                    txtLName.Text = Ds.Tables[0].Rows[0][3].ToString();
                    txtMName.Text = Ds.Tables[0].Rows[0][4].ToString();
                    txtBYear.Text = Ds.Tables[0].Rows[0][5].ToString();
                    comGander.SelectedIndex = Convert.ToInt32(Ds.Tables[0].Rows[0][6]);
                    txtPhone.Text = Ds.Tables[0].Rows[0][7].ToString();
                    comDoctors.Text = Ds.Tables[0].Rows[0][8].ToString();
                }
                //Get Result Information
                Da = new SqlDataAdapter("Select Results.AID,AName,Result From Results,Analysis WHERE Results.AID=Analysis.AID AND VID=" + DataGV[0, e.RowIndex].Value.ToString(), Con);
                Ds = new DataSet();
                Da.Fill(Ds, "Results");
                DataAGV.Rows.Clear();
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    DataAGV.Rows.Add(Ds.Tables[0].Rows[i][0],
                        Ds.Tables[0].Rows[i][1],
                        Ds.Tables[0].Rows[i][2].ToString().Trim());

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
        private void PrintReport(int VID)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //Print
                frmReportViewer rptViewer = new frmReportViewer();
                rptResult rptR = new rptResult();
                TextObject txtLabName;
                TextObject txtAddress;
                TextObject txtPatient;
                TextObject txtDName;
                TextObject txtVDate;
                TextObject txtLDName;

                txtLabName = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtLabName"];
                txtAddress = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtAddress"];
                txtPatient = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtPatient"];
                txtDName = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtDName"];
                txtVDate = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtVDate"];
                txtLDName = (CrystalDecisions.CrystalReports.Engine.TextObject)rptR.ReportDefinition.ReportObjects["txtLDName"];

                txtLabName.Text = Settings.LABName;
                txtAddress.Text = Settings.Address + " - " + Settings.Phone;
                txtPatient.Text = "";
                txtDName.Text = "";
                txtVDate.Text = "";
                txtLDName.Text = Settings.DocotrName;



                DSReport DsReport = new DSReport();
                SqlConnection Con = new SqlConnection(Settings.ConStr);
                try
                {
                    //Visit Info
                    SqlDataAdapter Da = new SqlDataAdapter("Select FName+' '+MName+' '+LName,VDate,DName From Visits,Doctors Where Visits.DID=Doctors.DID AND VID=" + VID.ToString(), Con);
                    DataSet Ds = new DataSet();
                    Da.Fill(Ds);
                    if (Ds.Tables[0].Rows.Count > 0)
                    {
                        txtPatient.Text = "Patient : "+Ds.Tables[0].Rows[0][0].ToString();
                        txtDName.Text = "Doctor : "+Ds.Tables[0].Rows[0][2].ToString();
                        txtVDate.Text = "Date : " + Convert.ToDateTime(Ds.Tables[0].Rows[0][1]).ToShortDateString();
                    }
                    //Analysis Info
                    Da = new SqlDataAdapter("Select AName,Result,Normal,Unit From Analysis,Results Where Analysis.AID=Results.AID AND VID=" + VID.ToString(), Con);
                    Ds = new DataSet();
                    Da.Fill(Ds);
                    DsReport.Tables["Result"].Rows.Clear();
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow Row = DsReport.Tables["Result"].NewRow();
                        Row[0] = Ds.Tables[0].Rows[i][0].ToString();
                        Row[1] = Ds.Tables[0].Rows[i][1].ToString();
                        Row[2] = Ds.Tables[0].Rows[i][2].ToString();
                        Row[3] = Ds.Tables[0].Rows[i][3].ToString();
                        DsReport.Tables["Result"].Rows.Add(Row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    Con.Close();
                }
                
                rptR.SetDataSource(DsReport);
                rptViewer.rptViewer.ReportSource = rptR;
                rptViewer.Owner = MDMain.ActiveForm;
                rptViewer.Refresh();
                rptViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                GC.Collect();
            }
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            Print = true;
            btnOk_Click(sender, e);
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
