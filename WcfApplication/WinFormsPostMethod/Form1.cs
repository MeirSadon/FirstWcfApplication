using Newtonsoft.Json;
using PostMethodWcf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPostMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails
            {
                StudentName = SNameTxtbx.Text,
                SDepartment = SDepartmentTxtbx.Text,
                SAddress = SAddressTxtbx.Text,
                SMobile = SMobileTxtbx.Text
            };
            string jsonObject =
                "{" +
                $"\"StudentName\":  \"{sd.StudentName}\"," +
                $" \"SDepartment\": \"{sd.SDepartment}\"," +
                $" \"SAddress\": \"{sd.SAddress}\"," +
                $" \"SMobile\": \"{sd.SMobile}\"" +
                "}";
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString("http://localhost:56811/Service1.svc/ADDStudentToSql", "POST", jsonObject);
        }
    }
}
