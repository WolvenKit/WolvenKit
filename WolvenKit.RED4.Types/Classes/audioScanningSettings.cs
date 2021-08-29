using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioScanningSettings : RedBaseClass
	{
		private CName _scanningStartEvent;
		private CName _scanningStopEvent;
		private CName _scanningCompleteEvent;
		private CName _scanningAvailableEvent;

		[Ordinal(0)] 
		[RED("scanningStartEvent")] 
		public CName ScanningStartEvent
		{
			get => GetProperty(ref _scanningStartEvent);
			set => SetProperty(ref _scanningStartEvent, value);
		}

		[Ordinal(1)] 
		[RED("scanningStopEvent")] 
		public CName ScanningStopEvent
		{
			get => GetProperty(ref _scanningStopEvent);
			set => SetProperty(ref _scanningStopEvent, value);
		}

		[Ordinal(2)] 
		[RED("scanningCompleteEvent")] 
		public CName ScanningCompleteEvent
		{
			get => GetProperty(ref _scanningCompleteEvent);
			set => SetProperty(ref _scanningCompleteEvent, value);
		}

		[Ordinal(3)] 
		[RED("scanningAvailableEvent")] 
		public CName ScanningAvailableEvent
		{
			get => GetProperty(ref _scanningAvailableEvent);
			set => SetProperty(ref _scanningAvailableEvent, value);
		}
	}
}
