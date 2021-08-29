using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_FootPlant : animAnimEvent
	{
		private CEnum<animEventSide> _side;
		private CName _customEvent;

		[Ordinal(3)] 
		[RED("side")] 
		public CEnum<animEventSide> Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		[Ordinal(4)] 
		[RED("customEvent")] 
		public CName CustomEvent
		{
			get => GetProperty(ref _customEvent);
			set => SetProperty(ref _customEvent, value);
		}
	}
}
