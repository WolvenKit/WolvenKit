using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TVControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("tvSetup")] 
		public TVSetup TvSetup
		{
			get => GetPropertyValue<TVSetup>();
			set => SetPropertyValue<TVSetup>(value);
		}

		[Ordinal(110)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(111)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(112)] 
		[RED("globalTVInitialized")] 
		public CBool GlobalTVInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("backupCustomChannels")] 
		public CArray<STvChannel> BackupCustomChannels
		{
			get => GetPropertyValue<CArray<STvChannel>>();
			set => SetPropertyValue<CArray<STvChannel>>(value);
		}

		public TVControllerPS()
		{
			DeviceName = "LocKey#97";
			TweakDBRecord = new() { Value = 46674876326 };
			TweakDBDescriptionRecord = new() { Value = 96486506199 };
			TvSetup = new() { Channels = new(), MuteInterface = true };
			DefaultGlitchVideoPath = new();
			BroadcastGlitchVideoPath = new();
			BackupCustomChannels = new();
		}
	}
}
