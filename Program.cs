using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
try {
    await tcpClient.ConnectAsync("192.168.220.139", 1777);
    while(true)
    {

        string path = ".img/qwe.jpg";

        byte[] reqestData = File.ReadAllBytes(path);

        await tcpClient.SendAsync(reqestData);

        Console.WriteLine("Изображение отправленно!");
        
    }
}
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
