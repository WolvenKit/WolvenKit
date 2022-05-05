using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_Valued : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimEvent_Valued()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
