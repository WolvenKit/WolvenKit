using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TVControllerPS : MediaDeviceControllerPS
	{
		private TVSetup _tvSetup;
		private redResourceReferenceScriptToken _defaultGlitchVideoPath;
		private redResourceReferenceScriptToken _broadcastGlitchVideoPath;
		private CBool _globalTVInitialized;
		private CArray<STvChannel> _backupCustomChannels;

		[Ordinal(109)] 
		[RED("tvSetup")] 
		public TVSetup TvSetup
		{
			get => GetProperty(ref _tvSetup);
			set => SetProperty(ref _tvSetup, value);
		}

		[Ordinal(110)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetProperty(ref _defaultGlitchVideoPath);
			set => SetProperty(ref _defaultGlitchVideoPath, value);
		}

		[Ordinal(111)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetProperty(ref _broadcastGlitchVideoPath);
			set => SetProperty(ref _broadcastGlitchVideoPath, value);
		}

		[Ordinal(112)] 
		[RED("globalTVInitialized")] 
		public CBool GlobalTVInitialized
		{
			get => GetProperty(ref _globalTVInitialized);
			set => SetProperty(ref _globalTVInitialized, value);
		}

		[Ordinal(113)] 
		[RED("backupCustomChannels")] 
		public CArray<STvChannel> BackupCustomChannels
		{
			get => GetProperty(ref _backupCustomChannels);
			set => SetProperty(ref _backupCustomChannels, value);
		}
	}
}
