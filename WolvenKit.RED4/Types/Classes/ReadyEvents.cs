using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReadyEvents : WeaponEventsTransition
	{
		[Ordinal(5)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ReadyEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
