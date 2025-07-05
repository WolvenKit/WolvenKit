using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericDeviceActionsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get => GetPropertyValue<SGenericDeviceActionsData>();
			set => SetPropertyValue<SGenericDeviceActionsData>(value);
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetPropertyValue<SCustomDeviceActionsData>();
			set => SetPropertyValue<SCustomDeviceActionsData>(value);
		}

		public GenericDeviceActionsData()
		{
			StateActionsOverrides = new SGenericDeviceActionsData { ToggleON = new SDeviceActionBoolData(), TogglePower = new SDeviceActionBoolData() };
			CustomActions = new SCustomDeviceActionsData { Actions = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
