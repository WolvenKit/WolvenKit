using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace WolvenKit.Net
{
    class Program
    {
        public static Socket GameSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static readonly IPEndPoint GameAdress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 37001);
        public static byte[] _recieveBuffer = new byte[8192 * 32];

        public static void Main(string[] args)
        {
            var tries = 0;
            Console.Title = "Witcher 3 Debug Protocol test";
            for (;;)
            {
                Console.WriteLine($"[{tries}] Connecting to the game.");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine($"[{tries}] Connecting to the game..");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine($"[{tries}] Connecting to the game...");
                Thread.Sleep(100);
                if (ConnectToGame())
                    break;
                tries++;
                Console.WriteLine("Couldn't connect to the game!\nPlease launch \"The Witcher 3: The Wild Hunt\" with the -net command line parameter!");
                Thread.Sleep(1000);
                Console.Clear();
            }   
            Console.Clear();
            Console.WriteLine("Connected to the game!");
            Console.Title = "Witcher 3 Debug Protocol test - [Connected]";
            BeginRecieve();
            //TODO: Async loop and response parsing



            Console.ReadLine();
        }

        public static void BeginRecieve()
        {
            Console.WriteLine("Recieving!");
            GameSocket.BeginReceive(_recieveBuffer, 0, _recieveBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            int recieved = GameSocket.EndReceive(AR);

            if (recieved <= 0)
                return;
            byte[] recData = new byte[recieved];
            Buffer.BlockCopy(_recieveBuffer, 0, recData, 0, recieved);

            //TODO: Actually parse the data
            File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\response.bin",recData);

            GameSocket.BeginReceive(_recieveBuffer, 0, _recieveBuffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
        }

        private static void SendData(byte[] data)
        {
            SocketAsyncEventArgs socketAsyncData = new SocketAsyncEventArgs();
            socketAsyncData.SetBuffer(data, 0, data.Length);
            GameSocket.SendAsync(socketAsyncData);
        }

        public static bool ConnectToGame()
        {
            GameSocket.Connect(GameAdress);
            return GameSocket.Connected;
        }
    }
}
