using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
