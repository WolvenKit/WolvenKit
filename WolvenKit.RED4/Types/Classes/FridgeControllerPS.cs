using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FridgeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FridgeControllerPS()
		{
			DeviceName = "LocKey#79";
			TweakDBRecord = "Devices.Fridge";
			TweakDBDescriptionRecord = 115920876132;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
