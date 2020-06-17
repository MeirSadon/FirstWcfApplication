using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PostMethodWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentSerive : IStudentService
    {

        [WebInvoke(UriTemplate = "SameStudent", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public StudentDetails ReturnSameStudent(StudentDetails studDetails)
        {
            return studDetails;
        }

        [WebInvoke(UriTemplate = "ADDStudentToSql", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void AddStudentToSql(StudentDetails studDetails)
        {
            //StudentDetails studDetails = JsonConvert.DeserializeObject<StudentDetails>(sdetails);
            string constr = ConfigurationManager.ConnectionStrings["DBStudents"].ConnectionString;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Students;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into students values (@Studentname,@SDepartment,@SAddress,@SMobile)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Studentname", studDetails.StudentName);
            cmd.Parameters.AddWithValue("@SDepartment", studDetails.SDepartment);
            cmd.Parameters.AddWithValue("@SAddress", studDetails.SAddress);
            cmd.Parameters.AddWithValue("@SMobile", studDetails.SMobile);
            cmd.ExecuteNonQuery();
            con.Close();        
        }

        [WebGet(UriTemplate = "GetParameter/{value}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public StudentDetails GetStudentParameter(string value)
        {
            return new StudentDetails
            {
                StudentName = value,
                SDepartment = value,
                SAddress = value,
                SMobile = value,
            };
        }
    }
}
