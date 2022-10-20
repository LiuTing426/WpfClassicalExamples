using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Demo84.DataModels
{
    //数据协议
    [DataContract]
    public class Employee
    {
        //数据成员
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}