using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PresetTimetableEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PresetTimetableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
