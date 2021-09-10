using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_FootPlant : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("side")] 
		public CEnum<animEventSide> Side
		{
			get => GetPropertyValue<CEnum<animEventSide>>();
			set => SetPropertyValue<CEnum<animEventSide>>(value);
		}

		[Ordinal(4)] 
		[RED("customEvent")] 
		public CName CustomEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
