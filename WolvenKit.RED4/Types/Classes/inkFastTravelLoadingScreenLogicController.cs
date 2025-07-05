using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkFastTravelLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] 
		[RED("mainBackgroundImage")] 
		public inkImageWidgetReference MainBackgroundImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("supportBackgroundImage")] 
		public inkImageWidgetReference SupportBackgroundImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("loopAnimationName")] 
		public CName LoopAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("tooltipAnimName")] 
		public CName TooltipAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("breathInAnimName")] 
		public CName BreathInAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("breathOutAnimName")] 
		public CName BreathOutAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("tooltipsWidget")] 
		public inkRichTextBoxWidgetReference TooltipsWidget
		{
			get => GetPropertyValue<inkRichTextBoxWidgetReference>();
			set => SetPropertyValue<inkRichTextBoxWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("progressBarController")] 
		public CWeakHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>();
			set => SetPropertyValue<CWeakHandle<LoadingScreenProgressBarController>>(value);
		}

		public inkFastTravelLoadingScreenLogicController()
		{
			MainBackgroundImage = new inkImageWidgetReference();
			SupportBackgroundImage = new inkImageWidgetReference();
			TooltipsWidget = new inkRichTextBoxWidgetReference();
			ProgressBarRoot = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
