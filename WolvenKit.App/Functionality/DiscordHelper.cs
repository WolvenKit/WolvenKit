using System;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class DiscordHelper
    {
        public static string DiscordAppID = "807752124078620732";
        public static DiscordRPC.DiscordRpcClient client;
        public static bool DiscordRPCEnabled = true;
        public static bool DiscordRPCInitizialized = false;

        public static void InitializeDiscordRPC()
        {
            if (DiscordRPCEnabled == true && DiscordRPCInitizialized == false)
            {
                client = new DiscordRPC.DiscordRpcClient(DiscordAppID);
                client.OnReady += (sender, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);
                client.OnPresenceUpdate += (sender, e) => Console.WriteLine("Received Update! {0}", e.Presence);
                client.Initialize();
                DiscordRPCInitizialized = true;
            }
        }

        public static void SetDiscordRPCStatus(string details)
        {
            if (DiscordRPCEnabled == true)
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
