using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CentaurShieldStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<ECentaurShieldState> NewState
		{
			get => GetPropertyValue<CEnum<ECentaurShieldState>>();
			set => SetPropertyValue<CEnum<ECentaurShieldState>>(value);
		}

		public CentaurShieldStateChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
