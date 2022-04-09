using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FlickerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FlickerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
