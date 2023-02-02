using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleChangeStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<vehicleEState> State
		{
			get => GetPropertyValue<CEnum<vehicleEState>>();
			set => SetPropertyValue<CEnum<vehicleEState>>(value);
		}

		public vehicleChangeStateEvent()
		{
			State = Enums.vehicleEState.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
