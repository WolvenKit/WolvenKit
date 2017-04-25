using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WolvenKit.Net
{
    class Net
    {
        public static Socket GameSocket = new Socket(SocketType.Stream,ProtocolType.Tcp);
        public static IPEndPoint DebugProtoclAdress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 37001);

        public static ManualResetEvent ConnectDone = new ManualResetEvent(false) ;
        public static ManualResetEvent SendDone = new ManualResetEvent(false) ;
        public static ManualResetEvent ReceiveDone = new ManualResetEvent(false) ;
        public static Response.Data Response;


        public static void Connect(EndPoint remoteEp, Socket client)
        {
            client.BeginConnect(remoteEp,
                ConnectCallback, client);

            ConnectDone.WaitOne();
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            { 
                var client = (Socket)ar.AsyncState;
                client.EndConnect(ar);

                Console.WriteLine("Connected to game's socket: {0}",
                    client.RemoteEndPoint);

                ConnectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Send(Socket client, byte[] data)
        { 
            client.BeginSend(data, 0, data.Length, SocketFlags.None,
                SendCallback, client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                var client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                var bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.  
                SendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public class StateObject
        {
            // Client socket.  
            public Socket WorkSocket;
            // Size of receive buffer.  
            public const int BufferSize = 8192 * 32;
            // Receive buffer.  
            public byte[] Buffer = new byte[BufferSize];
        }

        public static void Receive(Socket client)
        {
            try
            {
                // Create the state object.  
                var state = new StateObject();
                state.WorkSocket = client;

                // Begin receiving the data from the remote device.  
                client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                    ReceiveCallback, state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
                // Retrieve the state object and the client socket   
                // from the asynchronous state object.  
                var state = (StateObject)ar.AsyncState;
                var client = state.WorkSocket;
                // Read data from the remote device.  
                var bytesRead = client.EndReceive(ar);
                if (state.WorkSocket.Available > 0)
                {
                    client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.Buffer.Length > 1)
                    {
                        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\res.bin",state.Buffer);
                        Response = new Response.Data(state.Buffer);
                        Console.WriteLine($"Recieved packet [{Response.Length} bytes]:");
                        Response.Params.ForEach(x=> Console.WriteLine("\t" + x.Type + ": " + x.ToString()));
                    }
                    // Signal that all bytes have been received.
                    ReceiveDone.Set();
                }

        }


    }
}
