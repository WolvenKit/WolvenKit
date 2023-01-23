using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sensePlayerDetectionChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("oldDetectionValue")] 
		public CFloat OldDetectionValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("newDetectionValue")] 
		public CFloat NewDetectionValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public sensePlayerDetectionChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
