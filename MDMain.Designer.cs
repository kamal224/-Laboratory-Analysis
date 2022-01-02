namespace Laboratory_Analysis
{
    partial class MDMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDMain));
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnLabInfo = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnVisit
            // 
            this.btnVisit.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.PatientFile;
            this.btnVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisit.Location = new System.Drawing.Point(16, 15);
            this.btnVisit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(99, 75);
            this.btnVisit.TabIndex = 0;
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.Doctors;
            this.btnDoctors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoctors.Location = new System.Drawing.Point(16, 98);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(99, 75);
            this.btnDoctors.TabIndex = 0;
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.Analysis;
            this.btnAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnalysis.Location = new System.Drawing.Point(16, 181);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(99, 75);
            this.btnAnalysis.TabIndex = 0;
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnType
            // 
            this.btnType.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.type2;
            this.btnType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnType.Location = new System.Drawing.Point(16, 264);
            this.btnType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(99, 75);
            this.btnType.TabIndex = 0;
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnLabInfo
            // 
            this.btnLabInfo.BackgroundImage = global::Laboratory_Analysis.Properties.Resources.info;
            this.btnLabInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLabInfo.Location = new System.Drawing.Point(16, 347);
            this.btnLabInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLabInfo.Name = "btnLabInfo";
            this.btnLabInfo.Size = new System.Drawing.Size(99, 75);
            this.btnLabInfo.TabIndex = 0;
            this.btnLabInfo.UseVisualStyleBackColor = true;
            this.btnLabInfo.Click += new System.EventHandler(this.btnLabInfo_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(274, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 49);
            this.lblTime.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(855, 435);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLabInfo);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnDoctors);
            this.Controls.Add(this.btnVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MDMain";
            this.Text = "Laboratory Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDMain_FormClosed);
            this.Load += new System.EventHandler(this.MDMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnLabInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}