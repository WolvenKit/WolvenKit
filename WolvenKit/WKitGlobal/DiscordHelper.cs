using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.WKitGlobal
{
    public class DiscordHelper
    {

        public static DiscordRPC.DiscordRpcClient client;
        public void InitDiscordRPC()
        {

            client = new DiscordRPC.DiscordRpcClient("807752124078620732");

            //Set the logger
            client.Logger = new DiscordRPC.Logging.ConsoleLogger() { Level = DiscordRPC.Logging.LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "Launching",

                Assets = new DiscordRPC.Assets()
                {
                    LargeImageKey = "bigwolf",
                    LargeImageText = "Testing",
                    SmallImageKey = "bigwolf"
                }
            });
            client.Invoke();

        }
    }
}
