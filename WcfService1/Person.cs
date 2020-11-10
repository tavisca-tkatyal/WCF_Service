using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace WcfService1
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName
        {
            get; set;
        }
        [DataMember]
        public string LastName
        {
            get; set;
        }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string ErrorDetails
        {
            get; set;
        }
    }
}