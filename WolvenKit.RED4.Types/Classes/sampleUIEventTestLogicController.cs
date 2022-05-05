using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUIEventTestLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("eventTextWidgetPath")] 
		public CName EventTextWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("eventVerticalPanelPath")] 
		public CName EventVerticalPanelPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("callbackTextWidgetPath")] 
		public CName CallbackTextWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("callbackVerticalPanelPath")] 
		public CName CallbackVerticalPanelPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("customCallbackName")] 
		public CName CustomCallbackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("verticalPanelWidget")] 
		public CWeakHandle<inkVerticalPanelWidget> VerticalPanelWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public sampleUIEventTestLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
