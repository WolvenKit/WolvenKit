using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleChangeStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<vehicleEState> NewState
		{
			get => GetPropertyValue<CEnum<vehicleEState>>();
			set => SetPropertyValue<CEnum<vehicleEState>>(value);
		}

		[Ordinal(1)] 
		[RED("oldState")] 
		public CEnum<vehicleEState> OldState
		{
			get => GetPropertyValue<CEnum<vehicleEState>>();
			set => SetPropertyValue<CEnum<vehicleEState>>(value);
		}

		public vehicleChangeStateEvent()
		{
			NewState = Enums.vehicleEState.Default;
			OldState = Enums.vehicleEState.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
