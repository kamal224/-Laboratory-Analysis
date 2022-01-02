using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory_Analysis
{
    class Settings
    {
        public static string ConStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + System.Windows.Forms.Application.StartupPath + "\\Database\\LaboratoryAnalysisDB.mdf;Integrated Security=True;User Instance=True;Database=Laboratory_AnalysisDB";
        public static string LABName = "";
        public static string Address = "";
        public static string Phone = "";
        public static string DocotrName = "";
    }
}
