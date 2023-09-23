using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TVControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(112)] 
		[RED("tvSetup")] 
		public TVSetup TvSetup
		{
			get => GetPropertyValue<TVSetup>();
			set => SetPropertyValue<TVSetup>(value);
		}

		[Ordinal(113)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(114)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(115)] 
		[RED("globalTVInitialized")] 
		public CBool GlobalTVInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("backupCustomChannels")] 
		public CArray<STvChannel> BackupCustomChannels
		{
			get => GetPropertyValue<CArray<STvChannel>>();
			set => SetPropertyValue<CArray<STvChannel>>(value);
		}

		public TVControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
