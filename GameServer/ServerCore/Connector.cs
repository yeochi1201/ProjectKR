using System.Net;
using System.Net.Sockets;

namespace ServerCore
{
    public class Connector
    {
        public void Init(IPEndPoint endPoint, int clients = 1)
        {
            Task.Run(() => { StartConnectRegister(endPoint, clients); });
        }

        private void StartConnectRegister(IPEndPoint endPoint, int clients)
        {
            for (int i = 0; i < clients; i++)
            {
                Socket clientSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                SocketAsyncEventArgs args = new SocketAsyncEventArgs();
                args.Completed += OnConnectComplete;
                args.RemoteEndPoint = endPoint;
                args.UserToken = clientSocket;
            }
        }

        private void RegisterConnect(SocketAsyncEventArgs args)
        {
            Socket? socket = args.UserToken as Socket;
            if (socket == null) return;

            if (socket.ConnectAsync(args) == false)
                OnConnectComplete(null, args);
        }

        private void OnConnectComplete(object? sender, SocketAsyncEventArgs args)
        {
            //TODO
        }
    }
}
