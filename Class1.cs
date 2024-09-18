using System;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        TcpClient client = new TcpClient("localhost", 8080);
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesRead));
        client.Close();
    }
}
