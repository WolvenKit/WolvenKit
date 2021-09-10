using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Fridge : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SimpleDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_SimpleDevice>>(value);
		}

		[Ordinal(98)] 
		[RED("factOnDoorOpened")] 
		public CName FactOnDoorOpened
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public Fridge()
		{
			ControllerTypeName = "FridgeController";
		}
	}
}
