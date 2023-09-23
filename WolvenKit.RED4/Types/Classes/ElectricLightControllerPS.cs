using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricLightControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isConnectedToCLS")] 
		public CBool IsConnectedToCLS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("wasCLSInitTriggered")] 
		public CBool WasCLSInitTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ElectricLightControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
