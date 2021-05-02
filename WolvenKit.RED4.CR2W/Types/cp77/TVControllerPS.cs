using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVControllerPS : MediaDeviceControllerPS
	{
		private TVSetup _tvSetup;
		private redResourceReferenceScriptToken _defaultGlitchVideoPath;
		private redResourceReferenceScriptToken _broadcastGlitchVideoPath;
		private CBool _globalTVInitialized;
		private CArray<STvChannel> _backupCustomChannels;

		[Ordinal(108)] 
		[RED("tvSetup")] 
		public TVSetup TvSetup
		{
			get => GetProperty(ref _tvSetup);
			set => SetProperty(ref _tvSetup, value);
		}

		[Ordinal(109)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetProperty(ref _defaultGlitchVideoPath);
			set => SetProperty(ref _defaultGlitchVideoPath, value);
		}

		[Ordinal(110)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetProperty(ref _broadcastGlitchVideoPath);
			set => SetProperty(ref _broadcastGlitchVideoPath, value);
		}

		[Ordinal(111)] 
		[RED("globalTVInitialized")] 
		public CBool GlobalTVInitialized
		{
			get => GetProperty(ref _globalTVInitialized);
			set => SetProperty(ref _globalTVInitialized, value);
		}

		[Ordinal(112)] 
		[RED("backupCustomChannels")] 
		public CArray<STvChannel> BackupCustomChannels
		{
			get => GetProperty(ref _backupCustomChannels);
			set => SetProperty(ref _backupCustomChannels, value);
		}

		public TVControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
