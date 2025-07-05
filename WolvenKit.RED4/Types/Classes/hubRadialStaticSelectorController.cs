using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hubRadialStaticSelectorController : inkSelectorController
	{
		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("leftArrowController")] 
		public CWeakHandle<inkInputDisplayController> LeftArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(20)] 
		[RED("rightArrowController")] 
		public CWeakHandle<inkInputDisplayController> RightArrowController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public CArray<MenuData> Data
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(22)] 
		[RED("widgetsControllers")] 
		public CArray<CWeakHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>();
			set => SetPropertyValue<CArray<CWeakHandle<HubMenuLabelContentContainer>>>(value);
		}

		[Ordinal(23)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("currentParent")] 
		public CInt32 CurrentParent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("currentData")] 
		public CArray<MenuData> CurrentData
		{
			get => GetPropertyValue<CArray<MenuData>>();
			set => SetPropertyValue<CArray<MenuData>>(value);
		}

		[Ordinal(26)] 
		[RED("lineTranslationAnimProxy")] 
		public CHandle<inkanimProxy> LineTranslationAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("lineSizeAnimProxy")] 
		public CHandle<inkanimProxy> LineSizeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("instantLineUpdateRequested")] 
		public CBool InstantLineUpdateRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("animationsRetryDiv")] 
		public CFloat AnimationsRetryDiv
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("debugText")] 
		public inkTextWidgetReference DebugText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public hubRadialStaticSelectorController()
		{
			LeftArrowWidget = new inkWidgetReference();
			RightArrowWidget = new inkWidgetReference();
			Container = new inkWidgetReference();
			Line = new inkWidgetReference();
			Data = new();
			WidgetsControllers = new();
			CurrentData = new();
			DebugText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
