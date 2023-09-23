using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimTranslationBetweenWidgetsInterpolator : inkanimTranslationInterpolator
	{
		[Ordinal(9)] 
		[RED("startWidgetPath")] 
		public CName StartWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("endWidgetPath")] 
		public CName EndWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkanimTranslationBetweenWidgetsInterpolator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
