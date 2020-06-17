using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PostMethodWcf
{

    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        StudentDetails ReturnSameStudent(StudentDetails studDetails);

        [OperationContract]
        void AddStudentToSql(StudentDetails studDetails);

        [OperationContract]
        StudentDetails GetStudentParameter(string value);
    }
}
