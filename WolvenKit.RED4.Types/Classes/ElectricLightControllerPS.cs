using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			TweakDBRecord = new() { Value = 90241852909 };
			TweakDBDescriptionRecord = new() { Value = 142476847136 };
		}
	}
}
