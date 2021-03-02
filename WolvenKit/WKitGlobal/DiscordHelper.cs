using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.WKitGlobal
{
    public static class DiscordHelper
    {
        public static DiscordRPC.DiscordRpcClient client;
        public static bool DiscordRPCEnabled = true;
        public static bool DiscordRPCInitizialized = false;

        public static void InitializeDiscordRPC()
        {
            
            if (DiscordRPCEnabled == true && DiscordRPCInitizialized == false)
            {
                //Create Client
                client = new DiscordRPC.DiscordRpcClient("807752124078620732");
                //Set the logger (Disabled for now ..)
                //client.Logger = new DiscordRPC.Logging.ConsoleLogger() { Level = DiscordRPC.Logging.LogLevel.Warning };
                //Subscribe to events
                client.OnReady += (sender, e) => { Console.WriteLine("Received Ready from user {0}", e.User.Username); };
                client.OnPresenceUpdate += (sender, e) => { Console.WriteLine("Received Update! {0}", e.Presence); };
                //Connect to the RPC
                client.Initialize();
                DiscordRPCInitizialized = true;
            }           
        }

        public static void SetDiscordRPCStatus(string details)
        {
            if (DiscordRPCEnabled == true)
            {
                if (StaticReferences.RibbonViewInstance.IsLoaded && StaticReferences.RibbonViewInstance.IsInitialized)
                {
                    try
                    {
                        if (client != null)
                        {
                            client.SetPresence(new DiscordRPC.RichPresence()
                            {
                                Details = details,
                                Timestamps = new DiscordRPC.Timestamps() { Start = DateTime.UtcNow },
                                Assets = new DiscordRPC.Assets() { LargeImageKey = "bigwk", LargeImageText = "WolvenKit", }
                            });
                            client.Invoke();
                        }
                    }
                    catch { }
                }
            }
        }
    }
}
