using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Fridge : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		[Ordinal(95)] 
		[RED("factOnDoorOpened")] 
		public CName FactOnDoorOpened
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Fridge()
		{
			ControllerTypeName = "FridgeController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
