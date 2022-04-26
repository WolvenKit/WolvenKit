using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloDevice : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("questFactName")] 
		public CName QuestFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HoloDevice()
		{
			ControllerTypeName = "HoloDeviceController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
