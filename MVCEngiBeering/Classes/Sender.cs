using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace MVCEngiBeering.Classes
{
    public class Sender
    {
        private Socket _socket;
        private string addr;
        
        public Sender(string addr)
        {
            this.addr = addr;
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void send(string json)
        {
            _socket.Connect(addr, 9011);
            byte[] databytes = Encoding.Default.GetBytes(json);
            _socket.Send(databytes);
        }
    }
}