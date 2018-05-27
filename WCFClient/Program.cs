using WCFClient.ServiceReference1;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WorkWithBookServiceClient();
            client.Close();
        }
    }
}
