using System.Net;

namespace ServerCore
{
    class Program
    {
        static Listener _listener = new();
        const int port = 25000;
        const int acceptRegister = 10;
        const int max_client = 100;

        static void Main(string[] args)
        {
            string host = Dns.GetHostName();
            IPHostEntry entry = Dns.GetHostEntry(host);
            IPAddress ipAddr = entry.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddr, port);
            _listener.Init(endPoint, 10, 100);

            while (true)
            {
                ;
            }
        }
    }
}
