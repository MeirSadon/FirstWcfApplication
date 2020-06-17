using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostMethodWcf
{
    public partial class WebForm1 : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDetails stu = new StudentDetails
            {
                StudentName = TextBox1.Text,
                SAddress = TextBox2.Text,
                SMobile = TextBox3.Text,
                SDepartment = TextBox4.Text
            };
            DataContractJsonSerializer objseria = new DataContractJsonSerializer(typeof(StudentDetails));
            MemoryStream mem = new MemoryStream();
            objseria.WriteObject(mem, stu);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString("http://localhost:56811/Service1.svc/ADDStudentToSql", "POST", data);
            Label1.Text = "Details saved using Rest service";
        }
    }
}