using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkSliderController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("slidingAreaRef")] 
		public inkWidgetReference SlidingAreaRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("handleRef")] 
		public inkWidgetReference HandleRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("nextRef")] 
		public inkWidgetReference NextRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("priorRef")] 
		public inkWidgetReference PriorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("direction")] 
		public CEnum<inkESliderDirection> Direction
		{
			get => GetPropertyValue<CEnum<inkESliderDirection>>();
			set => SetPropertyValue<CEnum<inkESliderDirection>>(value);
		}

		[Ordinal(6)] 
		[RED("autoSizeHandle")] 
		public CBool AutoSizeHandle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("minHandleSize")] 
		public CFloat MinHandleSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("maxHandleSize")] 
		public CFloat MaxHandleSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("percentHandleSize")] 
		public CFloat PercentHandleSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("minimumValue")] 
		public CFloat MinimumValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("maximumValue")] 
		public CFloat MaximumValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("step")] 
		public CFloat Step
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("SliderInput")] 
		public inkSliderControllerInputCallback SliderInput
		{
			get => GetPropertyValue<inkSliderControllerInputCallback>();
			set => SetPropertyValue<inkSliderControllerInputCallback>(value);
		}

		[Ordinal(15)] 
		[RED("SliderValueChanged")] 
		public inkSliderControllerValueChangeCallback SliderValueChanged
		{
			get => GetPropertyValue<inkSliderControllerValueChangeCallback>();
			set => SetPropertyValue<inkSliderControllerValueChangeCallback>(value);
		}

		[Ordinal(16)] 
		[RED("SliderHandleReleased")] 
		public inkSliderControllerHandleReleasedCallback SliderHandleReleased
		{
			get => GetPropertyValue<inkSliderControllerHandleReleasedCallback>();
			set => SetPropertyValue<inkSliderControllerHandleReleasedCallback>(value);
		}

		public inkSliderController()
		{
			SlidingAreaRef = new();
			HandleRef = new();
			NextRef = new();
			PriorRef = new();
			MinHandleSize = 20.000000F;
			PercentHandleSize = 0.100000F;
			MaximumValue = 1.000000F;
			SliderInput = new();
			SliderValueChanged = new();
			SliderHandleReleased = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
