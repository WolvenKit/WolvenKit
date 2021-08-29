using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		private CName _enterEvent;
		private CName _exitEvent;
		private CName _timeModeRTPC;

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get => GetProperty(ref _enterEvent);
			set => SetProperty(ref _enterEvent, value);
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get => GetProperty(ref _exitEvent);
			set => SetProperty(ref _exitEvent, value);
		}

		[Ordinal(3)] 
		[RED("timeModeRTPC")] 
		public CName TimeModeRTPC
		{
			get => GetProperty(ref _timeModeRTPC);
			set => SetProperty(ref _timeModeRTPC, value);
		}
	}
}
