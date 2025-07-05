using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PunkScoreSelectorControllerInt : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("labelMinWidget")] 
		public inkWidgetReference LabelMinWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("labelMaxWidget")] 
		public inkWidgetReference LabelMaxWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("newValue")] 
		public CInt32 NewValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("localValue")] 
		public CInt32 LocalValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(9)] 
		[RED("sliderButtonController")] 
		public CWeakHandle<inkButtonController> SliderButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(10)] 
		[RED("sliderAreaWidget")] 
		public inkWidgetReference SliderAreaWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("sliderHandleWidget")] 
		public inkWidgetReference SliderHandleWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("ValueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("HintsContainer")] 
		public inkWidgetReference HintsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PunkScoreSelectorControllerInt()
		{
			SliderWidget = new inkWidgetReference();
			LabelMinWidget = new inkWidgetReference();
			LabelMaxWidget = new inkWidgetReference();
			NewValue = 5;
			SliderAreaWidget = new inkWidgetReference();
			SliderHandleWidget = new inkWidgetReference();
			ValueText = new inkTextWidgetReference();
			LeftArrow = new inkWidgetReference();
			RightArrow = new inkWidgetReference();
			HintsContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
