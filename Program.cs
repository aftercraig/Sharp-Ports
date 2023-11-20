using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//var tcpListener = new TcpListener(IPAddress.Any, 8888);
try
{
    // Подключение к серверу
    await tcpClient.ConnectAsync("192.168.1.104", 1777);
    while (true)
    {

    // чтение изображения ввиде массива
    byte[] imageData = File.ReadAllBytes("img/123.jpg");

    //Создание сообщения
    //System.Console.WriteLine("Введите команду для сервера");
    //string command = Console.ReadLine() + '\n';

    //Первеод запроса из строкового типа данных в массив байт
    byte[] requestData = File.ReadAllBytes("img/123.jpg");

    // Отправка сообщения серверу
    await tcpClient.SendAsync(requestData, SocketFlags.None);

    // Оповещение о состоянии сообщения
    Console.WriteLine("Изображение отправленно");

    // Сообщение буфера для приема ответа от сервера
    byte[] data = new byte[512];
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}