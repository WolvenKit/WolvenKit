using System;
using System.Collections.Generic;
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

        static void Main(string[] args)
        {
            var tries = 0;
            Console.Title = "Witcher 3 Debug Protocol test";
            for (;;)
            {
                Console.WriteLine($"[{tries}] Connecting to the game.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine($"[{tries}] Connecting to the game..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine($"[{tries}] Connecting to the game...");
                Thread.Sleep(500);
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
            //TODO: Async loop and response parsing



            Console.ReadLine();
        }

        public static bool ConnectToGame()
        {
            GameSocket.Connect(GameAdress);
            return GameSocket.Connected;
        }
    }
}
