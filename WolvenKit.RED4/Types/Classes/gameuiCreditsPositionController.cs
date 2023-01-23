using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCreditsPositionController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("namesText")] 
		public inkTextWidgetReference NamesText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiCreditsPositionController()
		{
			TitleText = new();
			NamesText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
