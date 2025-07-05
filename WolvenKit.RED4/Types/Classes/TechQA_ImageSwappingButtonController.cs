using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public TechQA_ImageSwappingButtonController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
