using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWorldMapPlayerMappinController : gameuiBaseWorldMapMappinController
	{
		[Ordinal(28)] 
		[RED("coneIconWidget")] 
		public inkImageWidgetReference ConeIconWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public gameuiWorldMapPlayerMappinController()
		{
			ConeIconWidget = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
