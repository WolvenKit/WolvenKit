using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerWokrspotDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetPropertyValue<SWorkspotData>();
			set => SetPropertyValue<SWorkspotData>(value);
		}

		public PlayerWokrspotDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			PlayerWorkspot = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
