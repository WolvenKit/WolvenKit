using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseDestructibleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("destroyed")] 
		public CBool Destroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseDestructibleControllerPS()
		{
			DeviceName = "LocKey#127";
			TweakDBRecord = "Devices.TrafficLight";
			TweakDBDescriptionRecord = 137459607504;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
