using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiNewsFeedDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("newsTitleWidget")] 
		public inkTextWidgetReference NewsTitleWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("randomNewsLibraryWidget")] 
		public CName RandomNewsLibraryWidget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("randomNewsContainer")] 
		public inkCompoundWidgetReference RandomNewsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiNewsFeedDisplayController()
		{
			NewsTitleWidget = new();
			RandomNewsContainer = new();
		}
	}
}
