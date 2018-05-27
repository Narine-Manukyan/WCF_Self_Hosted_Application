using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using BookLibrary;

namespace WCFService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:4090/IWorkWithBookService");
            WSHttpBinding binding = new WSHttpBinding();
            using (ServiceHost host = new ServiceHost(typeof(WorkWithBookService), baseAddress))
            {
                host.AddServiceEndpoint(typeof(IWorkWithBookService), binding, baseAddress);
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("The service is ready at" + baseAddress);
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
