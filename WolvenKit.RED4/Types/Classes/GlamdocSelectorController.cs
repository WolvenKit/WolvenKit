using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocSelectorController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("leftArrowAnchor")] 
		public inkWidgetReference LeftArrowAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("rightArrowAnchor")] 
		public inkWidgetReference RightArrowAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("inputsContainer")] 
		public inkWidgetReference InputsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("indicatorAnchors")] 
		public CArray<inkWidgetReference> IndicatorAnchors
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("normalFontSize")] 
		public CInt32 NormalFontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("smallFontSize")] 
		public CInt32 SmallFontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("verySmallFontSize")] 
		public CInt32 VerySmallFontSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("leftArrow")] 
		public CWeakHandle<inkButtonController> LeftArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(10)] 
		[RED("rightArrow")] 
		public CWeakHandle<inkButtonController> RightArrow
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(11)] 
		[RED("indicatorIndex")] 
		public CInt32 IndicatorIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("indicatorShowAnim")] 
		public CHandle<inkanimProxy> IndicatorShowAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("indicatorHideAnim")] 
		public CHandle<inkanimProxy> IndicatorHideAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("isDisabled")] 
		public CBool IsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public GlamdocSelectorController()
		{
			Label = new inkTextWidgetReference();
			LeftArrowAnchor = new inkWidgetReference();
			RightArrowAnchor = new inkWidgetReference();
			InputsContainer = new inkWidgetReference();
			IndicatorAnchors = new();
			Names = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
