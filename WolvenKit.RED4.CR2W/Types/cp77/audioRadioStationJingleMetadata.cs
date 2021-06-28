using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationJingleMetadata : CVariable
	{
		private CName _introJingleEvent;
		private CFloat _introDuration;
		private CName _middleJingleEvent;
		private CName _endJingleEvent;
		private CFloat _outroDuration;

		[Ordinal(0)] 
		[RED("introJingleEvent")] 
		public CName IntroJingleEvent
		{
			get => GetProperty(ref _introJingleEvent);
			set => SetProperty(ref _introJingleEvent, value);
		}

		[Ordinal(1)] 
		[RED("introDuration")] 
		public CFloat IntroDuration
		{
			get => GetProperty(ref _introDuration);
			set => SetProperty(ref _introDuration, value);
		}

		[Ordinal(2)] 
		[RED("middleJingleEvent")] 
		public CName MiddleJingleEvent
		{
			get => GetProperty(ref _middleJingleEvent);
			set => SetProperty(ref _middleJingleEvent, value);
		}

		[Ordinal(3)] 
		[RED("endJingleEvent")] 
		public CName EndJingleEvent
		{
			get => GetProperty(ref _endJingleEvent);
			set => SetProperty(ref _endJingleEvent, value);
		}

		[Ordinal(4)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get => GetProperty(ref _outroDuration);
			set => SetProperty(ref _outroDuration, value);
		}

		public audioRadioStationJingleMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
