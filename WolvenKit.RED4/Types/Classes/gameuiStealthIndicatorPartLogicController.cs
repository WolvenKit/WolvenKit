using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiStealthIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(3)] 
		[RED("arrowFrontWidget")] 
		public inkImageWidgetReference ArrowFrontWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("wrapper")] 
		public inkCompoundWidgetReference Wrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("stealthIndicatorDeadZoneAngle")] 
		public CFloat StealthIndicatorDeadZoneAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("slowestFlashTime")] 
		public CFloat SlowestFlashTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("lastValue")] 
		public CFloat LastValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("flashAnimProxy")] 
		public CHandle<inkanimProxy> FlashAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("scaleAnimDef")] 
		public CHandle<inkanimDefinition> ScaleAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		public gameuiStealthIndicatorPartLogicController()
		{
			ArrowFrontWidget = new inkImageWidgetReference();
			Wrapper = new inkCompoundWidgetReference();
			StealthIndicatorDeadZoneAngle = 40.000000F;
			SlowestFlashTime = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
