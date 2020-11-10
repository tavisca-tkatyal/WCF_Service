using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       
        public string GetMessage(string name)
        {
            return "Hello World " + name;
        }

        public Person GetPerson(Person person)
        {
            try
            {
                person.FirstName = null;
                person.FirstName.ToString();
                return new Person { FirstName = "FirstName is" + person.FirstName, LastName = "LastName is" + person.LastName };
            }
            catch (Exception ex)
            {
                person.ErrorDetails = ex.StackTrace;
                person.ErrorMessage = "Retry, Error is coming";
                throw new FaultException<Person>(person, new FaultReason("Invalid Routing Code - No Approval Started"));
            }
            
        }
    }
}
