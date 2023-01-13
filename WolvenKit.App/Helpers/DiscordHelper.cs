using System;
using System.Runtime.CompilerServices;
using DiscordRPC;
using Splat;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class DiscordHelper
    {
        public static DiscordRPC.DiscordRpcClient Client;
        public static string DiscordAppID = "1063530665448067132";
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


                SetDiscordRPCStatus("No project selected yet", "");
                
                DiscordRPCInitizialized = true;
            }
        }

        public static void UpdateDiscordRPCDetails(string details)
        {
            if (DiscordRPCEnabled == true)
            {
                try
                {
                    if (Client != null)
                    {
                        DiscordRPC.RichPresence rpc = Client.CurrentPresence.Clone();
                        rpc.Details = details;
                        rpc.Timestamps = new DiscordRPC.Timestamps() { Start = DateTime.UtcNow };
                        Client.SetPresence(rpc);
                        Client.Invoke();
                    }
                } 
                catch(Exception ex)
                {
                    Locator.Current.GetService<ILoggerService>().Error(ex);
                }
            }
        }

        public static void UpdateDiscordRPCState(string state)
        {
            if (DiscordRPCEnabled == true)
            {
                try
                {
                    if (Client != null)
                    {
                        DiscordRPC.RichPresence rpc = Client.CurrentPresence.Clone();
                        rpc.State = state;
                        rpc.Timestamps = new DiscordRPC.Timestamps() { Start = DateTime.UtcNow };
                        Client.SetPresence(rpc);
                        Client.Invoke();
                    }
                }
                catch (Exception ex)
                {
                    Locator.Current.GetService<ILoggerService>().Error(ex);
                }
            }
        }

        public static void SetDiscordRPCStatus(string details, string state)
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
                            Assets = new DiscordRPC.Assets() { LargeImageKey = "wolvenlarge", LargeImageText = "WolvenKit", }
                        });
                        Client.Invoke();
                    }
                }
                catch (Exception ex) { Locator.Current.GetService<ILoggerService>().Error(ex); }
            }
        }
    }
}
