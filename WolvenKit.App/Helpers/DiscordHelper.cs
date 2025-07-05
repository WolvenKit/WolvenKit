using System;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public static class DiscordHelper
{
    public static DiscordRPC.DiscordRpcClient? Client;
    private const string s_discordAppID = "897813293480169532";
    public static bool DiscordRPCEnabled = true;
    private static bool s_discordRPCInitialized = false;

    public static void InitializeDiscordRPC()
    {
        if (DiscordRPCEnabled != true || s_discordRPCInitialized != false)
        {
            return;
        }

        Client = new DiscordRPC.DiscordRpcClient(s_discordAppID);
        Client.OnReady += (sender, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);
        Client.OnPresenceUpdate += (sender, e) => Console.WriteLine("Received Update! {0}", e.Presence);
        Client.Initialize();

        SetDiscordRPCStatus("No project selected yet", "", null);

        s_discordRPCInitialized = true;
    }

    public static void SetDiscordRPCStatus(string details, string state, ILoggerService? logger)
    {
        if (DiscordRPCEnabled != true || Client == null)
        {
            return;
        }

        try
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
        catch (Exception ex)
        {
            logger?.Error(ex);
        }
    }
}
