using System.Net;
using System.Net.Sockets;

namespace ServerCore
{
    public class Listener 
    {
        Socket _listenSocket;

        public void Init(IPEndPoint endPoint, int register, int backlog)
        {
            Socket _listenSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _listenSocket.Bind(endPoint);
            _listenSocket.Listen(backlog);

            Task acceptTask = Task.Run(() => {StartAcceptRegister(register);}); //Asynchronous Accept Task
            
        }
        private void StartAcceptRegister(int register)
        {
            for (int i = 0; i < register; i++)
            {
                SocketAsyncEventArgs args = new();
                args.Completed += new EventHandler<SocketAsyncEventArgs>(OnAcceptCompleted);
                RegisterAccept(args);
            }
        }
        private void RegisterAccept(SocketAsyncEventArgs args)
        {
            args.AcceptSocket = null;
            if (_listenSocket.AcceptAsync(args) == false)
                OnAcceptCompleted(null, args);
        }

        private void OnAcceptCompleted(object sender, SocketAsyncEventArgs args)
        {
            //TODO
        }
    }

}
