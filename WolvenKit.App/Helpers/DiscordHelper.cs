using System;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public static class DiscordHelper
{
    public static DiscordRPC.DiscordRpcClient? Client;
    public static string DiscordAppID = "897813293480169532";
    public static bool DiscordRPCEnabled = true;
    public static bool DiscordRPCInitizialized = false;

    public static void InitializeDiscordRPC()
    {
        if (DiscordRPCEnabled == true && DiscordRPCInitizialized == false)
        {
            Client = new DiscordRPC.DiscordRpcClient(DiscordAppID);
            Client.OnReady += (sender, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);
            Client.OnPresenceUpdate += (sender, e) => Console.WriteLine("Received Update! {0}", e.Presence);
            Client.Initialize();
            DiscordRPCInitizialized = true;
        }
    }

    public static void SetDiscordRPCStatus(string details, string state, ILoggerService logger)
    {
        if (DiscordRPCEnabled == true)
        {
            try
            {
                if (Client != null)
                {
                    Client.SetPresence(new DiscordRPC.RichPresence()
                    {
                        Details = details,
                        State = state,
                        Timestamps = new DiscordRPC.Timestamps() { Start = DateTime.UtcNow },
                        Assets = new DiscordRPC.Assets() { LargeImageKey = "bigwk", LargeImageText = "WolvenKit", }
                    });
                    Client.Invoke();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
