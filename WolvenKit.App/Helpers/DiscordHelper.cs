using System;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class DiscordHelper
    {
        #region Fields

        public static DiscordRPC.DiscordRpcClient client;
        public static string DiscordAppID = "897813293480169532";
        public static bool IsEnabled = true;
        public static bool IsInitialized = false;

        #endregion Fields

        #region Methods

        public static void Initialize()
        {
            client = new DiscordRPC.DiscordRpcClient(DiscordAppID);
            client.OnReady += (sender, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);
            client.OnPresenceUpdate += (sender, e) => Console.WriteLine("Received Update! {0}", e.Presence);
            client.Initialize();
            IsInitialized = true;
        }

        public static void SetStatus(string details)
        {
            if (client == null)
            {
                Console.WriteLine("Client is null, failed to set status");
                return;
            }

            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = details,
                Timestamps = new DiscordRPC.Timestamps() { Start = DateTime.UtcNow },
                Assets = new DiscordRPC.Assets() { LargeImageKey = "bigwk", LargeImageText = "WolvenKit", }
            });

            client.Invoke();
        }

        public static void Deinitialize() => client.Dispose();

        #endregion Methods

        #region Enums
        enum Status { }
        #endregion
    }
}
