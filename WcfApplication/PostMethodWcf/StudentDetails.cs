using System.Runtime.Serialization;

namespace PostMethodWcf
{
    [DataContract]
    public class StudentDetails
    {
        [DataMember(Order = 0)]
        public string StudentName { get; set; }
        [DataMember(Order = 1)]
        public string SDepartment { get; set; }
        [DataMember(Order = 2)]
        public string SAddress { get; set; }
        [DataMember(Order = 3)]
        public string SMobile { get; set; }

        public override string ToString()
        {
            return $"{StudentName}, {SDepartment}, {SAddress}, {SMobile}";
        }
    }
}