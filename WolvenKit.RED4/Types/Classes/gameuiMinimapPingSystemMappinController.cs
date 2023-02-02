using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapPingSystemMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("rootWidget")] 
		public inkWidgetReference RootWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiMinimapPingSystemMappinController()
		{
			RootWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
