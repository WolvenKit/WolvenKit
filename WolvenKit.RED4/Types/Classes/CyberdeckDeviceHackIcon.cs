using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckDeviceHackIcon : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public CyberdeckDeviceHackIcon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
