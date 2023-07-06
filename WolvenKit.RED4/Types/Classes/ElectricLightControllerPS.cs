using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricLightControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isConnectedToCLS")] 
		public CBool IsConnectedToCLS
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(105)] 
		[RED("wasCLSInitTriggered")] 
		public CBool WasCLSInitTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ElectricLightControllerPS()
		{
			DeviceName = "LocKey#42165";
			TweakDBRecord = "Devices.ElectricLight";
			TweakDBDescriptionRecord = 142476847136;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
