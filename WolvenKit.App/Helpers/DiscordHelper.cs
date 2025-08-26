using System;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public static class DiscordHelper
{
    private const string s_discordAppID = "897813293480169532";

    private static readonly DiscordRPC.Assets s_assets = new()
    {
        LargeImageKey = "bigwk", LargeImageText = "WolvenKit"
    };

    private static bool s_isEnabled = true;
    private static bool s_isInitialized = false;
    private static readonly DiscordRPC.Timestamps s_timestamp = new() { Start = DateTime.UtcNow };

    private static DiscordRPC.DiscordRpcClient? s_client;

    public static ILoggerService? LoggerService { private get; set; }

    public static void InitializeDiscordRPC()
    {
        if (!s_isEnabled || s_isInitialized)
        {
            return;
        }

        s_isInitialized = true;

        s_client = new DiscordRPC.DiscordRpcClient(s_discordAppID);
        s_client.OnReady += (_, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);
        s_client.OnPresenceUpdate += (_, e) => Console.WriteLine("Received Update! {0}", e.Presence);
        s_client.Initialize();

        s_isInitialized = true;
    }

    private static void SetStatusInternal(string details, string projectName)
    {
        DiscordRPC.RichPresence presence = new()
        {
            Details = details,
            State = string.IsNullOrEmpty(projectName) ? string.Empty : $"Project {projectName}",
            Timestamps = s_timestamp,
            Assets = s_assets
        };

        try
        {
            s_client?.SetPresence(presence);
            s_client?.Invoke();
        }
        catch (Exception ex)
        {
            LoggerService?.Error($"Failed to update Discord RCP presence: {ex.Message}");
        }
    }

    /// <summary>
    /// This will do nothing if DiscordRPC is disabled in settings.
    /// </summary>
    /// <param name="details"></param>
    /// <param name="projectName"></param>
    public static void SetDiscordRPCStatus(string details, string projectName)
    {
        if (!s_isEnabled)
        {
            return;
        }

        SetStatusInternal(details, projectName);
    }

    public static void SetEnabled(bool statusFromSettings)
    {
        if (s_isEnabled == statusFromSettings)
        {
            return;
        }

        s_isEnabled = statusFromSettings;

        InitializeDiscordRPC();
        SetStatusInternal(string.Empty, string.Empty);
    }
}
