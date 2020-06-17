using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using PostMethodWcf;

namespace HostService
{
    class Program
    {
        static Uri baseAddress = new Uri("http://localhost:56811/Service1.svc/Host");
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(StudentSerive)))
            {
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
