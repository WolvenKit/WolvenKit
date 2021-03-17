using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioScanningSettings : CVariable
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

		public audioScanningSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
