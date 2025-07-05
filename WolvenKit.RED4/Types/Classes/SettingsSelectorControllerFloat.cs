using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerFloat : SettingsSelectorControllerRange
	{
		[Ordinal(20)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("sliderController")] 
		public CWeakHandle<inkSliderController> SliderController
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		public SettingsSelectorControllerFloat()
		{
			SliderWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
