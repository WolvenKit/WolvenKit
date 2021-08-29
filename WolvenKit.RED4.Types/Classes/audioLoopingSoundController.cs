using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLoopingSoundController : RedBaseClass
	{
		private CName _playEvent;
		private CName _preStopEvent;
		private CName _stopEvent;

		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get => GetProperty(ref _playEvent);
			set => SetProperty(ref _playEvent, value);
		}

		[Ordinal(1)] 
		[RED("preStopEvent")] 
		public CName PreStopEvent
		{
			get => GetProperty(ref _preStopEvent);
			set => SetProperty(ref _preStopEvent, value);
		}

		[Ordinal(2)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetProperty(ref _stopEvent);
			set => SetProperty(ref _stopEvent, value);
		}
	}
}
