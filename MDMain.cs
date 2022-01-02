using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Laboratory_Analysis
{
    public partial class MDMain : Form
    {
        public MDMain()
        {
            InitializeComponent();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            frmTypes frm = new frmTypes();
            frm.Owner = this;
            frm.Show();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            frmVisits frm = new frmVisits();
            frm.Owner = this;
            frm.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            frmDoctors frm = new frmDoctors();
            frm.Owner = this;
            frm.Show();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            frmAnalysis frm = new frmAnalysis();
            frm.Owner = this;
            frm.Show();
        }

        private void btnLabInfo_Click(object sender, EventArgs e)
        {
            frmLabInfo frm = new frmLabInfo();
            frm.Owner = this;
            frm.Show();
        }

        private void MDMain_Load(object sender, EventArgs e)
        {
            ReadLabInfo();
        }
        private void ReadLabInfo()
        {
            SqlConnection Con = new SqlConnection(Settings.ConStr);
            try
            {
                SqlDataAdapter Da = new SqlDataAdapter("Select * From LABInfo Where ID=1", Con);
                DataSet Ds = new DataSet();
                Da.Fill(Ds, "LABInfo");
                if (Ds.Tables[0].Rows.Count > 0)
                {
                    Settings.LABName = Ds.Tables[0].Rows[0][1].ToString();
                    Settings.DocotrName = Ds.Tables[0].Rows[0][2].ToString();
                    Settings.Phone = Ds.Tables[0].Rows[0][3].ToString();
                    Settings.Address = Ds.Tables[0].Rows[0][4].ToString();
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
        private void MDMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        
    }
}
